using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kimbap.Model
{
    public class Table : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public Table(int TableNum)
        {
            tableNum = TableNum;
        }
        private int tableNum;
        public int TableNum
        {
            get => tableNum;
            set
            {
                tableNum = value;
                NotifyPropertyChanged("TableNum");
            }
        }

        private List<Menu> menu;
        public List<Menu> Menu
        {
            get => menu;
            set
            {
                menu = value;
                NotifyPropertyChanged("Menu");
            }
        }
    }
}
