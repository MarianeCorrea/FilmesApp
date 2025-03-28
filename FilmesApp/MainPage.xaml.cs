using FilmesApp.ViewModels;

namespace FilmesApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnDetailsClicked(object sender, EventArgs e)
        {
            var vm = BindingContext as MovieViewModel;
            var movie = vm.Movie;

            await DisplayAlert(movie.Title, $"Diretor: {movie.Director}\nAtores: {movie.Actors}\nSinopse: {movie.Plot}", "OK");
        }
    }

}
