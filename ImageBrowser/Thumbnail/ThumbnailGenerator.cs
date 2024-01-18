using System;
using System.IO;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace ImageBrowser.Thumbnail;

public class ThumbnailGenerator
{
    public virtual void GenerateThumbnail(string imagePath, string thumbnailPath, int size)
    {
        var image = new BitmapImage(new Uri(imagePath));
        var dimension = CalculateThumbnailDimension(image, size);
        var bitmapFrame = CreateResizedImage(image, dimension);
        
        WriteTransformedBitmapToFile<JpegBitmapEncoder>(bitmapFrame, thumbnailPath);
    }

    private static Size CalculateThumbnailDimension(BitmapSource image, int size)
    {
        Size dimension;

        if (image.Height > image.Width)
        {
            dimension.Height = size;
            var ratio = size / image.Height;
            dimension.Width = ratio * image.Width;
        }
        else
        {
            dimension.Width = size;
            var ratio = size / image.Width;
            dimension.Height = ratio * image.Height;
        }

        return dimension;
    }

    private static BitmapFrame CreateResizedImage(ImageSource source, Size dimension)
    {
        var rect = new Rect(0, 0, dimension.Width, dimension.Height);

        var group = new DrawingGroup();
        RenderOptions.SetBitmapScalingMode(group, BitmapScalingMode.HighQuality);
        group.Children.Add(new ImageDrawing(source, rect));

        var drawingVisual = new DrawingVisual();
        using (var drawingContext = drawingVisual.RenderOpen())
            drawingContext.DrawDrawing(group);

        var resizedImage = new RenderTargetBitmap((int)dimension.Width, (int)dimension.Height, 96, 96, PixelFormats.Default);
        resizedImage.Render(drawingVisual);

        return BitmapFrame.Create(resizedImage);
    }
    
    private static void WriteTransformedBitmapToFile<T>(BitmapSource bitmapSource, string fileName) where T : BitmapEncoder, new()
    {
        if (string.IsNullOrEmpty(fileName) || bitmapSource == null) return;

        //creating frame and putting it to Frames collection of selected encoder
        var frame = BitmapFrame.Create(bitmapSource);
        var encoder = new T();
        encoder.Frames.Add(frame);
        try
        {
            using var fs = new FileStream(fileName, FileMode.Create);
            encoder.Save(fs);
        }
        catch (Exception)
        {
        }
    }
}