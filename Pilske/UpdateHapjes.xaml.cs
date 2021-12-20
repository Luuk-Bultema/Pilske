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
    /// Interaction logic for UpdateHapjes.xaml
    /// </summary>
    public partial class UpdateHapjes : Window
    {
        private DatabaseDataContext db;
        private HapjeController hc;
        private hapje deproduct;
        public UpdateHapjes(DatabaseDataContext db, hapje deproduct)
        {
            InitializeComponent();
            hc = new HapjeController(db);
            this.db = db;
            this.deproduct = deproduct;
            txtHapje.Text = deproduct.hapje1;
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            string sHapje = txtHapje.Text;
            hc.updateHapjes(deproduct, sHapje);
            this.Close();
        }
    }
}
