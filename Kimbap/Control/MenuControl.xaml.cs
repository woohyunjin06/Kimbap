using Kimbap.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;
using static Kimbap.Model.Menu;

namespace Kimbap.Control
{
    /// <summary>
    /// Interaction logic for MenuControl.xaml
    /// </summary>
    public partial class MenuControl : System.Windows.Controls.UserControl
    {
        public MenuControl()
        {
            InitializeComponent();
            ListView.ItemsSource = App.menuViewModel.Items;
        }

        private int index;

        public void SetItemIndex(int index)
        {
            Debug.WriteLine(index);
            this.index = index;
        }

        private void Category_Click(object sender, RoutedEventArgs e)
        {
            List<Menu> menus = new List<Menu>();
            Category foodType;
            var element = (FrameworkElement)sender;
            foodType = Menu.StringToCategory(element.Name);
            foreach (var c in App.menuViewModel.Items)
            {
                if (c.Type == foodType || foodType == Menu.Category.ENTIRE)
                {
                    menus.Add(c);
                }
            }
            ListView.ItemsSource = menus;
        }
    }
}
