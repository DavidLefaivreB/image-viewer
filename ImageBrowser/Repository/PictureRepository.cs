using System.Collections.Generic;
using ImageBrowser.Model;

namespace ImageBrowser.Repository
{
    public interface PictureRepository
    {
        List<Picture> RetrieveAll();
        List<Picture> RetrieveFor(HashSet<string> categoriesFilter, HashSet<string> franchisesFilter);
    }
}