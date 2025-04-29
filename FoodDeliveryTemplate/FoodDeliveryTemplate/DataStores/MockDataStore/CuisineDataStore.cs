using System;
using System.Collections.Generic;
using FoodDeliveryTemplate.Models;

namespace FoodDeliveryTemplate.DataStores.MockDataStore
{
    public class CuisineDataStore : BaseDataStore<Cuisine>, ICuisineDataStore
    {
        protected override IList<Cuisine> items { get; }

        public CuisineDataStore()
        {
            items = new List<Cuisine>()
            {
                new Cuisine { Id = "cu001", Name = "Bakery", Image = "cuisine_bakery" },

                new Cuisine { Id = "cu002", Name = "Burger", Image = "cuisine_burger" },

                new Cuisine { Id = "cu003", Name = "Chicken", Image = "cuisine_chicken" },

                new Cuisine { Id = "cu004", Name = "Dessert", Image = "cuisine_dessert" },

                new Cuisine { Id = "cu005", Name = "Meat", Image = "cuisine_meat" },

                new Cuisine { Id = "cu006", Name = "Pasta & Salad", Image = "cuisine_pasta" },
            };
        }        
    }
}
