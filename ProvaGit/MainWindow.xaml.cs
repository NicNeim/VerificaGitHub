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
            Libro libro = new Libro(txtAutore.Text, txtTitolo.Text, int.Parse(txtAnno.Text), txtEditore.Text, int.Parse(txtPagine.Text));
            string infoLibro = libro.toString();

            lstLibri.Items.Add(infoLibro);
            MessageBox.Show("La lettura di questo libro impiegherà: " + libro.readingTime(libro.Pagine));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Biblioteca biblioteca = new Biblioteca(txtNome.Text, txtIndirizzo.Text, txtApertura.Text, txtChiusura.Text);
        }
    }
}
