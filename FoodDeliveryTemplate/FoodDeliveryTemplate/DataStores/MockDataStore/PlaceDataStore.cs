using System.Collections.Generic;
using FoodDeliveryTemplate.Helpers;
using FoodDeliveryTemplate.Models;
using MenuItem = FoodDeliveryTemplate.Models.MenuItem;

namespace FoodDeliveryTemplate.DataStores.MockDataStore
{
    public class PlaceDataStore : BaseDataStore<Place>, IPlaceDataStore
    {
        protected override IList<Place> items { get; }

        public PlaceDataStore()
        {
            items = new List<Place>()
            {
                new Place {
                    Id = "pl001", Name = "Barbara Bakery", Image = "place_bakery1",
                    Description = "Croissant · Cake",
                    IsFeatured = true, IsNew = false, IsPopular = false,
                    DeliveryTime = "25", DeliveryPrice = 8f, District = "Donec",
                    CuisineIds = new string[] { "cu001" },

                    MenuCategories = new List<MenuCategory>
                    {
                        new MenuCategory("Croissant", new List<MenuItem>
                            { MenuHelper.NewCroissantPlain(4f), MenuHelper.NewCroissantAlmond(5f), MenuHelper.NewCroissantRocher(7f) }),

                        new MenuCategory("Cakes", new List<MenuItem>
                            { MenuHelper.NewDessertSaltedCaramelBrownie(3f), MenuHelper.NewDessertGingerCarrotCake(3f) }),

                        new MenuCategory("Coffee", new List<MenuItem>
                            { MenuHelper.NewCafeeLatte(1f), MenuHelper.NewCafeeCappucino(2f) })
                    }
                },

                new Place {
                    Id = "pl002", Name = "Celarent Patisserie", Image = "place_bakery2",
                    Description = "Croissant · Eclair",
                    IsFeatured = false, IsNew = true, IsPopular = false,
                    DeliveryTime = "20", DeliveryPrice = 10f, District = "Phasellus",
                    CuisineIds = new string[] { "cu001" },

                    MenuCategories = new List<MenuCategory>
                    {
                        new MenuCategory("Croissant Sandwich", new List<MenuItem>
                            { MenuHelper.NewCroissantSandwich(6f), MenuHelper.NewCroissantAvocadoSandwich(6f), MenuHelper.NewCroissantEntrecoteSandwich(6f) }),

                        new MenuCategory("Eclair", new List<MenuItem>
                            { MenuHelper.NewEclairClassic(3f), MenuHelper.NewEclairSnickers(3f), MenuHelper.NewCroissantRocher(3f) }),

                        new MenuCategory("Coffee", new List<MenuItem>
                            { MenuHelper.NewCafeeAmericano(2f), MenuHelper.NewCafeeIceAmericano(2f), MenuHelper.NewCafeeLatte(2f), MenuHelper.NewCafeeCappucino(2f) })
                    }
                },

                new Place {
                    Id = "pl003", Name = "Darii Bakery & Dessert", Image = "place_bakery3",
                    Description = "Dessert · Eclair",
                    IsFeatured = false, IsNew = false, IsPopular = true,
                    DeliveryTime = "35", DeliveryPrice = 12f, District = "Fusce",
                    CuisineIds = new string[] { "cu001", "cu004" },

                    MenuCategories = new List<MenuCategory>
                    {
                        new MenuCategory("Dessert", new List<MenuItem>
                            { MenuHelper.NewDessertSupangle(2f), MenuHelper.NewDessertProfiterole(3f), MenuHelper.NewDessertLemonTart(2f) }),

                        new MenuCategory("Eclair", new List<MenuItem>
                            { MenuHelper.NewEclairClassic(4f), MenuHelper.NewEclairSnickers(4f), MenuHelper.NewEclairRocher(5f) }),

                        new MenuCategory("Coffee", new List<MenuItem>
                            { MenuHelper.NewCafeeAmericano(1f), MenuHelper.NewCafeeIceAmericano(1f) })
                    }
                },

                new Place {
                    Id = "pl004", Name = "Ferio Burger", Image = "place_burger1",
                    Description = "Burger · Chicken",
                    IsFeatured = true, IsNew = false, IsPopular = false,
                    DeliveryTime = "20", DeliveryPrice = 6f, District = "Pulvinar",
                    CuisineIds = new string[] { "cu002" },

                    MenuCategories = new List<MenuCategory>
                    {
                        new MenuCategory("Menu", new List<MenuItem>
                            { MenuHelper.NewBurgerClassicMenu(9f), MenuHelper.NewBurgerClassicDoubleMenu(14f), MenuHelper.NewBurgerChickenMenu(6f), MenuHelper.NewBurgerDoubleChickenMenu(10f) }),

                        new MenuCategory("Burger", new List<MenuItem>
                            { MenuHelper.NewBurgerClassic(5f), MenuHelper.NewBurgerClassicDouble(7f), MenuHelper.NewBurgerChicken(3f), MenuHelper.NewBurgerDoubleChicken(5f) }),

                        new MenuCategory("Beverage", new List<MenuItem>
                            { MenuHelper.NewCola33(2f), MenuHelper.NewSprite33(2f), MenuHelper.NewFanta33(2f) })
                    }

                },

                new Place {
                    Id = "pl005", Name = "Camestres Burger", Image = "place_burger2",
                    Description = "Burger · Salad",
                    IsFeatured = false, IsNew = true, IsPopular = false,
                    DeliveryTime = "45", DeliveryPrice = 15f, District = "Aliquam",
                    CuisineIds = new string[] { "cu002" },

                    MenuCategories = new List<MenuCategory>
                    {
                        new MenuCategory("Burger", new List<MenuItem>
                            { MenuHelper.NewBurgerClassic(7f), MenuHelper.NewBurgerClassicDouble(14f), MenuHelper.NewBurgerChicken(6f), MenuHelper.NewBurgerDoubleChicken(11f) }),

                        new MenuCategory("Salad", new List<MenuItem>
                            { MenuHelper.NewSaladCaesar(5f), MenuHelper.NewSaladMexican(5f), MenuHelper.NewSaladThai(6f), MenuHelper.NewSaladTuna(6f) }),
                            
                        new MenuCategory("Beverage", new List<MenuItem>
                            { MenuHelper.NewCola33(1f), MenuHelper.NewSprite33(1f), MenuHelper.NewFanta33(1f) })
                    }
                },

                new Place {
                    Id = "pl006", Name = "Baroco Burger & Sandwiches", Image = "place_burger3",
                    Description ="Burger · Dessert",
                    IsFeatured = false, IsNew = false, IsPopular = true,
                    DeliveryTime = "40", DeliveryPrice = 10f, District = "Volutpat",
                    CuisineIds = new string[] { "cu002", "cu007" },

                    MenuCategories = new List<MenuCategory>
                    {
                        new MenuCategory("Menu", new List<MenuItem>
                            { MenuHelper.NewBurgerClassicMenu(10f), MenuHelper.NewBurgerClassicDoubleMenu(15f), MenuHelper.NewBurgerChickenMenu(8f), MenuHelper.NewBurgerDoubleChickenMenu(14f) }),

                        new MenuCategory("Dessert", new List<MenuItem>
                            { MenuHelper.NewDessertMosaicCake(3f), MenuHelper.NewDessertDevilsCake(3f), MenuHelper.NewDessertCheeseCake(3f), MenuHelper.NewDessertMonoCake(4f) }),

                        new MenuCategory("Beverage", new List<MenuItem>
                            { MenuHelper.NewCola33(3f), MenuHelper.NewSprite33(3f), MenuHelper.NewFanta33(3f) })
                    }
                },

                new Place {
                    Id = "pl007", Name = "Cesare Chicken", Image = "place_chicken1",
                    Description = "Chicken · Salad",
                    IsFeatured = true, IsNew = false, IsPopular = false,
                    DeliveryTime = "30", DeliveryPrice = 12f, District = "Sagittis",
                    CuisineIds = new string[] { "cu003" },

                    MenuCategories = new List<MenuCategory>
                    {
                        new MenuCategory("Chicken", new List<MenuItem>
                            { MenuHelper.NewChickenAliNazik(12f), MenuHelper.NewChickenSteak(11f), MenuHelper.NewChickenCurrySauce(10f), MenuHelper.NewChickenFajitas(13f) }),

                        new MenuCategory("Salad", new List<MenuItem>
                            { MenuHelper.NewSaladCaesar(5f), MenuHelper.NewSaladMexican(6f) }),

                        new MenuCategory("Bevereage", new List<MenuItem>
                            { MenuHelper.NewFruko33(2f), MenuHelper.NewCappy33(2f), MenuHelper.NewSevenup33(2f) })
                    }
                },

                new Place {
                    Id = "pl008", Name = "Festino Chicken", Image = "place_chicken2",
                    Description = "Chicken · Salad",
                    IsFeatured = false, IsNew = true, IsPopular = false,
                    DeliveryTime = "35", DeliveryPrice = 15f, District = "Mollis",
                    CuisineIds = new string[] { "cu003" },

                    MenuCategories = new List<MenuCategory>
                    {
                        new MenuCategory("Chicken", new List<MenuItem>
                            { MenuHelper.NewChickenSteak(7f), MenuHelper.NewChickenCurrySauce(7f), MenuHelper.NewChickenAliNazik(7f) }),

                        new MenuCategory("Chicken Burger", new List<MenuItem>
                            { MenuHelper.NewBurgerChicken(9f), MenuHelper.NewBurgerDoubleChicken(13f), MenuHelper.NewBurgerChickenMenu(8f), MenuHelper.NewBurgerDoubleChickenMenu(12f) }),

                        new MenuCategory("Salad", new List<MenuItem>
                            { MenuHelper.NewSaladMexican(4f), MenuHelper.NewSaladTuna(4f), MenuHelper.NewSaladCaesar(4f) }),

                        new MenuCategory("Beverage", new List<MenuItem>
                            { MenuHelper.NewSprite33(1f), MenuHelper.NewFruko33(1f), MenuHelper.NewSevenup33(1f) })
                    }
                },

                new Place {
                    Id = "pl009", Name = "Darapti Chicken & Meat", Image = "place_chicken3",
                    Description = "Chicken · Meat · Dessert",
                    IsFeatured = false, IsNew = false, IsPopular = true,
                    DeliveryTime = "35", DeliveryPrice = 9f, District = "Fermentum",
                    CuisineIds = new string[] { "cu003", "cu008" },

                    MenuCategories = new List<MenuCategory>
                    {
                        new MenuCategory("Chicken", new List<MenuItem>
                            { MenuHelper.NewChickenSteak(10f), MenuHelper.NewChickenCurrySauce(10f), MenuHelper.NewChickenFajitas(12f) }),

                        new MenuCategory("Meat", new List<MenuItem>
                            { MenuHelper.NewMeatTenderloin(15f), MenuHelper.NewMeatTenderloinMushroom(17f), MenuHelper.NewMeatGrilledMeatBall(18f) }),

                        new MenuCategory("Dessert", new List<MenuItem>
                            { MenuHelper.NewDessertSupangle(4f), MenuHelper.NewDessertProfiterole(4f), MenuHelper.NewDessertMosaicCake(4f), MenuHelper.NewDessertMonoCake(4f) }),

                        new MenuCategory("Beverage", new List<MenuItem>
                            { MenuHelper.NewCola33(2f), MenuHelper.NewFanta33(2f), MenuHelper.NewCappy33(2f) })
                    }
                },

                new Place {
                    Id = "pl010", Name = "Datisi Dessert", Image = "place_dessert1",
                    Description = "Dessert · Eclair",
                    IsFeatured = true, IsNew = false, IsPopular = false,
                    DeliveryTime = "30", DeliveryPrice = 10f, District = "Volutpat",
                    CuisineIds = new string[] { "cu004" },

                    MenuCategories = new List<MenuCategory>
                    {
                        new MenuCategory("Dessert", new List<MenuItem>
                            { MenuHelper.NewEclairClassic(3f), MenuHelper.NewDessertCheeseCake(3f), MenuHelper.NewDessertDevilsCake(4f), MenuHelper.NewDessertMonoCake(4f), MenuHelper.NewDessertProfiterole(3f) }),

                        new MenuCategory("Beverage", new List<MenuItem>
                            { MenuHelper.NewCappy33(3f), MenuHelper.NewFruko33(3f), MenuHelper.NewSprite33(3f) })
                    }
                },

                new Place {
                    Id = "pl011", Name = "Felapton Dessert", Image = "place_dessert2",
                    Description = "Dessert · Croissant",
                    IsFeatured = false, IsNew = true, IsPopular = false,
                    DeliveryTime = "15", DeliveryPrice = 5f, District = "Sagittis",
                    CuisineIds = new string[] { "cu004" },

                    MenuCategories = new List<MenuCategory>
                    {
                        new MenuCategory("Dessert", new List<MenuItem>
                            { MenuHelper.NewEclairRocher(4f), MenuHelper.NewEclairSnickers(3f), MenuHelper.NewDessertLemonTart(3f), MenuHelper.NewDessertSupangle(4f), MenuHelper.NewDessertSaltedCaramelBrownie(4f), MenuHelper.NewDessertCheeseCake(3f) }),

                        new MenuCategory("Croissant", new List<MenuItem>
                            { MenuHelper.NewCroissantAlmond(5f), MenuHelper.NewCroissantEntrecoteSandwich(6f), MenuHelper.NewCroissantAvocadoSandwich(6f) }),

                        new MenuCategory("Beverage", new List<MenuItem>
                            { MenuHelper.NewCola33(2f), MenuHelper.NewSprite33(2f), MenuHelper.NewCappy33(2f), MenuHelper.NewFruko33(2f) })
                    }
                },

                new Place {
                    Id = "pl012", Name = "Ferison Dessert", Image = "place_dessert3",
                    Description = "Dessert · Croissant",
                    IsFeatured = false, IsNew = false, IsPopular = true,
                    DeliveryTime = "25", DeliveryPrice = 9f, District = "Phasellus",
                    CuisineIds = new string[] { "cu004" },

                    MenuCategories = new List<MenuCategory>
                    {
                        new MenuCategory("Dessert", new List<MenuItem>
                            { MenuHelper.NewEclairClassic(4f), MenuHelper.NewEclairSnickers(4f), MenuHelper.NewDessertLemonTart(4f), MenuHelper.NewDessertGingerCarrotCake(4f), MenuHelper.NewDessertMosaicCake(4f) }),

                        new MenuCategory("Croissant", new List<MenuItem>
                            { MenuHelper.NewCroissantEntrecoteSandwich(2f), MenuHelper.NewCroissantAlmond(2f), MenuHelper.NewCroissantRocher(3f), MenuHelper.NewCroissantSandwich(3f) })
                    }
                },

                new Place {
                    Id = "pl013", Name = "Etiam", Image = "place_meatballs1",
                    Description = "Meat · Pasta · Dessert",
                    IsFeatured = true, IsNew = false, IsPopular = false,
                    DeliveryTime = "30", DeliveryPrice = 12f, District = "Aliquam",
                    CuisineIds = new string[] { "cu005" },

                    MenuCategories = new List<MenuCategory>
                    {
                        new MenuCategory("Meat", new List<MenuItem>
                            { MenuHelper.NewMeatGrilledMeatBall(10f), MenuHelper.NewMeatTenderloin(10f), MenuHelper.NewMeatTenderloinMushroom(11f) }),

                        new MenuCategory("Pasta", new List<MenuItem>
                            { MenuHelper.NewPastaAlfredo(8f), MenuHelper.NewPastaNapoliten(9f), MenuHelper.NewPastaSpaghettiBolognese(9f) }),

                        new MenuCategory("Beverage", new List<MenuItem>
                            { MenuHelper.NewFruko33(3f), MenuHelper.NewCola33(3f), MenuHelper.NewSprite33(3f) }),

                        new MenuCategory("Dessert", new List<MenuItem>
                            { MenuHelper.NewDessertCheeseCake(4f), MenuHelper.NewDessertProfiterole(5f), MenuHelper.NewDessertSupangle(5f) })
                    }
                },

                new Place {
                    Id = "pl014", Name = "Vivamus Meat & Chicken", Image = "place_meatballs2",
                    Description = "Meat · Chicken",
                    IsFeatured = false, IsNew = true, IsPopular = false,
                    DeliveryTime = "30", DeliveryPrice = 10f, District = "Donec",
                    CuisineIds = new string[] { "cu005", "cu003" },

                    MenuCategories = new List<MenuCategory>
                    {
                        new MenuCategory("Meat", new List<MenuItem>
                            { MenuHelper.NewMeatGrilledMeatBall(9f), MenuHelper.NewMeatTenderloin(12f), MenuHelper.NewMeatTenderloinMushroom(13f) }),

                        new MenuCategory("Chicken", new List<MenuItem>
                            { MenuHelper.NewChickenFajitas(11f), MenuHelper.NewChickenSteak(12f), MenuHelper.NewChickenCurrySauce(11f) }),

                        new MenuCategory("Beverage", new List<MenuItem>
                            { MenuHelper.NewFruko33(2f), MenuHelper.NewSprite33(2f), MenuHelper.NewCola33(2f) })
                    }
                },

                new Place {
                    Id = "pl015", Name = "Magnis Meat & Burger", Image = "place_meatballs3",
                    Description = "Meat · Burger · Salad · Dessert",
                    IsFeatured = false, IsNew = false, IsPopular = true,
                    DeliveryTime = "25", DeliveryPrice = 8f, District = "Pulvinar",
                    CuisineIds = new string[] { "cu005", "cu002" },

                    MenuCategories = new List<MenuCategory>
                    {
                        new MenuCategory("Meat", new List<MenuItem>
                            { MenuHelper.NewMeatGrilledMeatBall(13f), MenuHelper.NewMeatTenderloin(15f) }),

                        new MenuCategory("Burger", new List<MenuItem>
                            { MenuHelper.NewBurgerClassic(9f), MenuHelper.NewBurgerClassicDouble(16f), MenuHelper.NewBurgerClassicMenu(14f), MenuHelper.NewBurgerClassicDoubleMenu(20f) }),

                        new MenuCategory("Salad", new List<MenuItem>
                            { MenuHelper.NewSaladThai(5f), MenuHelper.NewSaladCaesar(6f), MenuHelper.NewSaladTuna(6f) }),

                        new MenuCategory("Dessert", new List<MenuItem>
                            { MenuHelper.NewDessertCheeseCake(4f), MenuHelper.NewDessertDevilsCake(5f), MenuHelper.NewDessertMosaicCake(4f), MenuHelper.NewDessertProfiterole(5f) }),

                        new MenuCategory("Beverage", new List<MenuItem>
                            { MenuHelper.NewFruko33(2f), MenuHelper.NewCola33(2f), MenuHelper.NewSevenup33(2f), MenuHelper.NewSprite33(2f) })
                    }
                },

                new Place {
                    Id = "pl016", Name = "Dimaris Salad", Image = "place_pasta1",
                    Description = "Salad · Pasta",
                    IsFeatured = true, IsNew = false, IsPopular = false,
                    DeliveryTime = "30", DeliveryPrice = 10f, District = "Volutpat",
                    CuisineIds = new string[] { "cu006" },

                    MenuCategories = new List<MenuCategory>
                    {
                        new MenuCategory("Salad", new List<MenuItem>
                            { MenuHelper.NewSaladCaesar(3f), MenuHelper.NewSaladMexican(3f), MenuHelper.NewSaladThai(3f), MenuHelper.NewSaladTuna(3f) }),

                        new MenuCategory("Pasta", new List<MenuItem>
                            { MenuHelper.NewPastaAlfredo(4f), MenuHelper.NewPastaNapoliten(4f), MenuHelper.NewPastaSpaghettiBolognese(4f) }),

                        new MenuCategory("Beverage", new List<MenuItem>
                            { MenuHelper.NewCappy33(2f), MenuHelper.NewCola33(2f), MenuHelper.NewFanta33(2f) })
                    }
                },

                new Place {
                    Id = "pl017", Name = "Fusce Pasta & Salad", Image = "place_pasta2",
                    Description = "Pasta · Salad",
                    IsFeatured = false, IsNew = true, IsPopular = false,
                    DeliveryTime = "35", DeliveryPrice = 12f, District = "Phasellus",
                    CuisineIds = new string[] { "cu006" },

                    MenuCategories = new List<MenuCategory>
                    {
                        new MenuCategory("Pasta", new List<MenuItem>
                            { MenuHelper.NewPastaAlfredo(5f), MenuHelper.NewPastaNoodleChicken(5f), MenuHelper.NewPastaNapoliten(5f), MenuHelper.NewPastaSpaghettiBolognese(5f) }),

                        new MenuCategory("Salad", new List<MenuItem>
                            { MenuHelper.NewSaladCaesar(3f), MenuHelper.NewSaladMexican(3f), MenuHelper.NewSaladThai(3f), MenuHelper.NewSaladTuna(3f) }),

                        new MenuCategory("Beverage", new List<MenuItem>
                            { MenuHelper.NewCappy33(2f), MenuHelper.NewCola33(2f), MenuHelper.NewFanta33(2f) })
                    }
                },

                new Place {
                    Id = "pl018", Name = "Aliquam Pasta", Image = "place_pasta3",
                    Description = "Pasta · Salad",
                    IsFeatured = false, IsNew = false, IsPopular = true,
                    DeliveryTime = "20", DeliveryPrice = 10f, District = "Sagittis",
                    CuisineIds = new string[] { "cu006" },

                    MenuCategories = new List<MenuCategory>
                    {
                        new MenuCategory("Pasta", new List<MenuItem>
                            { MenuHelper.NewPastaAlfredo(5f), MenuHelper.NewPastaNoodleChicken(4f), MenuHelper.NewPastaNapoliten(5f), MenuHelper.NewPastaSpaghettiBolognese(6f) }),

                        new MenuCategory("Salad", new List<MenuItem>
                            { MenuHelper.NewSaladCaesar(5f), MenuHelper.NewSaladMexican(5f), MenuHelper.NewSaladThai(5f), MenuHelper.NewSaladTuna(5f) }),

                        new MenuCategory("Beverage", new List<MenuItem>
                            { MenuHelper.NewCappy33(1f), MenuHelper.NewCola33(1f), MenuHelper.NewFanta33(1f) })
                    }
                },

            };
        }

    }
}
