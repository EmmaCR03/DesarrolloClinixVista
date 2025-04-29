using System;
using FoodDeliveryTemplate.Models;
using FoodDeliveryTemplate.Views;

namespace FoodDeliveryTemplate.ViewModels
{
    public class PlaceViewModel : BaseViewModel
    {
        public Command<PlaceViewModel> PlaceCommand { get; }

        public string Id { get; }

        public string Name { get; }

        public string Description { get; }

        public string Image { get; }

        public float DeliveryPrice { get; }

        public string DeliveryTime { get; }

        public string District { get; }

        public float AverageRating { get; }

        public int ReviewCount { get; }

        public bool IsFavorite { get; }

        public bool HasRated {
            get => ReviewCount > 0;
        }

        public PlaceViewModel(Place place)
        {
            Id = place.Id;
            Name = place.Name;
            Description = place.Description;
            Image = place.Image;
            DeliveryPrice = place.DeliveryPrice;
            DeliveryTime = place.DeliveryTime;
            District = place.District;
            AverageRating = place.AverageRating;
            ReviewCount = place.ReviewCount;
            IsFavorite = place.IsFavorite;

            PlaceCommand = new Command<PlaceViewModel>(OnPlaceSelected);
        }

        async void OnPlaceSelected(PlaceViewModel item)
        {
            if (item == null) return;

            await Shell.Current.GoToAsync($"{nameof(PlaceDetailPage)}" +
                                          $"?{nameof(PlaceDetailViewModel.PlaceId)}={item.Id}");
        }
    }
}
