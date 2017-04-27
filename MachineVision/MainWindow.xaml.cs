using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace FunctionManager
{




}











namespace MachineVision
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : NavigationWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Open_Picture(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ok");
        }
        private void Save_File(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("2");
        }
        private void Save_File_As(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("3");
        }

        private void Show_StackPanel(object sender, RoutedEventArgs e)
        {
       
        }




    }
}
