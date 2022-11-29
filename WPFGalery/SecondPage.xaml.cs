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
using System.Windows.Threading;

namespace WPFGalery
{
    /// <summary>
    /// Interaction logic for SecondPage.xaml
    /// </summary>
    public partial class SecondPage : Window
    {

        public Images image { get; set; }
        public int index;

        public List<Images> copyImage { get; set; }
       

        public SecondPage()
        {
            this.DataContext = this;
            InitializeComponent();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            this.Resources["ButtonFS"] = 100.0;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["ButtonFS"] = 100.0;
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            this.Resources["ButtonFS"] = 350.0;
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            AboutWindow aboutWindow = new AboutWindow();
            aboutWindow.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void PrevBtn_Click(object sender, RoutedEventArgs e)
        {
            if (index > 0)
            {
                image = copyImage[index - 1];
                index -= 1;
                MainImage.Source = new BitmapImage(new Uri(image.ImagePath, UriKind.RelativeOrAbsolute));
                nametextblock.Text = copyImage[index].Name;
                Pricetextblock.Text = copyImage[index].Price;
                NationalityBlok.Text = copyImage[index].Nationality;
                DateTextblock.Text = copyImage[index].Date.ToString();
                DescriptiontextBlok.Text = copyImage[index].Description;
            }
            else
            {
                MessageBox.Show("Image is Not Found");
            }
        }

        private void nextBtn_Click(object sender, RoutedEventArgs e)
        {
            if(index < copyImage.Count - 1)
            {

                image = copyImage[index + 1];
                index += 1;
                MainImage.Source = new BitmapImage(new Uri(image.ImagePath, UriKind.RelativeOrAbsolute));
                nametextblock.Text = copyImage[index].Name;
                Pricetextblock.Text = copyImage[index].Price;
                NationalityBlok.Text = copyImage[index].Nationality;
                DateTextblock.Text = copyImage[index].Date.ToString();
                DescriptiontextBlok.Text = copyImage[index].Description;
            }
            else
            {
                MessageBox.Show("Next Image is Not Found");
            }
        }

        private void PauseBtn_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }

        DispatcherTimer timer = new DispatcherTimer();
        public void autoplay()
        {
            timer.Start();

            try
            {
                timer.Interval = new TimeSpan(0, 0, 0, 3);

                MainImage.Source = new BitmapImage(new Uri(copyImage[index].ImagePath, UriKind.RelativeOrAbsolute));
                nametextblock.Text = copyImage[index].Name;
                Pricetextblock.Text = copyImage[index].Price;
                NationalityBlok.Text = copyImage[index].Nationality;
                DateTextblock.Text = copyImage[index].Date.ToString();
                DescriptiontextBlok.Text = copyImage[index].Description;

                index++;



            }
            catch (Exception)
            {
                index = 0;
                autoplay();
            }

        }

        private void t_tick(object sender, EventArgs e)
        {
            autoplay();
        }

        private void autoplayCeBtn_Click(object sender, RoutedEventArgs e)
        {
            autoplay();

            timer.Tick += new EventHandler(t_tick);
        }

        
    }
}
