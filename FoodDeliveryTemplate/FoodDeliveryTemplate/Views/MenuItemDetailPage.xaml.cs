using System;
using System.Collections.Generic;
using FoodDeliveryTemplate.ViewModels;

namespace FoodDeliveryTemplate.Views
{
    public partial class MenuItemDetailPage : ContentPage
    {

        public MenuItemDetailPage(Models.MenuItem menuItem, string placeName)
        {
            InitializeComponent();

            BindingContext = new MenuItemDetailViewModel(menuItem, placeName);
        }
    }
}
