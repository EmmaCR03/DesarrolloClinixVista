using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using FoodDeliveryTemplate.Models;
using FoodDeliveryTemplate.Services;
using FoodDeliveryTemplate.Views;

namespace FoodDeliveryTemplate.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        IService service = DependencyService.Get<IService>();

        public ObservableCollection<PlaceViewModel> FeaturedPlaces { get; }
        public ObservableCollection<CuisineViewModel> Cuisines { get; }
        public ObservableCollection<PlaceViewModel> RecentPlaces { get; }
        public ObservableCollection<PlaceViewModel> PopularPlaces { get; }
        public ObservableCollection<PlaceViewModel> FavoritePlaces { get; }

        public Command SeeAllRecentCommand { get; }
        public Command SeeAllPopularCommand { get; }
        public Command SeeAllFavoriteCommand { get; }

        public HomeViewModel()
        {
            FeaturedPlaces = new ObservableCollection<PlaceViewModel>();
            Cuisines = new ObservableCollection<CuisineViewModel>();
            RecentPlaces = new ObservableCollection<PlaceViewModel>();
            PopularPlaces = new ObservableCollection<PlaceViewModel>();
            FavoritePlaces = new ObservableCollection<PlaceViewModel>();

            SeeAllRecentCommand = new Command(async () =>
                await Shell.Current.GoToAsync($"{nameof(PlacesPage)}" +
                                              $"?{nameof(PlacesViewModel.OnlyRecent)}=True" +
                                              $"&{nameof(PlacesViewModel.Title)}=Recent"));

            SeeAllPopularCommand = new Command(async () =>
                await Shell.Current.GoToAsync($"{nameof(PlacesPage)}" +
                                              $"?{nameof(PlacesViewModel.OnlyPopular)}=True" +
                                              $"&{nameof(PlacesViewModel.Title)}=Popular"));

            SeeAllFavoriteCommand = new Command(async () =>
                await Shell.Current.GoToAsync($"{nameof(PlacesPage)}" +
                                              $"?{nameof(PlacesViewModel.OnlyFavorite)}=True" +
                                              $"&{nameof(PlacesViewModel.Title)}=Popular"));

        }

        async Task LoadPage()
        {
            FeaturedPlaces.Clear();
            var featuredPlaces = await service.GetPlacesAsync(onlyFeatured: true);
            foreach (var item in featuredPlaces)
                FeaturedPlaces.Add(new PlaceViewModel(item));

            Cuisines.Clear();
            var cuisines = await service.GetCuisinesAsync(null);
            foreach (var item in cuisines)
                Cuisines.Add(new CuisineViewModel(item));

            RecentPlaces.Clear();
            var recentPlaces = await service.GetPlacesAsync(onlyNew: true);
            foreach (var item in recentPlaces)
                RecentPlaces.Add(new PlaceViewModel(item));

            PopularPlaces.Clear();
            var popularPlaces = await service.GetPlacesAsync(onlyPopular: true);
            foreach (var item in popularPlaces)
                PopularPlaces.Add(new PlaceViewModel(item));

            FavoritePlaces.Clear();
            var favoritePlaces = await service.GetPlacesAsync(onlyFavorite: true);
            foreach (var item in favoritePlaces)
                FavoritePlaces.Add(new PlaceViewModel(item));
        }

        public async void OnAppearing()
        {
            await LoadPage();
        }

    }
}
