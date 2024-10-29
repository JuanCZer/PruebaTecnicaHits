using PruebaTecnicaHits.Models;
using PruebaTecnicaHits.Rest;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaHits.ViewModel
{
    public class DetailMovieVM : ViewModelBase
    {
        public ObservableCollection<Pelicula> PeliculasSecD { get; set; }

        public DetailMovieVM()
        {
            PeliculasSecD = new ObservableCollection<Pelicula>();
        }

        public async Task DisplayPeliculasSectionD()
        {
            try
            {
                RestServices apiService = new RestServices();
                List<Pelicula> peliculas = await apiService.GetPeliculasSectionDAsync();

                PeliculasSecD.Clear();
                foreach (Pelicula pelicula in peliculas)
                {
                    PeliculasSecD.Add(pelicula);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar peliculas: " + ex.Message);
            }
        }

        private Pelicula selectedPelicula;
        public Pelicula SelectedPelicula
        {
            get { return selectedPelicula; }
            set
            {
                selectedPelicula = value;
                OnPropertyChanged();
            }
        }

        private Pelicula pelicula;
        public Pelicula Pelicula
        {
            get { return pelicula; }
            set
            {
                pelicula = value;
                OnPropertyChanged(nameof(Pelicula));
            }
        }

        private int id;
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        private string title;
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                OnPropertyChanged(nameof(Title));
            }
        }

        private string description_large;
        public string DescriptionLarge
        {
            get { return description_large; }
            set
            {
                description_large = value;
                OnPropertyChanged(nameof(DescriptionLarge));
            }
        }

        private string image_small;
        public string ImageSmall
        {
            get { return image_small; }
            set
            {
                image_small = value;
                OnPropertyChanged(nameof(ImageSmall));
            }
        }

        private string image_medium;
        public string ImageMedium
        {
            get { return image_medium; }
            set
            {
                image_medium = value;
                OnPropertyChanged(nameof(ImageMedium));
            }
        }

        private string image_large;
        public string ImageLarge
        {
            get { return image_large; }
            set
            {
                image_large = value;
                OnPropertyChanged(nameof(ImageLarge));
            }
        }

        private string duration;
        public string Duration
        {
            get { return duration; }
            set
            {
                duration = value;
                OnPropertyChanged(nameof(Duration));
            }
        }

        private string date;
        public string Date
        {
            get { return date; }
            set
            {
                date = value;
                OnPropertyChanged(nameof(Date));
            }
        }
    }
}
