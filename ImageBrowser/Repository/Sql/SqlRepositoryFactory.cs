namespace ImageBrowser.Repository.Sql;

public class SqlRepositoryFactory : RepositoryFactory
{
    public CategoryRepository CreateCategoryRepository()
    {
        return new SqlCategoryRepository();
    }

    public FranchiseRepository CreateFranchiseRepository()
    {
        return new SqlFranchiseRepository();
    }

    public PictureRepository CreatePictureRepository()
    {
        return new SqlPictureRepository();
    }
}