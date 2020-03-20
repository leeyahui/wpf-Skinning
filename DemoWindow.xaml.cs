using System;
using System.Windows;
using Skinning.Theme;
using Skinning.Util;

namespace Skinning
{
    /// <summary>
    /// Interaction logic for DemoWindow.xaml
    /// </summary>
    public partial class DemoWindow : Window
    {
        private readonly ThemeHelper _themeHelper = new ThemeHelper();
        public DemoWindow()
        {
            InitializeComponent();
            //ResourceHelper.LoadResource("pack://siteOfOrigin:,,,/Modes/GroupMode.xaml");
            var resource = new ResourceDictionary()
            {
                Source = new Uri("pack://siteOfOrigin:,,,/Modes/GroupMode.xaml", UriKind.RelativeOrAbsolute)
            };
            ITheme theme = _themeHelper.GetTheme();
            theme.EarthDataTemplate = resource["EarthDataTemplate"] as DataTemplate;
            _themeHelper.SetTheme(theme);
        }

        private void OnListViewClick(object sender, RoutedEventArgs e)
        {
            //ResourceHelper.LoadResource("pack://siteOfOrigin:,,,/Modes/ListMode.xaml");
            var resource = new ResourceDictionary()
            {
                Source = new Uri("pack://siteOfOrigin:,,,/Modes/ListMode.xaml", UriKind.RelativeOrAbsolute)
            };
            ITheme theme = _themeHelper.GetTheme();
            theme.EarthDataTemplate = resource["EarthDataTemplate"] as DataTemplate;
            _themeHelper.SetTheme(theme);
        }

        private void OnGroupViewClick(object sender, RoutedEventArgs e)
        {
            //ResourceHelper.LoadResource("pack://siteOfOrigin:,,,/Modes/GroupMode.xaml");
            var resource = new ResourceDictionary()
            {
                Source = new Uri("pack://siteOfOrigin:,,,/Modes/GroupMode.xaml", UriKind.RelativeOrAbsolute)
            };
            ITheme theme = _themeHelper.GetTheme();
            theme.EarthDataTemplate = resource["EarthDataTemplate"] as DataTemplate;
            _themeHelper.SetTheme(theme);
        }

        private void OnTreeViewClick(object sender, RoutedEventArgs e)
        {
            //ResourceHelper.LoadResource("pack://siteOfOrigin:,,,/Modes/TreeMode.xaml");
            var resource = new ResourceDictionary()
            {
                Source = new Uri("pack://siteOfOrigin:,,,/Modes/TreeMode.xaml", UriKind.RelativeOrAbsolute)
            };
            ITheme theme = _themeHelper.GetTheme();
            theme.EarthDataTemplate = resource["EarthDataTemplate"] as DataTemplate;
            _themeHelper.SetTheme(theme);
        }
    }
}
