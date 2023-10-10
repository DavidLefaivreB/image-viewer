using System.Collections.Generic;
using static ImageBrowser.Repository.CategoryType;

namespace ImageBrowser.Repository
{
    public class CategoryRepository
    {
        public List<CategoryType> retrieveAll()
        {
            return new List<CategoryType>(){Normal, Alternate, Lingerie, Topless, Bottomless, Nude, Pubes, Tanline, Cum, Futacum, Futa};
        }
    }
}