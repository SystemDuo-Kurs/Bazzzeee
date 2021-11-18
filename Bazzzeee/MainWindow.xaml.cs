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

namespace Bazzzeee
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Kontekst _kontekst = new();
        public MainWindow()
        {
            InitializeComponent();
            _kontekst.Database.EnsureCreated();
            DatagridOsoba.ItemsSource = _kontekst.Osobas.Local.ToObservableCollection();

            _kontekst.Osobas.ToList();

         
        }

        private void Dodaj(object sender, RoutedEventArgs e)
        {
            _kontekst.Add(new Osoba { Ime = "Pera", Prezime = "Peric" });
            _kontekst.SaveChanges();
        }

        private void Brisi(object sender, RoutedEventArgs e)
        {
            if (DatagridOsoba.SelectedItem is not null)
            {
                _kontekst.Remove(DatagridOsoba.SelectedItem as Osoba);
                _kontekst.SaveChanges();
            }
        }
    }
}
