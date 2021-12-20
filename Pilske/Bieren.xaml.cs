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
using System.Windows.Shapes;

namespace Pilske
{
    /// <summary>
    /// Interaction logic for Bieren.xaml
    /// </summary>
    public partial class Bieren : Window
    {
        DatabaseDataContext db = new DatabaseDataContext();
        BierController bc;
        public Bieren()
        {
            InitializeComponent();
            bc = new BierController(db);
            dgBier.ItemsSource = bc.geefAllebieren();

        }



        private void btnDeleteB_Click(object sender, RoutedEventArgs e)
        {
            var item = (bieren)dgBier.SelectedItem;
            bc.deleteBieren(item);
            dgBier.ItemsSource = bc.geefAllebieren();
        }

        private void btnWijzigB_Click(object sender, RoutedEventArgs e)
        {
            var item = (bieren)dgBier.SelectedItem;
            UpdateBieren upProduct = new UpdateBieren(db, item);
            upProduct.Show();
        }

        private void btnDoorvoerenB_Click(object sender, RoutedEventArgs e)
        {

            var item = (bieren)dgBier.SelectedItem;
           

            DateTime besteldatum = DateTime.Now;
            bestelling bestel = new bestelling();
            bestel.bieren = item;
            bestel.bestellingsDatum = besteldatum;
            db.bestellings.InsertOnSubmit(bestel);
            db.SubmitChanges();

            dgBestelling.ItemsSource = db.bestellings.ToList();

  
        }
       

        private void btnOpslaanB_Click(object sender, RoutedEventArgs e)
        {
            string sBier = txtBier.Text;

            bc.opslaanBieren(sBier);
            dgBier.ItemsSource = bc.geefAllebieren();
        }

       
  
        private void btnPopulair_Click(object sender, RoutedEventArgs e)
        {
            PopForm hetForm = new PopForm(db);
            hetForm.Show();
        }
    }
}
