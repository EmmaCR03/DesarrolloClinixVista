using System;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryTemplate.Models;
using FoodDeliveryTemplate.Services;
using FoodDeliveryTemplate.ViewModels;
using FoodDeliveryTemplate.Views;

namespace FoodDeliveryTemplate.Controls
{
    /// <summary>
    /// The SearchHandler class for MAUI Shell's integrated search functionality.
    /// <see href="https://docs.microsoft.com/en-us/dotnet/maui/fundamentals/shell/search"/>
    /// </summary>
    public class PlaceSearchHandler : SearchHandler
    {
        public IService service = DependencyService.Get<IService>();
        public Type SelectedItemNavigationTarget { get; set; }

        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);

            if (string.IsNullOrWhiteSpace(newValue))
            {
                ItemsSource = null;
            }
            else
            {
                ItemsSource = service.GetPlacesAsync(key: newValue.ToLower()).Result.ToList();
            }
        }

        protected override async void OnItemSelected(object item)
        {
            base.OnItemSelected(item);

            await Task.Delay(1000);

            await Shell.Current.GoToAsync($"{nameof(PlaceDetailPage)}" +
                                          $"?{nameof(PlaceDetailViewModel.PlaceId)}={((Place)item).Id}");
        }

    }
}
