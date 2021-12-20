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
    /// Interaction logic for PopFormH.xaml
    /// </summary>
    public partial class PopFormH : Window
    {
        public PopFormH()
        {
            InitializeComponent();
        }

        private DatabaseDataContext db;


        public PopFormH(DatabaseDataContext db)
        {
            InitializeComponent();
            this.db = db;


            foreach (var data in db.bestellings.GroupBy(a => a.hapje.hapje1)

            .Select(groep => new
            {
                hid = groep.Key,

                Teller = groep.Count()

            })
            .OrderBy(x => x.hid))
            {
                dgHapjes.Items.Add(data);
            }
        }


    }
}

