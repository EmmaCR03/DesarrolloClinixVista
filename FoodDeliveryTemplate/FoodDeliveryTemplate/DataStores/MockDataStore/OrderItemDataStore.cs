using System.Collections.Generic;
using FoodDeliveryTemplate.Models;

namespace FoodDeliveryTemplate.DataStores.MockDataStore
{
    /// <summary>
    /// Mock data store with fake entities to test.
    /// </summary>
    public class OrderItemDataStore : BaseDataStore<OrderItem>, IOrderItemDataStore
    {
        protected override IList<OrderItem> items { get; }

        public OrderItemDataStore()
        {
            items = new List<OrderItem>
            {
                new OrderItem
                {
                    Id = "ol001",
                    OrderId = "or001",
                    ProductName = "Chicken Fajitas",
                    PlaceName = "Darapti Chicken & Meat",
                    ProductImage = "mi_chicken_fajitas",
                    UnitPrice = 15f,
                    Quantity = 2,
                    IngredientString = "Onion",
                    ChoiceString = "Apple slice · Mushroom"
                },

                new OrderItem
                {
                    Id = "ol002",
                    OrderId = "or002",
                    ProductName = "Chicken Fajitas",
                    PlaceName = "Darapti Chicken & Meat",
                    ProductImage = "mi_chicken_fajitas",
                    UnitPrice = 15f,
                    Quantity = 1,
                    IngredientString = "Onion",
                    ChoiceString = "Apple slice · Mushroom"
                },

                new OrderItem
                {
                    Id = "ol003",
                    OrderId = "or003",
                    ProductName = "Chicken Fajitas",
                    PlaceName = "Darapti Chicken & Meat",
                    ProductImage = "mi_chicken_fajitas",
                    UnitPrice = 15f,
                    Quantity = 2,
                    IngredientString = "Onion",
                    ChoiceString = "Apple slice · Mushroom"
                },

                new OrderItem
                {
                    Id = "ol004",
                    OrderId = "or004",
                    ProductName = "Chicken Fajitas",
                    PlaceName = "Darapti Chicken & Meat",
                    ProductImage = "mi_chicken_fajitas",
                    UnitPrice = 15f,
                    Quantity = 1,
                    IngredientString = "Onion",
                    ChoiceString = "Apple slice · Mushroom"
                },

                new OrderItem
                {
                    Id = "ol005",
                    OrderId = "or005",
                    ProductName = "Chicken Fajitas",
                    PlaceName = "Darapti Chicken & Meat",
                    ProductImage = "mi_chicken_fajitas",
                    UnitPrice = 15f,
                    Quantity = 3,
                    IngredientString = "Onion",
                    ChoiceString = "Apple slice · Mushroom"
                }

            };
        }
    }
}
