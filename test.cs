using System;
using System.Collections.Generic;
using System.Linq;
using System.txt;
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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private showAlrAdded()
        {
            MessageBox.Show("mar szerepel a listaban");
        }

        private void SzinKeveres()
        {
            rctTeglalap.Fill = new SolidColorBrush(
                Color.FromRgb(
                    Convert.ToByte(sliPiros.Value),
                    Convert.ToByte(sliZold.Value),
                    Convert.ToByte(sliKek.Value)
                )
            );
        }

        private void sliRGB_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            SzinKeveres();
        }

        private void btnRogzit_Click(object sender, RoutedEventArgs e)
        {
            string txt = $"{(byte)sliPiros.Value};{(byte)sliZold.Value};{(byte)sliKek.Value}";
            bool alrAdded = false;

            foreach (var item in lbSzinek.Items)
            {
                if ((string)item == txt)
                {
                    alrAdded = true;
                    break;
                }
            }

            if (!alrAdded)
            {
                lbSzinek.Items.Add(txt);
            }
            else
            {
                showAlrAdded();
            }
        }

        private void btnTorol_Click(object sender, RoutedEventArgs e)
        {
            string txt = $"{(byte)sliPiros.Value};{(byte)sliZold.Value};{(byte)sliKek.Value}";
            bool alrAdded = false;

            foreach (var item in lbSzinek.Items)
            {
                if ((string)item == txt)
                {
                    alrAdded = true;
                    break;
                }
            }

            if (!alrAdded)
            {
                lbSzinek.Items.Add(txt);
            }
            else
            {
                showAlrAdded();
            }
        }

        private void btnUrit_Click(object sender, RoutedEventArgs e) { }
    }
}
