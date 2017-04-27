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

namespace MachineVision
{


    internal class PropertyNodeItem
    {
        public string Icon { get; set; }
        public string DisplayName { get; set; }
        public string Name { get; set; }
        public List<PropertyNodeItem> Children { get; set; }
        public PropertyNodeItem()
        {
            Children = new List<PropertyNodeItem>();
        }
    }

    /// <summary>
    /// PageEditFunction.xaml 的交互逻辑
    /// </summary>
    public partial class PageEditFunction : Page
    {


        public PageEditFunction()
        {
            InitializeComponent();
            ShowTreeView();
        }


        private void ShowTreeView()
        {
            List<PropertyNodeItem> listItem = new List<PropertyNodeItem>();
            PropertyNodeItem mainNode = new PropertyNodeItem()
            {

                DisplayName = "功能菜单",
                Name = "主目录--功能菜单"
            };

            PropertyNodeItem systemNode = new PropertyNodeItem()
            {

                DisplayName = "系统设置",
                Name = "当前菜单--系统设置"
            };
            PropertyNodeItem pwdTag = new PropertyNodeItem()
            {

                DisplayName = "密码修改",
                Name = "当前选项--密码修改"
            };
            systemNode.Children.Add(pwdTag);
            mainNode.Children.Add(systemNode);
            listItem.Add(mainNode);
            this.tvProperty.ItemsSource = listItem;
        }

    }


}
