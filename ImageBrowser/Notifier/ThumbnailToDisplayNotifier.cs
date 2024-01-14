using System.Collections.Generic;
using ImageBrowser.Model;

namespace ImageBrowser.Notifier
{
    public class ThumbnailToDisplayNotifier
    {
        private List<ThumbnailsListener> listeners = new();
        private List<Picture> _lastNotification = new();
        
        public void AddListener(ThumbnailsListener listener)
        {
            listeners.Add(listener);
            listener.Notify(_lastNotification);
        }

        public void ClearListeners()
        {
            listeners.Clear();
        }

        public void Notify(List<Picture> pictures)
        {
            listeners.ForEach(listener => listener.Notify(pictures));
            _lastNotification = pictures;
        }
    }
}