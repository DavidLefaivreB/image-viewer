using System.Collections.Generic;
using ImageBrowser.Repository;

namespace ImageBrowser.Model
{
    public class Picture
    {
        public string Name { get; }
        public string ThumbnailPath { get; }
        public string ImagePath { get; }
        public CategoryType Category { get; }
        public string Franchise { get; }
        public string Author { get; }

        public Picture(string name, string thumbnailPath, string imagePath, CategoryType category, string franchise, string author)
        {
            Name = name;
            ThumbnailPath = thumbnailPath;
            ImagePath = imagePath;
            Category = category;
            Franchise = franchise;
            Author = author;
        }
    }
}