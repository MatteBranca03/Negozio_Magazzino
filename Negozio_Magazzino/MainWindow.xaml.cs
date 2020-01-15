using System;
using System.Collections.Generic;
using System.IO;
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

namespace Negozio_Magazzino
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string prodotto = txtProdotto.Text;
            double costo = double.Parse(txtPrezzo.Text);
            lblRisultato.Content += $"PRODOTTO: {prodotto}, PREZZO: {costo}\n";
            StreamWriter sw = new StreamWriter("pubblica.Text", true);
            {
                sw.WriteLine($"PRODOTTO: {prodotto}, PREZZO: {costo} \n");
            }
        }
    }
}

