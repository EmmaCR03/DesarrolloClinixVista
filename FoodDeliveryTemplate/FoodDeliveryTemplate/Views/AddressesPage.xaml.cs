using FoodDeliveryTemplate.ViewModels;

namespace FoodDeliveryTemplate.Views
{
    public partial class AddressesPage : ContentPage
    {
        AddressesViewModel viewModel;

        public AddressesPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new AddressesViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            viewModel.OnAppearing();
        }
    }
}
