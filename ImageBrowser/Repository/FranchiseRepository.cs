using System.Collections.Generic;

namespace ImageBrowser.Repository
{
    public interface FranchiseRepository
    {
        List<string> RetrieveAll();
    }
}