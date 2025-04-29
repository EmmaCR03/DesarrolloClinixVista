using FoodDeliveryTemplate.ViewModels;

namespace FoodDeliveryTemplate.Views
{
    public partial class CheckoutAddressPage : ContentPage
    {
        CheckoutAddressViewModel viewModel;

        public CheckoutAddressPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new CheckoutAddressViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            viewModel.OnAppearing();
        }

    }
}
