using System.Collections.Generic;
using ImageBrowser.Model;
using ImageBrowser.Ui;

namespace ImageBrowser.Notifier
{
    public class ThumbnailToDisplayNotifier
    {
        private List<ThumbnailsListener> listeners = new List<ThumbnailsListener>(); 
        
        public void AddListener(ThumbnailsListener listener)
        {
            listeners.Add(listener);
        }

        public void Notify(List<Picture> pictures)
        {
            listeners.ForEach(listener => listener.Notify(pictures));
        }
    }
}