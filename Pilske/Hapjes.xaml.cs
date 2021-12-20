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
    /// Interaction logic for Hapjes.xaml
    /// </summary>
    public partial class Hapjes : Window
    {
        DatabaseDataContext db = new DatabaseDataContext();
        HapjeController hc;
        public Hapjes()
        {
            InitializeComponent();
            hc = new HapjeController(db);
            dgHapjes.ItemsSource = hc.geefAllehapjes();
        }

       

        private void BtnOpslaanH_Click(object sender, RoutedEventArgs e)
        {
            string sHapje = txtHapje.Text;

            hc.opslaanHapjes(sHapje);
            dgHapjes.ItemsSource = hc.geefAllehapjes();
        }

        private void btnDeleteH_Click(object sender, RoutedEventArgs e)
        {
            var item = (hapje)dgHapjes.SelectedItem;
            hc.deleteHapjes(item);
            dgHapjes.ItemsSource = hc.geefAllehapjes();
        }

        private void btnWijzigH_Click(object sender, RoutedEventArgs e)
        {
            var item = (hapje)dgHapjes.SelectedItem;
            UpdateHapjes upProduct = new UpdateHapjes(db, item);
            upProduct.Show();
        }

        private void btnDoorvoerenH_Click(object sender, RoutedEventArgs e)
        {
            var item = (hapje)dgHapjes.SelectedItem;
            DateTime besteldatum = DateTime.Now;
            bestelling bestel = new bestelling();
            bestel.hapje = item;
            bestel.bestellingsDatum = besteldatum;
            db.bestellings.InsertOnSubmit(bestel);
            db.SubmitChanges();

            dgBestelling.ItemsSource = db.bestellings.ToList();

   
        }

        private void btnPopulariteitH_Click(object sender, RoutedEventArgs e)
        {
            PopFormH hetForm = new PopFormH(db);
            hetForm.Show();
        }
    }
    
}
