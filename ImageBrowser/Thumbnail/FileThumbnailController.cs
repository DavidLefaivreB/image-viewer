using System.Collections.Generic;
using System.IO;

namespace ImageBrowser.Thumbnail;

public class FileThumbnailController
{
    private readonly ThumbnailGenerator _thumbnailGenerator;
    private static string ThumbnailsFolderName = "Thumbnails/";
    private static int ThumbnailSize = 200;

    public FileThumbnailController(ThumbnailGenerator thumbnailGenerator)
    {
        _thumbnailGenerator = thumbnailGenerator;
    }

    public void CreateThumbnailsFor(List<string> files)
    {
        files.ForEach(file =>
        {
            var fileInfo = new FileInfo(file);
            var thumbnailFolder = Directory.CreateDirectory(fileInfo.Directory + "/" + ThumbnailsFolderName);
            var destination = thumbnailFolder + fileInfo.Name;

            if (!File.Exists(destination))
                _thumbnailGenerator.GenerateThumbnail(file, destination, ThumbnailSize);
        });
    }

    public string GetFor(string file)
    {
        var fileInfo = new FileInfo(file);
        
        return fileInfo.Directory + "/" + ThumbnailsFolderName + fileInfo.Name;
    }
}