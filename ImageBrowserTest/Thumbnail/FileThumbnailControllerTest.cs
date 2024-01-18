using System.Runtime.InteropServices.JavaScript;
using System.Windows.Forms;
using ImageBrowser.Thumbnail;
using Moq;

namespace ImageBrowserTest.Thumbnail;

[TestFixture]
public class FileThumbnailControllerTest
{
    private FileThumbnailController _fileThumbnailController;

    [SetUp]
    public void Init()
    {
        var thumbnailGenerator = new Mock<ThumbnailGenerator>();
        thumbnailGenerator.Setup(m =>
                m.GenerateThumbnail(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()))
            .Callback<string, string, int>(CopyFileToThumbnailsFolder);

        _fileThumbnailController = new FileThumbnailController(thumbnailGenerator.Object);
    }

    private static void CopyFileToThumbnailsFolder(string file, string destination, int size)
    {
        var fileInfo = new FileInfo(file);
        File.Copy(file, fileInfo.Directory + "/Thumbnails/" + fileInfo.Name);
    }

    [TearDown]
    public void RemoveThumbnailsFolder()
    {
        if (Directory.Exists("Assets/Thumbnails"))
            Directory.Delete("Assets/Thumbnails", true);
    }

    [Test]
    public void GivenOneFile_WhenCreatingThumbnail_ThenThumbnailIsAddedInThumbnails()
    {
        var files = new List<string> { "Assets/image1.jpg" };

        _fileThumbnailController.CreateThumbnailsFor(files);

        Assert.That(File.Exists("Assets/Thumbnails/image1.jpg"));
    }

    [Test]
    public void GivenMultipleFiles_WhenCreatingThumbnails_ThenThumbnailsAreAddedInThumbnails()
    {
        var files = new List<string> { "Assets/image1.jpg", "Assets/Image2.jpg" };

        _fileThumbnailController.CreateThumbnailsFor(files);

        Assert.That(File.Exists("Assets/Thumbnails/image1.jpg"));
        Assert.That(File.Exists("Assets/Thumbnails/image2.jpg"));
    }
    
    [Test]
    public void GivenThumbnailAlreadyExist_WhenCreatingThumbnail_ThenNothingIsDone()
    {
        Directory.CreateDirectory("Assets/Thumbnails");
        CopyFileToThumbnailsFolder("Assets/image1.jpg", "Assets/Thumbnails/image1.jpg", 0);
        var files = new List<string> { "Assets/image1.jpg" };

        _fileThumbnailController.CreateThumbnailsFor(files);

        Assert.That(File.Exists("Assets/Thumbnails/image1.jpg"));
    }

    [Test]
    public void GivenThumbnailExist_WhenGettingThumbnail_FileIsReturn()
    {
        _fileThumbnailController.CreateThumbnailsFor(new List<string> { "Assets/image1.jpg" });

        var thumbnailFile = _fileThumbnailController.GetFor("Assets/image1.jpg");

        var expected = new FileInfo("Assets/image1.jpg").Directory + "/Thumbnails/image1.jpg";
        Assert.That(thumbnailFile == expected);
    }
}