using System.Collections.Generic;
using static ImageBrowser.Repository.CategoryType;

namespace ImageBrowser.Repository.InMemory
{
    public class CategoryRepositoryInMemory : CategoryRepository
    {
        public List<string> RetrieveAll()
        {
            return new List<string> {"Bidon #1", "Bidon #2", "Bidon #3", "Bidon #4", "Bidon #5", "Bidon #6", "Bidon #7", "Bidon #8", "Bidon #9", "Bidon #10", "Bidon #11"};
        }
    }
}