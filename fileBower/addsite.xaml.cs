using fileBower.Data;
using System.Windows;
using System.Windows.Controls;

namespace fileBower
{
    /// <summary>
    /// addsite.xaml 的交互逻辑
    /// </summary>
    public partial class Addsite : Page
    {
        private Frame fatherFrame;
        private WebList webList;
        public Addsite(Frame frame,WebList webList)
        {
            this.webList = webList;
            this.fatherFrame = frame;
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            fatherFrame.Visibility = Visibility.Hidden;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (webname.Text != "" && webaddr.Text != "")
            {
                webList.SaveWeb(webname.Text,webaddr.Text);
                fatherFrame.Visibility = Visibility.Hidden;
                webname.Text = "";
                webaddr.Text = "";
            }
        }
    }
}
