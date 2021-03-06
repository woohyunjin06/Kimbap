﻿using Kimbap.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kimbap.ViewModel
{
    public class TableViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Table> Items { get; set; }

        private bool IsDataLoaded { get; set; }

        public TableViewModel()
        {
            Items = new ObservableCollection<Table>();
            LoadData();
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public void LoadData()
        {
            Items.Add(new Table(1));
            Items.Add(new Table(2));
            Items.Add(new Table(3));
            Items.Add(new Table(4));
            Items.Add(new Table(5));
            Items.Add(new Table(6));
            Items.Add(new Table(7));
            Items.Add(new Table(8));
        }
    }
}
