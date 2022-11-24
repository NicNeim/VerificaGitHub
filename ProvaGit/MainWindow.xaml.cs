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

namespace ProvaGit
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

        private void btnAggiungi_Click(object sender, RoutedEventArgs e)
        {
            int numeroLibri = 0;
            Libro libro = new Libro(txtAutore.Text, txtTitolo.Text, int.Parse(txtAnno.Text), txtEditore.Text, int.Parse(txtPagine.Text));
            string infoLibro = libro.toString();

            lstLibri.Items.Add(infoLibro);
            MessageBox.Show("La lettura di questo libro impiegherà: " + libro.readingTime(libro.Pagine));

            foreach (string l in lstLibri.Items)
            {
                numeroLibri++;
            }

            lblNumeroLibri.Content = "Tot Libri = " + numeroLibri;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Biblioteca biblioteca = new Biblioteca(txtNome.Text, txtIndirizzo.Text, txtApertura.Text, txtChiusura.Text);
            //Questo è un commento aggiunto per poi scaricare la repository modificata così posso fare lo screenshot :D
        }

        private void btnTrovaLibro_Click(object sender, RoutedEventArgs e)
        {
            foreach (string libro in lstLibri.Items)
            {
                string[] informazioniSplittate = libro.Split(" ");
                string titolo = informazioniSplittate[3];

                if (titolo == txtTitoloLibro.Text)
                {
                    MessageBox.Show("Il libro esiste.");
                }
            }
        }

        private void btnTrovaPerAutore_Click(object sender, RoutedEventArgs e)
        {
            int numeroLibriTrovati = 0;
            foreach (string libro in lstLibri.Items)
            {
                string[] informazioniSplittate = libro.Split(" ");
                string autore = informazioniSplittate[1];
                numeroLibriTrovati++;
            }

            MessageBox.Show("Sono stati trovati " + numeroLibriTrovati + " libri con l'autore inserito.");
        }
    }
}
