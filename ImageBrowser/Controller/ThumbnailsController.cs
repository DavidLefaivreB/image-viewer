using System.Collections.Generic;
using ImageBrowser.Notifier;
using ImageBrowser.Repository;
using ImageBrowser.Utils;

namespace ImageBrowser.Controller
{
    public class ThumbnailsController
    {
        private readonly PictureRepository _pictureRepository;
        private readonly ThumbnailToDisplayNotifier _thumbnailToDisplayNotifier;

        [TestModifier("Need to be visible in test project")]
        protected HashSet<string> CategoriesFilter { get; }

        [TestModifier("Need to be visible in test project")]
        protected HashSet<string> FranchisesFilter { get; }

        public ThumbnailsController(PictureRepository pictureRepository, ThumbnailToDisplayNotifier thumbnailToDisplayNotifier)
        {
            _pictureRepository = pictureRepository;
            _thumbnailToDisplayNotifier = thumbnailToDisplayNotifier;
            
            CategoriesFilter = new HashSet<string>();
            FranchisesFilter = new HashSet<string>();
        }

        public void ClearAll()
        {
            CategoriesFilter.Clear();
            FranchisesFilter.Clear();
            _thumbnailToDisplayNotifier.Notify(_pictureRepository.RetrieveAll());
        }

        public void AddCategory(string category)
        {
            CategoriesFilter.Add(category);
            _thumbnailToDisplayNotifier.Notify(_pictureRepository.RetrieveFor(CategoriesFilter, FranchisesFilter));
        }

        public void RemoveCategory(string category)
        {
            CategoriesFilter.Remove(category);
            _thumbnailToDisplayNotifier.Notify(_pictureRepository.RetrieveFor(CategoriesFilter, FranchisesFilter));
        }

        public void AddFranchise(string franchise)
        {
            FranchisesFilter.Add(franchise);
            _thumbnailToDisplayNotifier.Notify(_pictureRepository.RetrieveFor(CategoriesFilter, FranchisesFilter));
        }

        public void RemoveFranchise(string category)
        {
            FranchisesFilter.Remove(category);
            _thumbnailToDisplayNotifier.Notify(_pictureRepository.RetrieveFor(CategoriesFilter, FranchisesFilter));
        }
    }
}