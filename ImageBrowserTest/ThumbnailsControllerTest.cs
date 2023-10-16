using System.Collections.Generic;
using ImageBrowser.Controller;
using ImageBrowser.Notifier;
using ImageBrowser.Repository;
using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    public class ThumbnailsControllerTest
    {
        private ThumbnailsControllerChildren _thumbnailsController;

        [SetUp]
        public void Setup()
        {
            _thumbnailsController = new ThumbnailsControllerChildren();
        }

        [Test]
        public void selectingACategory_categoryIsAddedToList()
        {
            _thumbnailsController.AddCategory("Normal");
            Assert.That(_thumbnailsController.GetCategoriesFilter(), Is.EqualTo(new List<string> { "Normal" }));
        }

        [Test]
        public void removingACategory_categoryIsRemovedWithoutRemovingOther()
        {
            _thumbnailsController.AddCategory("Normal");
            _thumbnailsController.AddCategory("Alternate");

            _thumbnailsController.RemoveCategory("Normal");
            Assert.That(_thumbnailsController.GetCategoriesFilter(), Is.EqualTo(new List<string> { "Alternate" }));
        }

        [Test]
        public void selectingAFranchise_franchiseIsAddedToList()
        {
            _thumbnailsController.AddFranchise("Star Wars");
            Assert.That(_thumbnailsController.GetFranchisesFilter(), Is.EqualTo(new List<string> { "Star Wars" }));
        }

        [Test]
        public void removingAFranchise_franchiseIsRemovedWithoutRemovingOther()
        {
            _thumbnailsController.AddFranchise("Star Wars");
            _thumbnailsController.AddFranchise("One Piece");

            _thumbnailsController.RemoveFranchise("Star Wars");
            Assert.That(_thumbnailsController.GetFranchisesFilter(), Is.EqualTo(new List<string> { "One Piece" }));
        }
        
        [Test]
        public void clearingAllFranchises_clearAll()
        {
            _thumbnailsController.AddCategory("Normal");
            _thumbnailsController.AddCategory("Alternate");
            _thumbnailsController.AddFranchise("Star Wars");
            _thumbnailsController.AddFranchise("One Piece");

            _thumbnailsController.ClearAll();
            Assert.That(_thumbnailsController.GetFranchisesFilter(), Is.EqualTo(new List<string>()));
        }

        class ThumbnailsControllerChildren : ThumbnailsController
        {
            public ThumbnailsControllerChildren() : base(new PictureRepositoryInMemory(), new ThumbnailToDisplayNotifier())
            {
            }

            internal HashSet<string> GetCategoriesFilter()
            {
                return CategoriesFilter;
            }

            internal HashSet<string> GetFranchisesFilter()
            {
                return FranchisesFilter;
            }
        }
    }
}