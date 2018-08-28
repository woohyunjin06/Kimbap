

using Kimbap.Model;
using System.Diagnostics;
using System.Windows.Controls;

namespace Kimbap.Control
{
    /// <summary>
    /// Interaction logic for TableControl.xaml
    /// </summary>
    public partial class TableControl : UserControl
    {
        public TableControl()
        {
            InitializeComponent();
            ListView.ItemsSource = App.tableViewModel.Items;
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Table tableData = (Table)ListView.SelectedItem;
            if (tableData != null)
            {
                App.Controller(MainWindow.PageType.MENU, tableData.TableNum - 1);
            }
        }
    }
}
