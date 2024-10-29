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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace PruebaTecnicaHits.Views
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class DetailMovie : Page
    {
        private DetailMovieVM DetailMovieVM {get; set;}
        public DetailMovie()
        {
            this.InitializeComponent();
            DetailMovieVM = new DetailMovieVM();
            DataContext = DetailMovieVM;
            LoadPeliculas();
        }

        private async void LoadPeliculas()
        {
            await DetailMovieVM.DisplayPeliculasSectionD();
            PeliculaCarouselSectionD.ItemsSource = DetailMovieVM.PeliculasSecD;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            if (e.Parameter is Pelicula pelicula)
            {
                DetailMovieVM.SelectedPelicula = pelicula;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var pelicula = button?.Tag as Pelicula;
            if (pelicula != null)
            {
                Frame.Navigate(typeof(DetailMovie), pelicula);
            }
        }

        private void Reproducir_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.Tag is Pelicula pelicula)
            {
                Frame.Navigate(typeof(Reproductor), pelicula);
            }      
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            //SearchBox.Visibility = SearchBox.Visibility == Visibility.Collapsed ? Visibility.Visible : Visibility.Collapsed;
            //if (SearchBox.Visibility == Visibility.Visible)
            //{
            //    SearchBox.Focus(FocusState.Programmatic);

            //}
        }

        private void PaginaPrincipal_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Principal));
        }

        private void Inicio_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Principal));
        }
    }
}
