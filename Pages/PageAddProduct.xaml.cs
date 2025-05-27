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
using WpfApp4.AppDataFile;

namespace WpfApp4.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageAddProduct.xaml
    /// </summary>
    public partial class PageAddProduct : Page
    {
        bool LogicRb = false;
        public PageAddProduct()
        {
            InitializeComponent();          
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Product product = new Product() {
                    Title = TxtTitle.Text,
                    Cost = Convert.ToDecimal(TxtCost.Text),
                    Description = TxtDescription.Text,
                    MainImagePath = TxtImage.Text,
                    IsActive = LogicRb,
                    Manufacturer = CmbxOwner.SelectedItem as Manufacturer
                };

                ConnectOdb.conObj.Product.Add(product);
                ConnectOdb.conObj.SaveChanges();
                MessageBox.Show("Получилось!", "Notification", MessageBoxButton.OK, MessageBoxImage.Information);

            }

            catch (Exception er)
             {
                MessageBox.Show(er.Message.ToString());
            }
        }
    }
}
