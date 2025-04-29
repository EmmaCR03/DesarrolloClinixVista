using System;

namespace FoodDeliveryTemplate.Views
{
    public partial class CheckoutCompletedPage : ContentPage
    {
        public CheckoutCompletedPage()
        {
            InitializeComponent();
        }

        async void OnContinueTapped(object sender, EventArgs args)
        {
            await Shell.Current.GoToAsync("//tabbar/cart");
        }

    }
}
