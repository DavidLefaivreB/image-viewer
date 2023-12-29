namespace ImageBrowser.Repository;

public interface RepositoryFactory
{
    CategoryRepository CreateCategoryRepository();
    FranchiseRepository CreateFranchiseRepository();
    PictureRepository CreatePictureRepository();
}