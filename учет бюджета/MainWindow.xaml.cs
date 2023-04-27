using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
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
        BindingList<Note> notes = new BindingList<Note>();
        public MainWindow()
        {
            InitializeComponent();
          
        }

        private void Create_tip_Click(object sender, RoutedEventArgs e)
        {
            okno2 okno2 = new okno2();
            okno2.parent = this;
            okno2.Show();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            foreach (Note note in notes)
            {
                if (note == notesList.SelectedItem)
                {
                    notes.Remove(note);
                    break;
                }
            }
            UpdateInfo();
        }
    }

    
}
