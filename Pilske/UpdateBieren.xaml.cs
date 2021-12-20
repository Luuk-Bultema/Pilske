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
    /// Interaction logic for UpdateBieren.xaml
    /// </summary>
    public partial class UpdateBieren : Window
    {
        private DatabaseDataContext db;
        private BierController bc;
        private bieren deproduct;
        public UpdateBieren(DatabaseDataContext db, bieren deproduct)
        {
            InitializeComponent();
            bc = new BierController(db);
            this.db = db;
            this.deproduct = deproduct;
            txtBier.Text = deproduct.bier;
        }

        

        private void BtnUpdateB_Click(object sender, RoutedEventArgs e)
        {
            string sBier = txtBier.Text;
            bc.updateBieren(deproduct, sBier);
            this.Close();
        }
    }
}
