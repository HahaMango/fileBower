using System;

namespace fileBower.Data
{
    [Serializable]
    public class FileName
    {
        public FileName(string filename, string filenameLastName)
        {
            this.Filename = filename;
            this.FileNameLastName = filenameLastName;
        }

        public string Filename { get; set; }
        public string FileNameLastName { get; set; }

    }
}
