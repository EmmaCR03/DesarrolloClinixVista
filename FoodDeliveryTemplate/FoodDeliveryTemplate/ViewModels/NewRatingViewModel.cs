using System;
using FoodDeliveryTemplate.Models;
using FoodDeliveryTemplate.Resources;
using FoodDeliveryTemplate.Services;

namespace FoodDeliveryTemplate.ViewModels
{
    [QueryProperty(nameof(PlaceId), nameof(PlaceId))]
    public class NewRatingViewModel : BaseViewModel
    {
        IService service => DependencyService.Get<IService>();

        public Command StarCommand { get; }
        public Command SubmitCommand { get; }

        private string placeId;
        public string PlaceId
        {
            get => placeId;
            set
            {
                placeId = value;
                LoadProduct(value);
            }
        }

        private string placeImage;
        public string PlaceImage
        {
            get => placeImage;
            set => SetProperty(ref placeImage, value);
        }

        private string placeName;
        public string PlaceName
        {
            get => placeName;
            set => SetProperty(ref placeName, value);
        }

        private string placeDescription;
        public string PlaceDescription
        {
            get => placeDescription;
            set => SetProperty(ref placeDescription, value);
        }

        private float starCount;
        public float StarCount
        {
            get => starCount;
            set => SetProperty(ref starCount, value);
        }

        private string text;
        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }

        public NewRatingViewModel()
        {
            Title = AppResources.NewRating;

            StarCommand = new Command<String>(OnStarTapped);
            SubmitCommand = new Command(OnSubmitTapped);

            StarCount = 5;
        }

        public async void LoadProduct(string id)
        {
            var item = await service.GetPlaceAsync(id);
            PlaceName = item.Name;
            PlaceImage = item.Image;
            PlaceDescription = item.Description;
        }

        private void OnStarTapped(String star)
        {
            StarCount = int.Parse(star);
        }

        private async void OnSubmitTapped()
        {
            Rating newItem = new Rating
            {
                Id = Guid.NewGuid().ToString(),
                PlaceId = PlaceId,
                CustomerId = Globals.LoggedCustomerId,
                Star = (byte)starCount,
                Text = text,
                DateGmt = DateTime.UtcNow
            };

            await service.AddRatingAsync(newItem);
            await Shell.Current.GoToAsync("..");
        }

    }
}
