using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FoodDeliveryTemplate.Models;
using FoodDeliveryTemplate.Services;
using FoodDeliveryTemplate.Views;

namespace FoodDeliveryTemplate.ViewModels
{
    [QueryProperty(nameof(PlaceId), nameof(PlaceId))]
    public class PlaceDetailViewModel : BaseViewModel
    {
        IService service => DependencyService.Get<IService>();

        public Command FavoriteCommand { get; }
        public Command ReviewCommand { get; }
        public Command<Models.MenuItem> MenuItemCommand { get; }

        private string placeId;
        public string PlaceId
        {
            get => placeId;
            set
            {
                placeId = value;
                LoadPlace(value);
            }
        }
            
        private string name;
        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        private string description;
        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }

        private string image;
        public string Image
        {
            get => image;
            set => SetProperty(ref image, value);
        }

        private float deliveryPrice;
        public float DeliveryPrice
        {
            get => deliveryPrice;
            set => SetProperty(ref deliveryPrice, value);
        }

        private string deliveryTime;
        public string DeliveryTime
        {
            get => deliveryTime;
            set => SetProperty(ref deliveryTime, value);
        }

        private string district;
        public string District
        {
            get => district;
            set => SetProperty(ref district, value);
        }

        private float averageRating;
        public float AverageRating
        {
            get => averageRating;
            set => SetProperty(ref averageRating, value);
        }

        private int reviewCount;
        public int ReviewCount
        {
            get => reviewCount;
            set => SetProperty(ref reviewCount, value);
        }

        private bool isFavorite;
        public bool IsFavorite
        {
            get => isFavorite;
            set => SetProperty(ref isFavorite, value);
        }

        private List<MenuCategory> menuCategories;
        public List<MenuCategory> MenuCategories
        {
            get => menuCategories;
            set => SetProperty(ref menuCategories, value);
        }

        public bool HasRated
        {
            get => ReviewCount > 0;
        }

        private Place place;

        public PlaceDetailViewModel()
        {
            FavoriteCommand = new Command(OnFavoriteTapped);

            ReviewCommand = new Command(async () =>
                await Shell.Current.GoToAsync($"{nameof(RatingsPage)}" +
                                              $"?{nameof(RatingsViewModel.PlaceId)}={placeId}"));

            MenuItemCommand = new Command<Models.MenuItem>(async (menuItem) =>
                await Shell.Current.Navigation.PushModalAsync(new MenuItemDetailPage(menuItem, place.Name)));
        }

        public async void LoadPlace(string id)
        {
            place = await service.GetPlaceAsync(id);
            Name = place.Name;
            Description = place.Description;
            Image = place.Image;
            DeliveryPrice = place.DeliveryPrice;
            DeliveryTime = place.DeliveryTime;
            District = place.District;
            AverageRating = place.AverageRating;
            ReviewCount = place.ReviewCount;
            IsFavorite = place.IsFavorite;
            MenuCategories = place.MenuCategories;
        }

        async void OnFavoriteTapped()
        {
            var fav = await service.GetFavoriteAsync(Globals.LoggedCustomerId, placeId);

            if (fav != null)
            {
                await service.DeleteFavoriteAsync(fav.Id);

                await Task.Delay(300);
                IsFavorite = false;
            }
            else
            {
                await service.AddFavoriteAsync(new Favorite
                {
                    Id = Guid.NewGuid().ToString(),
                    CustomerId = Globals.LoggedCustomerId,
                    PlaceId = placeId
                });

                IsFavorite = true;
            }
        }

    }
}
