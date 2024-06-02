using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ImageBrowser.Utils;

public class FileExtensionUtils
{
    static readonly List<string> SupportedExtension = new() { ".jpg", ".jpeg", ".png" };
    
    public static List<string> RetrieveValidExtensionFiles(IEnumerable<string> files)
    {
        return files.Where(file => SupportedExtension.Contains(Path.GetExtension(file).ToLowerInvariant())).ToList();
    }
}