using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Media;

namespace fileBower
{
    [Serializable]
    public  class FileList
    {     
        private double left = 0;
        private double top = 0;
        private  ObservableCollection<FileName> fileName = new ObservableCollection<FileName>();

        public  void setFile(string filename,string filenameLastName)
        {
            fileName.Add(new FileName(filename, filenameLastName));
        }
        //获取FileName数组
        public  ObservableCollection<FileName> GetList()
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


    public class Visibilable : INotifyPropertyChanged
    {
        private string vi = "Hidden";
        private string stackState = "True";
        private string color = "white";

        public string Vi
        {
            get
            {
                return vi;
            }
            set
            {
                vi = value;
                if (this.PropertyChanged != null)                
                    this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Vi"));                
            }
        }

        public string StackState
        {
            get
            {
                return stackState;
            }
            set
            {
                stackState = value;
                if (this.PropertyChanged != null)
                    this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("StackState"));
            }
        }

        public string ItemColor
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
                if (this.PropertyChanged != null)
                    this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("ItemColor"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
