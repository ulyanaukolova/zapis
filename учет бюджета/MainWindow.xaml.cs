using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace учет_бюджета
{
    public partial class MainWindow : Window
    {
     

        public MainWindow()
        {
            InitializeComponent();
            Date.SelectedDate = DateTime.Today;

            int sump = 0;
            int summ = 0;
            foreach (var entry in )
            {
                if (entry.IsIncome == false)
                {
                    summ += entry.Money;
                }
                else
                {
                    sump += entry.Money;
                }

              
            }
        }
    }

        private void Create_tip_Click(object sender, RoutedEventArgs e)
        {
            okno2 win = new okno2();
            win.Show();
        }
    
}
