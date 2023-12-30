using System.Collections.Generic;
using ImageBrowser.Model;

namespace ImageBrowser.Repository;

public sealed class RepositoryProvider
{
    private CategoryRepository _categoryRepository;
    private FranchiseRepository _franchiseRepository;
    private PictureRepository _pictureRepository;
    
    private RepositoryProvider()
    {
    }

    public static RepositoryProvider Instance { get; } = new();

    internal void SetRepositoryFactory(RepositoryFactory factory)
    {
        _categoryRepository = factory.CreateCategoryRepository();
        _franchiseRepository = factory.CreateFranchiseRepository();
        _pictureRepository = factory.CreatePictureRepository();
    }

    internal CategoryRepository getCategoryRepository()
    {
        return _categoryRepository;
    }

    public PictureRepository getPictureRepository()
    {
        return _pictureRepository;
    }
}