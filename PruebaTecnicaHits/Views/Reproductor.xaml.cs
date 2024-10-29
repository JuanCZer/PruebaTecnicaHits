using PruebaTecnicaHits.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Core;
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
    public sealed partial class Reproductor : Page
    {
        private Pelicula _pelicula;
        public Reproductor()
        {
            this.InitializeComponent();
            
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            if (e.Parameter is Pelicula pelicula)
            {
                _pelicula = pelicula;
                videoMediaPlayer.Source = new Uri("https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/ForBiggerEscapes.mp4");
                videoMediaPlayer.Play();
            }
        }

        private void VideoMediaPlayer_MediaEnded(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(DetailMovie), _pelicula);

        }
        private void Regresar_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(DetailMovie), _pelicula);
        }
    }
}
