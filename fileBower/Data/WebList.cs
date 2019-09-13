using System;
using System.Collections.ObjectModel;

namespace fileBower.Data
{
    [Serializable]
    public class WebList
    {
        private ObservableCollection<Website> weblist = new ObservableCollection<Website>();

        public void SaveWeb(string webname, string webaddr)
        {
            weblist.Add(new Website(webname, webaddr));
        }

        public ObservableCollection<Website> GetWeblist()
        {
            return weblist;
        }
    }
}
