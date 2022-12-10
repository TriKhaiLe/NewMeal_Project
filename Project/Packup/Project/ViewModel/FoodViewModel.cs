﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Project.ViewModel
{
    public class FoodViewModel:BaseViewModel
    {
        public ICommand SelectedCommand { get; set; }
        public FoodViewModel()
        {
            SelectedCommand = new RelayCommand<ListView>((p) => { return true; }, (p) => 
            {
                MessageBox.Show(p.SelectedItem.ToString());  
            });
        }
    }
}