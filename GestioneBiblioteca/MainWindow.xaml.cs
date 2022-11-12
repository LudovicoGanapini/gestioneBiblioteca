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

namespace GestioneBiblioteca
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //contatore numero libri

        int nLibri = 0;

        
        private void btnAggiungiLibro_Click(object sender, RoutedEventArgs e)
        {
            libro book = new libro();
            nLibri++;
            book.setTitolo(txtTitolo.Text);
            book.setAutore(txtAutore.Text);
            book.setPagine(int.Parse(txtPagine.Text)); 
        }

        private void btnCercaLibro_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnCercaAutore_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnStampaLibri_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCreaBiblioteca_Click(object sender, RoutedEventArgs e)
        {
            //nuovo oggetto biblioteca
            biblioteca biblioteca = new biblioteca();

        }
    }
}
