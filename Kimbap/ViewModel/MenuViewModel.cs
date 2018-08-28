using Kimbap.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Kimbap.Model.Menu;

namespace Kimbap.ViewModel
{
    public class MenuViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Menu> Items { get; set; }

        private bool IsDataLoaded { get; set; }

        public MenuViewModel()
        {
            Items = new ObservableCollection<Menu>();
            LoadData();
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public void LoadData()
        {
            StreamReader foodReader = new StreamReader("Food.csv", Encoding.GetEncoding("utf-8"));

            while (!foodReader.EndOfStream)
            {
                string foodInfo = foodReader.ReadLine();
                string[] foodInfoArr = foodInfo.Split(','); // [0] : 메뉴명, [1] : 가격, [2] : 카테고리

                Items.Add(new Menu { Type = Menu.StringToCategory(foodInfoArr[2]), Name = foodInfoArr[0], Price = Int32.Parse(foodInfoArr[1])  });
            }
        }
        
    }
}
