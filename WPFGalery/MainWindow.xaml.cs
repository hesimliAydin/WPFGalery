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
using static System.Net.Mime.MediaTypeNames;

namespace WPFGalery
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public List<Images> Imagess { get; set; }
        public Images image { get; set; }
        public int index { get; set; }

        public MainWindow()
        {
            Imagess= new List<Images>
            {
                new Images
                {
                    Name="Cristiano Ronaldo",
                    ImagePath="../../../Image/ronaldo.jpg",
                    Nationality="Portugal",
                    Price="500000000$",
                    Date=new DateTime(1985,05,05),
                    Description="Suuuuuuuiiii"
                },
                new Images
                {
                    Name="Lionel Messi",
                    ImagePath="../../../Image/messi.jpg",
                    Nationality="Argentina",
                    Price="470000000$",
                    Date=new DateTime(1987,09,22),
                    Description="Suuuuuuuiiii"
                },
                new Images
                {
                    Name="Fernando Maradona",
                    ImagePath="../../../Image/maradona.jpg",
                    Nationality="Argentina",
                    Price="3800000000$",
                    Date=new DateTime(1992,05,05),
                    Description="Suuuuuuuiiii"
                },
                new Images
                {
                    Name="Oliver Kahn",
                    ImagePath="../../../Image/kahn.jpg",
                    Nationality="Almanya",
                    Price="2700000000$",
                    Date=new DateTime(1969,07,15),
                    Description="Suuuuuuuiiii"
                },
                new Images
                {
                    Name="Pele",
                    ImagePath="../../../Image/pele.jpg",
                    Nationality="Brazil",
                    Price="3500000000$",
                    Date=new DateTime(1940,05,25),
                    Description="Suuuuuuuiiii"
                },
                new Images
                {
                    Name="Johan Cruyff",
                    ImagePath="../../../Image/cruyff.jpg",
                    Nationality="Holland",
                    Price="1900000000$",
                    Date=new DateTime(1947,09,25),
                    Description="Suuuuuuuiiii"
                },
                new Images
                {
                    Name="Carles Puyol",
                    ImagePath="../../../Image/puyol.jpg",
                    Nationality="Spain",
                    Price="3800000000$",
                    Date=new DateTime(1978,11,14),
                    Description="Suuuuuuuiiii"
                },



            };
            this.DataContext = this;
            InitializeComponent();
        }

        

        private void MenuItem_Click4(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenuItem_Click2(object sender, RoutedEventArgs e)
        {
            this.Resources["ButtonFS"] = 150.0;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["ButtonFS"] = 50.0;
        }

        private void MenuItem_Click1(object sender, RoutedEventArgs e)
        {
            this.Resources["ButtonFS"] = 250.0;
        }

        private void MenuItem_Click3(object sender, RoutedEventArgs e)
        {
            AboutWindow aboutWindow = new AboutWindow();
            aboutWindow.ShowDialog();
        }

        private void ListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            if (ListBox.SelectedItem is Images item)
            {
                SecondPage secondPage = new SecondPage();
                secondPage.image = item;
                secondPage.index = ListBox.SelectedIndex;
                secondPage.copyImage = Imagess;
                secondPage.nametextblock.Text = item.Name;
                secondPage.MainImage.Source = new BitmapImage(new Uri(item.ImagePath, UriKind.RelativeOrAbsolute));
                secondPage.Pricetextblock.Text = item.Price;
                secondPage.NationalityBlok.Text = item.Nationality;
                secondPage.DateTextblock.Text = item.Date.ToString();
                secondPage.DescriptiontextBlok.Text = item.Description;
                secondPage.ShowDialog();

            }


           
        }
    }
}
