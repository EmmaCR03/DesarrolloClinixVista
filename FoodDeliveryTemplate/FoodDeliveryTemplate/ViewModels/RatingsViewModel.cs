using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using FoodDeliveryTemplate.Models;
using FoodDeliveryTemplate.Services;
using FoodDeliveryTemplate.Resources;
using FoodDeliveryTemplate.Views;

namespace FoodDeliveryTemplate.ViewModels
{
    [QueryProperty(nameof(PlaceId), nameof(PlaceId))]
    public class RatingsViewModel : BaseViewModel
    {
        IService service => DependencyService.Get<IService>();

        public ObservableCollection<Rating> Items { get; }

        public ICommand LoadItemsCommand { get; }
        public ICommand AddRatingCommand { get; }

        private string placeId;
        public string PlaceId
        {
            get => placeId;
            set => placeId = value;
        }

        public RatingsViewModel()
        {
            Title = AppResources.Ratings;
            Items = new ObservableCollection<Rating>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
            AddRatingCommand = new Command(async () => await OnAddRating());
        }

        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            Items.Clear();
            var items = await service.GetRatingsAsync(placeId);

            foreach (var item in items)
                Items.Add(item);

            IsBusy = false;
        }

        public void OnAppearing()
        {
            IsBusy = true;
        }

        async Task OnAddRating()
        {
            await Shell.Current.GoToAsync($"{nameof(NewRatingPage)}" +
                                          $"?{nameof(NewRatingViewModel.PlaceId)}={placeId}");
        }

    }
}
