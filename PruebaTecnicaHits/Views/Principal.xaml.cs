using PruebaTecnicaHits.Models;
using PruebaTecnicaHits.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace PruebaTecnicaHits.Views
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Principal : Page
    {
        public HomeVM HomeVM { get; set; }

        public Principal()
        {
            this.InitializeComponent();
            HomeVM = new HomeVM();
            DataContext = HomeVM;
            LoadPeliculas();
        }

        private async void LoadPeliculas()
        {
            await HomeVM.DisplayPeliculasSectionA();
            //Muestra las peliculas en el componente del carrusel
            PeliculaCarouselSectionA.ItemsSource = HomeVM.PeliculasSecA;
            await HomeVM.DisplayPeliculasSectionB();
            //Muestra las peliculas en el componente del carrusel
            PeliculaCarouselSectionB.ItemsSource = HomeVM.PeliculasSecB;
            await HomeVM.DisplayPeliculasSectionC();
            //Muestra las peliculas en el componente del carrusel
            PeliculaCarouselSectionC.ItemsSource = HomeVM.PeliculasSecC;
        }

        //Cambia el Tab a Reproductor con la informacion del Objeto Pelicula que lo ejecuto
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var pelicula = button?.Tag as Pelicula;
            if (pelicula != null)
            {
                Frame.Navigate(typeof(DetailMovie), pelicula);
            }
        }

        //Cambia el Tab
        private void Inicio_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Principal));
        }
    }
}
