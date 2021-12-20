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

namespace Pilske
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
     
        public MainWindow()
           
        
        {
            DatabaseDataContext db = new DatabaseDataContext();

            InitializeComponent();

            

        }

        private void BtnBieren_Click(object sender, RoutedEventArgs e)
        {
            Bieren objBieren = new Bieren();
            objBieren.Show();
        }

        private void BtnHapjes_Click(object sender, RoutedEventArgs e)
        {
            Hapjes objHapje = new Hapjes();
            objHapje.Show();
        }
    }
}
