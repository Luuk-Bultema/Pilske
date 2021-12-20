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
    /// Interaction logic for PopForm.xaml
    /// </summary>
    public partial class PopForm : Window
    {
        private DatabaseDataContext db;
       

        public PopForm(DatabaseDataContext db)
        {
            InitializeComponent();
            this.db = db;
            

            foreach (var data in db.bestellings.GroupBy(a => a.bieren.bier)

            .Select(groep => new
            {
                bid = groep.Key,

                Teller = groep.Count()

            })
            .OrderBy(x => x.bid))
            {
                dgBieren.Items.Add(data);
            }
        }


    }

}