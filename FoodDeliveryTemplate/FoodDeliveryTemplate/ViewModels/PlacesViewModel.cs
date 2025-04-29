using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using FoodDeliveryTemplate.DataStores;
using FoodDeliveryTemplate.Helpers;
using FoodDeliveryTemplate.Resources;
using FoodDeliveryTemplate.Services;

namespace FoodDeliveryTemplate.ViewModels
{
    [QueryProperty(nameof(SortOption), nameof(SortOption))]
    [QueryProperty(nameof(Title), nameof(Title))]
    [QueryProperty(nameof(CuisineId), nameof(CuisineId))]
    [QueryProperty(nameof(OnlyRecent), nameof(OnlyRecent))]
    [QueryProperty(nameof(OnlyPopular), nameof(OnlyPopular))]
    [QueryProperty(nameof(OnlyFavorite), nameof(OnlyFavorite))]
    public class PlacesViewModel : BaseViewModel
    {
        IService service => DependencyService.Get<IService>();

        public ObservableCollection<PlaceViewModel> Items { get; }

        public Command LoadItemsCommand { get; }
        public Command SortCommand { get; }

        private string cuisineId;
        public string CuisineId
        {
            get => cuisineId;
            set => cuisineId = value;
        }

        private bool onlyRecent;
        public bool OnlyRecent
        {
            get => onlyRecent;
            set => onlyRecent = value;
        }

        private bool onlyPopular;
        public bool OnlyPopular
        {
            get => onlyPopular;
            set => onlyPopular = value;
        }

        private bool onlyFavorite;
        public bool OnlyFavorite
        {
            get => onlyFavorite;
            set => onlyFavorite = value;
        }

        private string sortOption;
        public string SortOption
        {
            get => sortOption;
            set
            {
                sortOption = value;
                sortBy = (SortBy)Enum.Parse(typeof(SortBy), value);
            }
        }

        private SortBy sortBy;

        public PlacesViewModel()
        {
            Title = AppResources.Places;
            Items = new ObservableCollection<PlaceViewModel>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
            SortCommand = new Command(OnSortTapped);
        }

        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            Items.Clear();
            var items = await service.GetPlacesAsync(cuisineId: cuisineId,
                                                    onlyFavorite: OnlyFavorite,
                                                    onlyNew: OnlyRecent,
                                                    onlyPopular: OnlyPopular,
                                                    sortBy: sortBy);

            foreach (var item in items)
                Items.Add(new PlaceViewModel(item));

            IsBusy = false;
        }

        public void OnAppearing()
        {
            IsBusy = true;
        }

        async void OnSortTapped()
        {
            var action = await Shell.Current.DisplayActionSheet(AppResources.SortBy,
                                AppResources.Cancel, null,
                                SortBy.Unsorted.FriendlyName(),
                                SortBy.Name_AZ.FriendlyName(),
                                SortBy.Name_ZA.FriendlyName(),
                                SortBy.Highest_Rate.FriendlyName(),
                                SortBy.Rate_Count.FriendlyName());

            if (action == "Cancel") return;

            sortBy = ExtensionMethods.SortByFromFriendlyName(action);
            IsBusy = true;
        }

    }
}
