using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace fileBower
{
    /// <summary>
    /// addsite.xaml 的交互逻辑
    /// </summary>
    public partial class addsite : Page
    {
        private Frame fatherFrame;
        private WebList webList;
        public addsite(Frame frame,WebList webList)
        {
            this.webList = webList;
            this.fatherFrame = frame;
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            fatherFrame.Visibility = Visibility.Hidden;
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            if (webname.Text != "" && webaddr.Text != "")
            {
                webList.saveWeb(webname.Text,webaddr.Text);
                fatherFrame.Visibility = Visibility.Hidden;
                webname.Text = "";
                webaddr.Text = "";
            }
        }
    }
}
