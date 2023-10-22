using System.Collections.Generic;

namespace ImageBrowser.Repository
{
    public interface CategoryRepository
    {
        List<string> RetrieveAll();
    }
}