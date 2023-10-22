using System.Collections.Generic;
using static ImageBrowser.Repository.CategoryType;

namespace ImageBrowser.Repository
{
    public class CategoryRepositoryInMemory : CategoryRepository
    {
        public List<string> RetrieveAll()
        {
            return new List<string>(){Normal.ToString(), Alternate.ToString(), Lingerie.ToString(), Topless.ToString(), Bottomless.ToString(), Nude.ToString(), Pubes.ToString(), Tanline.ToString(), Cum.ToString(), Futacum.ToString(), Futa.ToString()};
        }
    }
}