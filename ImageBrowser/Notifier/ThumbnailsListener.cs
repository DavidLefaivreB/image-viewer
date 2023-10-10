using System.Collections.Generic;
using ImageBrowser.Model;
using ImageBrowser.Repository;

namespace ImageBrowser.Notifier
{
    public interface ThumbnailsListener
    {
        void Notify(List<Picture> pictures);
    }
}