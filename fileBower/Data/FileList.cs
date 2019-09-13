using System;
using System.Collections.ObjectModel;

namespace fileBower.Data
{
    [Serializable]
    public class FileList
    {
        private ObservableCollection<FileName> fileName = new ObservableCollection<FileName>();

        public void SetFile(string filename, string filenameLastName)
        {
            fileName.Add(new FileName(filename, filenameLastName));
        }
        //获取FileName数组
        public ObservableCollection<FileName> GetList()
        {
            return fileName;
        }
    }
}
