using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MultiSelectDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
             Items = new Dictionary<string, object>();
            Items.Add("Chennai", "MAS");
            Items.Add("Trichy", "TPJ");
            Items.Add("Bangalore", "SBC");
            Items.Add("Coimbatore", "CBE");

            SelectedItems = new Dictionary<string, object>();
            SelectedItems.Add("Chennai", "MAS");
            SelectedItems.Add("Trichy", "TPJ");


            MC.ItemsSource = Items;
            MC.SelectedItems = SelectedItems;
        }

         private Dictionary<string, object> _items;
        private Dictionary<string, object> _selectedItems;
      

        public Dictionary<string, object> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
                
            }
        }

        public Dictionary<string, object> SelectedItems
        {
            get
            {
                return _selectedItems;
            }
            set
            {
                _selectedItems = value;
                
            }
        }

        
    }
}
