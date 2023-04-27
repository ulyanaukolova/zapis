using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace учет_бюджета
{
    /// <summary>
    /// Логика взаимодействия для okno2.xaml
    /// </summary>
    public partial class okno2 : Window
    {
        public string otvet { get; set; }
        public okno2()
        {
            InitializeComponent();
            inTag.Text = null;
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            otvet = inTag.Text;
            DialogResult = true;
        }
        private void InputDialog_OnClosing(object? sender, CancelEventArgs e)
        {
            if (DialogResult != true)
            {
                DialogResult = false;
            }
        }
    }
}
