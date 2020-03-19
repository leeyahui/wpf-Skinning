using System.Windows;

using Skinning.Util;

namespace Skinning
{
    /// <summary>
    /// Interaction logic for DemoWindow.xaml
    /// </summary>
    public partial class DemoWindow : Window
    {
        public DemoWindow()
        {
            InitializeComponent();
            ResourceHelper.LoadResource("pack://siteOfOrigin:,,,/Modes/GroupMode.xaml");
        }

        private void OnListViewClick(object sender, RoutedEventArgs e)
        {
            ResourceHelper.LoadResource("pack://siteOfOrigin:,,,/Modes/ListMode.xaml");
        }

        private void OnGroupViewClick(object sender, RoutedEventArgs e)
        {
            ResourceHelper.LoadResource("pack://siteOfOrigin:,,,/Modes/GroupMode.xaml");
        }

        private void OnTreeViewClick(object sender, RoutedEventArgs e)
        {
            ResourceHelper.LoadResource("pack://siteOfOrigin:,,,/Modes/TreeMode.xaml");
        }
    }
}
