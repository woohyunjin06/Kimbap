
using System.Windows;

namespace Kimbap
{
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }


        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            App.Controller = ReplaceControl;
        }

        private void ReplaceControl(PageType pageType, int param)
        {
            tableControl.Visibility = Visibility.Collapsed;
            menuControl.Visibility = Visibility.Collapsed;
            switch (pageType)
            {
                case PageType.TABLE:
                    tableControl.Visibility = Visibility.Visible;
                    break;
                case PageType.MENU:
                    menuControl.Visibility = Visibility.Visible;
                    break;
            }
        }
        public enum PageType
        {
            TABLE,
            MENU
        }
    }
}
