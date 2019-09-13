using System;

namespace fileBower.Data
{
    [Serializable]
    public class Website
    {
        public Website(string webname, string webaddr)
        {
            this.WebName = webname;
            this.Webaddr = webaddr;
        }

        public string WebName { get; set; }

        public string Webaddr { get; set; }
    }
}
