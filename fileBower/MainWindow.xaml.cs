using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.ObjectModel;
using System.Diagnostics;
using fileBower.Data;

namespace fileBower
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private FileList _fileList;
        private WebList _webList;
        private Collection<FileName> _fileNameList = null;
        private Collection<Website> _webbufflist = null;
        private Visibilable _visibilable;

        public MainWindow()
        {
            InitializeComponent();        
            
            ProCount();
            _visibilable = (Visibilable)this.FindResource("visi");          

            ShowInTaskbar = false;
            this.Topmost = true;
            this.ResizeMode = ResizeMode.NoResize;

            WinHide wh = new WinHide(this);
            wh.BindEvent();

            this.MouseLeftButtonDown += MainWindow_MouseLeftButtonDown;

            _fileList = new FileList();
            _webList = new WebList();

            _fileNameList = _fileList.GetList();
            _webbufflist = _webList.GetWeblist();

            listbox1.ItemsSource = _fileNameList;
            listboxWeb.ItemsSource = _webbufflist;
        }

        //鼠标按住上方拖动事件
        private void MainWindow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //throw new NotImplementedException();
            Point point = Mouse.GetPosition(this);
            if (point.Y <= 25)
            {
                if (e.LeftButton == MouseButtonState.Pressed)
                {
                    this.DragMove();
                }
            }
        }

        //点击文件夹按钮的事件
        private void Click1(object sender, RoutedEventArgs e)
        {
            if (selectButton.Content.ToString() == "选择文件夹")
            {
                FolderBrowserDialog fd = new FolderBrowserDialog();
                if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string[] s = fd.SelectedPath.Split('\\');
                    _fileList.SetFile(fd.SelectedPath, s[s.Length - 1]);
                }
            }
            if (selectButton.Content.ToString() == "添加网址")
            {
                webframe.Visibility = Visibility.Visible;
            }
        }

        //点击listbox里面的元素的事件
        private void StackPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (switchbutton.IsChecked == false)
            {
                StackPanel sp = (StackPanel)sender;
                TextBlock tb = (TextBlock)sp.Children[1];
                Process.Start("Explorer", tb.Text);
            }else if(switchbutton.IsChecked == true)
            {
                StackPanel sp = (StackPanel)sender;
                TextBlock tb = (TextBlock)sp.Children[1];
                Process.Start(tb.Text);
            }
        }

        //点击关闭按钮事件
        private void Closeclick(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        //加载窗体事件
        private void Win_loaded(object sender, RoutedEventArgs e)
        {

            FileStream fs = null;
            FileStream webfile = null;
            FileStream positionfile = null;
            Position position = null;
            try
            {
                fs = new FileStream("C.dat", FileMode.Open);
                webfile = new FileStream("W.dat", FileMode.Open);
                positionfile = new FileStream("P.dat", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                BinaryFormatter wbf = new BinaryFormatter();
                BinaryFormatter pbf = new BinaryFormatter();           
                _fileList = (FileList)bf.Deserialize(fs);
                _webList = (WebList)wbf.Deserialize(webfile);
                position = (Position)pbf.Deserialize(positionfile);                       
                fs.Close();
                webfile.Close();
                positionfile.Close();
            }
            catch
            {
            }
            finally
            {
                _fileNameList = _fileList.GetList();
                listbox1.ItemsSource = _fileNameList;

                _webbufflist = _webList.GetWeblist();
                listboxWeb.ItemsSource = _webbufflist;

                webframe.Content = new Addsite(webframe, _webList);
            }
            if(position == null)
            {
                return;
            }
            this.Left = position.Left;
            this.Top = position.Top;
        }

        //窗体关闭事件
        private void Win_closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //序列化文件数据
            FileStream fs = new FileStream("C.dat", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();

            //序列化网站数据
            FileStream webfile = new FileStream("W.dat", FileMode.Create);
            BinaryFormatter wbf = new BinaryFormatter();

            //序列化窗口最后的x,y位置值
            FileStream pfile = new FileStream("P.dat", FileMode.Create);
            BinaryFormatter pbf = new BinaryFormatter();
            Position position = new Position();
            position.Left = this.Left;
            position.Top = this.Top;

            try
            {
                bf.Serialize(fs, _fileList);
                wbf.Serialize(webfile, _webList);
                pbf.Serialize(pfile, position);

            }
            catch
            {
                System.Windows.MessageBox.Show("序列化失败");
                throw;
            }
            finally
            {
                fs.Close();
                webfile.Close();
                pfile.Close();
            }
        }

        //打开资源管理器按钮事件
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("Explorer");
        }


        //每个列表相的删除按钮事件
        private void DeClick(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.Button button = (System.Windows.Controls.Button)sender;
            Grid panel = (Grid)button.Parent;
            StackPanel stackPanel = (StackPanel)panel.Children[0];
            TextBlock textBlock = (TextBlock)stackPanel.Children[1];
            if (switchbutton.IsChecked == false)
            {
                string filename = textBlock.Text;
                foreach (FileName file in _fileNameList)
                {
                    if (file.Filename == filename)
                    {
                        _fileNameList.Remove(file);
                        break;
                    }
                }
            }else if(switchbutton.IsChecked == true)
            {
                string webaddr = textBlock.Text;
                foreach (Website website in _webbufflist)
                {
                    if(website.Webaddr == webaddr)
                    {
                        _webbufflist.Remove(website);
                        break;
                    }
                }
            }
        }

        //防止两次启动
        private void ProCount()
        {
            int count = 0;
            //检测进程是否存在
            Process[] processList = Process.GetProcesses();
            Process processKill = null;           
            foreach (Process process in processList)
            {
                if (process.ProcessName == "fileBower")
                {
                    count++;
                    processKill = process;
                }
            }
            if (count > 1)
            {
                processKill.Kill();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (_visibilable.Vi == "Visible")
            {
                _visibilable.Vi = "Hidden";
                _visibilable.StackState = "true";
                _visibilable.ItemColor = "white";
            }
            else
            {
                _visibilable.Vi = "Visible";
                _visibilable.StackState = "false";
                _visibilable.ItemColor = "gray";
            }                
        }

        private void switchbutton_Click(object sender, RoutedEventArgs e)
        {
            if(switchbutton.IsChecked == true)
            {
                selectButton.Content = "添加网址";
            }
            else
            {
                selectButton.Content = "选择文件夹";
            }
        }
    }
}
