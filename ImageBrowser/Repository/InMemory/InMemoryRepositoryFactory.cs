namespace ImageBrowser.Repository.InMemory;

public class InMemoryRepositoryFactory : RepositoryFactory
{
    public CategoryRepository CreateCategoryRepository()
    {
        return new CategoryRepositoryInMemory();
    }

    public FranchiseRepository CreateFranchiseRepository()
    {
        return new FranchiseRepositoryInMemory();
    }

    public PictureRepository CreatePictureRepository()
    {
        return new PictureRepositoryInMemory();
    }
}