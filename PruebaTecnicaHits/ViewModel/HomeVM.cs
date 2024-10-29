using PruebaTecnicaHits.Models;
using PruebaTecnicaHits.Rest;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaHits.ViewModel
{
    public class HomeVM : ViewModelBase
    {
        public ObservableCollection<Pelicula> PeliculasSecA { get; set; }
        public ObservableCollection<Pelicula> PeliculasSecB { get; set; }
        public ObservableCollection<Pelicula> PeliculasSecC { get; set; }

        public HomeVM()
        {
            PeliculasSecA = new ObservableCollection<Pelicula>();
            PeliculasSecB = new ObservableCollection<Pelicula>();
            PeliculasSecC = new ObservableCollection<Pelicula>();
        }

        public async Task DisplayPeliculasSectionA()
        {
            try
            {
                RestServices apiService = new RestServices();
                List<Pelicula> peliculas = await apiService.GetPeliculasSectionAAsync();

                PeliculasSecA.Clear();
                foreach (var pelicula in peliculas)
                {
                    PeliculasSecA.Add(pelicula);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar peliculas: " + ex.Message);
            }
        }

        public async Task DisplayPeliculasSectionB()
        {
            try
            {
                RestServices apiService = new RestServices();
                List<Pelicula> peliculas = await apiService.GetPeliculasSectionBAsync();

                PeliculasSecB.Clear();
                foreach (var pelicula in peliculas)
                {
                    PeliculasSecB.Add(pelicula);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar peliculas: " + ex.Message);
            }
        }

        public async Task DisplayPeliculasSectionC()
        {
            try
            {
                RestServices apiService = new RestServices();
                List<Pelicula> peliculas = await apiService.GetPeliculasSectionCAsync();

                PeliculasSecC.Clear();
                foreach (var pelicula in peliculas)
                {
                    PeliculasSecC.Add(pelicula);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar peliculas: " + ex.Message);
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
