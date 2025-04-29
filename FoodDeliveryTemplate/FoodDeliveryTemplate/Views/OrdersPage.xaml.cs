using FoodDeliveryTemplate.ViewModels;

namespace FoodDeliveryTemplate.Views
{
    public partial class OrdersPage : ContentPage
    {
        OrdersViewModel viewModel;

        public OrdersPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new OrdersViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            viewModel.OnAppearing();
        }

    }
}
