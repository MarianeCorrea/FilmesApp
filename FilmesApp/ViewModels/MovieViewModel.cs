using System.ComponentModel;
using System.Windows.Input;
using FilmesApp.Models;

namespace FilmesApp.ViewModels
{

    public class MovieViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string searchTitle;
        public string SearchTitle
        {
            get => searchTitle;
            set
            {
                searchTitle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SearchTitle)));
            }
        }

        private Movie movie;
        public Movie Movie
        {
            get => movie;
            set
            {
                movie = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Movie)));
            }
        }

        public ICommand SearchMovieCommand { get; }

        private readonly MovieService movieService;

        public MovieViewModel()
        {
            movieService = new MovieService();
            SearchMovieCommand = new Command(async () => await SearchMovie());
        }

        private async Task SearchMovie()
        {
            Movie = await movieService.GetMovieAsync(SearchTitle);
        }
    }
}

