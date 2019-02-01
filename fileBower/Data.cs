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

    [Serializable]
    public class WebList
    {
        private ObservableCollection<Website> weblist = new ObservableCollection<Website>();

        public void saveWeb(string webname,string webaddr)
        {
            weblist.Add(new Website(webname, webaddr));
        }

        public ObservableCollection<Website> getWeblist()
        {
            return weblist;
        }
    }

    [Serializable]
    public class Website
    {
        private string webName;
        private string webaddr;

        public Website(string webname,string webaddr)
        {
            this.webName = webname;
            this.webaddr = webaddr;
        }

        public string WebName
        {
            get
            {
                return this.webName;
            }
            set
            {
                this.webName = value;
            }
        }             

        public string Webaddr
        {
            get
            {
                return this.webaddr;
            }
            set
            {
                this.webaddr = value;
            }
        }
    }

    //启动位置x,y值
    [Serializable]
    public class Position
    {
        private double _left;
        private double _top;

        public double Left
        {
            get
            {
                return this._left;
            }
            set
            {
                this._left = value;
            }
        }

        public double Top 
        {
            get
            {
                return this._top;       
            }
            set
            {
                this._top = value;
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
