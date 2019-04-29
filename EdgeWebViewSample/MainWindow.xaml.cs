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

namespace EdgeWebViewSample
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private readonly Uri InitializeUrl = new Uri("https://google.co.jp");

        private void BtnWindowToBrowser_Click(object sender, RoutedEventArgs e)
        {
            var result = Browser.InvokeScript("eval", "document.getElementsByName('q')[0].value+='abc';");
        }

        private void BtnBrowserToWindow_Click(object sender, RoutedEventArgs e)
        {
            string htmlText = Browser.InvokeScript("eval", "document.getElementsByName('q')[0].value;");
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnHome_Click(object sender, RoutedEventArgs e)
        {
            InitializeBrowser();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            InitializeBrowser();
        }

        private void InitializeBrowser()
        {
            Browser.Source = InitializeUrl;
        }

        private void Browser_NavigationStarting(object sender, Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNavigationStartingEventArgs e)
        {

        }

        private void Browser_NavigationCompleted(object sender, Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNavigationCompletedEventArgs e)
        {

        }
    }
}
