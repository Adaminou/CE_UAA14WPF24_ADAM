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
using Image = System.Windows.Controls.Image;

namespace CE_UAA14WPF24_ADAM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            BitmapImage imageBouton = new BitmapImage();
            imageBouton.BeginInit();
            imageBouton.EndInit();
            Image imBouton = new Image();
            imBouton.Source = imageBouton;
            imBouton.Stretch = System.Windows.Media.Stretch.Fill;
            int compteur = 1;
            if (compteur >= 9 && compteur <= 9 (compteur >=9 && compteur <= 9))
            {
                imageBouton.UriSource = new Uri("Image/petitCercleRouge.png", UriKind.Relative);

            }
        }


        





    }
}
