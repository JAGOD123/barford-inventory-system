﻿using System;
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
using System.Windows.Shapes;
using Barford_Inventory_System.Models;
using Barford_Inventory_System.ViewModels;

namespace Barford_Inventory_System
{
    /// <summary>
    /// Interaction logic for AddItemWindow.xaml
    /// </summary>
    public partial class AddItemWindow : Window
	{
		public AddItemWindow()
		{
			
			InitializeComponent();
			//ItemViewModel viewInventoryModel = new ItemViewModel();
			//this.DataContext = viewInventoryModel;
		}

		private void Button_Confirm_Click(object sender, RoutedEventArgs e)
		{
			
		}

		private void Button_Exit_Click(object sender, RoutedEventArgs e)
		{

		}
	}
}
