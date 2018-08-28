using Kimbap.ViewModel;
using System.Windows;
using static Kimbap.MainWindow;

namespace Kimbap
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static MenuViewModel menuViewModel = new MenuViewModel();
        public static TableViewModel tableViewModel = new TableViewModel();

        public delegate void SetControl(PageType pageType, int param);
        public static SetControl Controller;
    }
}
