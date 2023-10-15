using System.Collections.Generic;
using System.ComponentModel;
using ImageBrowser.Utils;

namespace ImageBrowser.Controller
{
    public class ThumbnailsController
    {
        [TestModifier("Need to be visible in test project")]
        protected HashSet<string> CategoriesFilter { get; }

        [TestModifier("Need to be visible in test project")]
        protected HashSet<string> FranchisesFilter { get; }

        public ThumbnailsController()
        {
            CategoriesFilter = new HashSet<string>();
            FranchisesFilter = new HashSet<string>();
        }

        public static void ClearAll()
        {
        }

        public void AddCategory(string category)
        {
            CategoriesFilter.Add(category);
        }

        public void RemoveCategory(string category)
        {
            CategoriesFilter.Remove(category);
        }

        public void AddFranchise(string franchise)
        {
            FranchisesFilter.Add(franchise);
        }

        public void RemoveFranchise(string category)
        {
            FranchisesFilter.Remove(category);
        }
    }
}