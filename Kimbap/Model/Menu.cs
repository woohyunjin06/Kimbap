using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kimbap.Model
{
    public class Menu : INotifyPropertyChanged
    {
        public enum Category
        {
            ENTIRE,
            KIMBAP,
            RAMEN,
            MEAL,
            SNACK,
            CUTLET
        }

        public static String CategoryToString(Category category)
        {
            switch (category)
            {
                case Category.KIMBAP:
                    return "KIMBAP";
                case Category.MEAL:
                    return "MEAL";
                case Category.CUTLET:
                    return "CUTLET";
                case Category.SNACK:
                    return "SNACK";
                default:
                    return "ENTIRE";
            }
        }
        public static Category StringToCategory(string category)
        {
            switch (category)
            {
                case "KIMBAP":
                    return Category.KIMBAP;
                case "MEAL":
                    return Category.MEAL;
                case "CUTLET":
                    return Category.CUTLET;
                case "SNACK":
                    return Category.SNACK;
                default:
                    return Category.ENTIRE;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string name;
        public string Name
        {
            get => name;
            set
            {
                name = value;
                Image = Environment.CurrentDirectory + @"/Resources/"+CategoryToString(Type)+"/" + name + ".jpg";


                NotifyPropertyChanged("Name");
                NotifyPropertyChanged("Image");
            }
        }

        private string image;
        public string Image
        {
            get => image;
            set
            {
                image = value;
            }
        }

        private int price;
        public int Price
        {
            get => price;
            set
            {
                price = value;
                NotifyPropertyChanged("Price");
            }
        }

        private int orders;
        public int Orders
        {
            get => orders;
            set
            {
                orders = value;
            }
        }

        private Category type;
        public Category Type
        {
            get => type;
            set
            {
                type = value;
                NotifyPropertyChanged("Type");
            }
        }
    }
}
