using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace fileBower
{
    [Serializable]
    public  class getFileName
    {
        private double left = 0;
        private double top = 0;
        private  ObservableCollection<FileName> fileName = new ObservableCollection<FileName>();

        public  void setFile(string filename,string filenameLastName)
        {
            fileName.Add(new FileName(filename, filenameLastName));
        }
        //获取FileName数组
        public  ObservableCollection<FileName> GetF()
        {
            return fileName;
        }
        //获取或设置left
        public double Left
        {
            get
            {
                return this.left;
            }
            set
            {
                this.left = value;
            }
        }

        //获取或设置top
        public double Top
        {
            get
            {
                return this.top;
            }
            set
            {
                this.top = value;
            }
        }
    }

    [Serializable]
    public class FileName
    {
        private string filename;
        private string filenameLastName;
        public FileName(string filename,string filenameLastName)
        {
            this.filename = filename;
            this.filenameLastName = filenameLastName;
        }
        
        public string Filename
        {
            get
            {
                return this.filename;
            }
            set
            {
                this.filename = value;
                //OnPropertyChanged("Filename");
            }
        }
        public string FileNameLastName
        {
            get
            {
                return this.filenameLastName;
            }
            set
            {
                this.filenameLastName = value;
                //OnPropertyChanged("FileNameLastName");
            }
        }

    }


}
