using System;
using System.Collections.Generic;
using FoodDeliveryTemplate.ViewModels;

namespace FoodDeliveryTemplate.Views
{
    public partial class PlacesPage : ContentPage
    {
        PlacesViewModel viewModel;

        public PlacesPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new PlacesViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            viewModel.OnAppearing();
        }

    }
}
