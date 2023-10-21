using System.Collections.Generic;

namespace ImageBrowser.Repository
{
    public class FranchiseRepositoryInMemory : FranchiseRepository
    {
        public List<string> RetrieveAll()
        {
            return new List<string>() { "DC", "Final Fantasy", "Kim Possible", "Marvel", "Metroid", "Star Wars"};
        }
    }
}