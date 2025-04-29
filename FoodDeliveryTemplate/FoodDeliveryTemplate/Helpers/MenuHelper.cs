using System.Collections.Generic;
using FoodDeliveryTemplate.Models;
using MenuItem = FoodDeliveryTemplate.Models.MenuItem;

namespace FoodDeliveryTemplate.Helpers
{
    public static class MenuHelper
    {
        /*
         * croissant
         * dessert
         * eclair
         * cafee
         * burger
         * chicken
         * pasta
         * meat
         * salad
         * beverage
         */

        // croissant

        public static MenuItem NewCroissantPlain(float price)
        {
            return new MenuItem
            {
                Name = "Plain Croissant",
                Description = "Plain croissant with butter",
                Image = "mi_plain_croissant",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>()
            };
        }

        public static MenuItem NewCroissantAlmond(float price)
        {
            return new MenuItem
            {
                Name = "Double Baked Almond Croissant",
                Description = "Croissant with almond frangipane filling",
                Image = "mi_plain_croissant",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>()
            };
        }

        public static MenuItem NewCroissantRocher(float price)
        {
            return new MenuItem
            {
                Name = "Rocher Croissant",
                Description = "Rocher chocolate covered croissant",
                Image = "mi_plain_croissant",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>()
            };
        }

        // croissant sandwiches

        public static MenuItem NewCroissantSandwich(float price)
        {
            var menuItem = new MenuItem
            {
                Name = "3 Cheese Croissant Sandwich",
                Description = "Cheddar, lettuce, tomato",
                Image = "mi_cheese_croissant_sandwich",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>
               {
                    new Choice<ChoiceItem>("Ingredients", new List<ChoiceItem>
                    {
                        new IngredientItem("Tomato"),
                        new IngredientItem("Lettuce")
                    })
                }
            };

            foreach (var choice in menuItem.Choices)
                foreach (var i in choice)
                    i.choice = choice;

            return menuItem;
        }

        public static MenuItem NewCroissantAvocadoSandwich(float price)
        {
            var menuItem = new MenuItem
            {
                Name = "3 Cheese Avocado Croissant Sandwich",
                Description = "Cheddar, avacado, lettuce, tomato",
                Image = "mi_cheese_avacado_croissant_sandwich",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>
                {
                    new Choice<ChoiceItem>("Ingredients", new List<ChoiceItem>
                    {
                        new IngredientItem("Tomato"),
                        new IngredientItem("Lettuce"),
                        new IngredientItem("Black Cumin")
                    })
                }
            };

            foreach (var choice in menuItem.Choices)
                foreach (var i in choice)
                    i.choice = choice;

            return menuItem;
        }

        public static MenuItem NewCroissantEntrecoteSandwich(float price)
        {
            var menuItem = new MenuItem
            {
                Name = "3 Cheese Entrecote Croissant Sandwich",
                Description = "Cheddar, entrecote, lettuce, tomato",
                Image = "mi_cheese_entrecote_croissant_sandwich",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>
               {
                    new Choice<ChoiceItem>("Ingredients", new List<ChoiceItem>
                    {
                        new IngredientItem("Tomato"),
                        new IngredientItem("Lettuce")
                    })
                }
            };

            foreach (var choice in menuItem.Choices)
                foreach (var i in choice)
                    i.choice = choice;

            return menuItem;
        }

        // dessert

        public static MenuItem NewDessertSaltedCaramelBrownie(float price)
        {
            return new MenuItem
            {
                Name = "Salted Caramel Brownie",
                Description = "70% dark chocolate, salted caramel brownie.",
                Image = "mi_salted_caramel_brownie",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>()
            };
        }

        public static MenuItem NewDessertGingerCarrotCake(float price)
        {
            return new MenuItem
            {
                Name = "Ginger Carrot Cake",
                Description = "Carrot cake with ginger",
                Image = "mi_ginger_carrot_cake",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>()
            };
        }

        public static MenuItem NewDessertSupangle(float price)
        {
            return new MenuItem
            {
                Name = "Supangle",
                Description = "Its bottom layer includes pieces of cake and it is often garnished with pistachio or coconut, and chocolate chips.",
                Image = "mi_supangle",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>()
            };
        }

        public static MenuItem NewDessertProfiterole(float price)
        {
            return new MenuItem
            {
                Name = "Profiterole",
                Description = "Small hollow pastry typically filled with cream and covered with chocolate sauce.",
                Image = "mi_profiterole",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>()
            };
        }

        public static MenuItem NewDessertLemonTart(float price)
        {
            return new MenuItem
            {
                Name = "Lemon Tart",
                Description = "Pastry shell with a lemon flavored filling.",
                Image = "mi_lemon_tart",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>()
            };
        }

        public static MenuItem NewDessertMosaicCake(float price)
        {
            return new MenuItem
            {
                Name = "Mosaic Cake",
                Image = "mi_mosaic_cake",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>()
            };
        }

        public static MenuItem NewDessertDevilsCake(float price)
        {
            return new MenuItem
            {
                Name = "Devil's Cake",
                Image = "mi_devils_cake",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>()
            };
        }

        public static MenuItem NewDessertCheeseCake(float price)
        {
            return new MenuItem
            {
                Name = "Cheese Cake",
                Image = "mi_cheese_cake",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>()
            };
        }

        public static MenuItem NewDessertMonoCake(float price)
        {
            return new MenuItem
            {
                Name = "Mono Cake",
                Image = "mi_mono_cake",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>()
            };
        }

        // eclair

        public static MenuItem NewEclairClassic(float price)
        {
            return new MenuItem
            {
                Name = "Classic Eclair",
                Description = "Choux, vanilla cream, chocolate sauce",
                Image = "mi_classic_eclair",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>()
            };
        }

        public static MenuItem NewEclairSnickers(float price)
        {
            return new MenuItem
            {
                Name = "Snickers Eclair",
                Description = "Choux, vanilla cream, covered in milk chocolate, roasted peanuts",
                Image = "mi_snickers_eclair",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>()
            };
        }

        public static MenuItem NewEclairRocher(float price)
        {
            return new MenuItem
            {
                Name = "Rocher Eclair",
                Description = "Choux, vanilla cream, covered in rocher chocolate",
                Image = "mi_snickers_eclair",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>()
            };
        }

        // cafee

        public static MenuItem NewCafeeLatte(float price)
        {
            return new MenuItem
            {
                Name = "Caffe Latte",
                Image = "mi_caffe_latte",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>()
            };
        }

        public static MenuItem NewCafeeCappucino(float price)
        {
            return new MenuItem
            {
                Name = "Cappucino",
                Image = "mi_cappucino",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>()
            };
        }

        public static MenuItem NewCafeeAmericano(float price)
        {
            return new MenuItem
            {
                Name = "Americano",
                Image = "mi_americano",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>()
            };
        }

        public static MenuItem NewCafeeIceAmericano(float price)
        {
            return new MenuItem
            {
                Name = "Ice Americano",
                Image = "mi_ice_americano",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>()
            };
        }

        // burger

        public static MenuItem NewBurgerClassicMenu(float price)
        {
            var menuItem = new MenuItem
            {
                Name = "Classic Burger Menu",
                Description = "Burger, Potato, Beverage",
                Image = "mi_burger_menu",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>
                {
                    new Choice<ChoiceItem>("Ingredients", new List<ChoiceItem>
                    {
                        new IngredientItem("Onion"),
                        new IngredientItem("Pickles"),
                        new IngredientItem("Tomato"),
                        new IngredientItem("Mayonnaise"),
                        new IngredientItem("Lettuce")
                    }),

                    new Choice<ChoiceItem>("Hamburger Bread", new List<ChoiceItem>
                    {
                        new OptionItem("Classic", 0f, true),
                        new OptionItem("Bread with Sesame", 1f)
                    }),

                    new Choice<ChoiceItem>("Potato", new List<ChoiceItem>
                    {
                        new OptionItem("Apple slice", 0f, true),
                        new OptionItem("Finger")
                    }),

                    new Choice<ChoiceItem>("Beverage", new List<ChoiceItem>
                    {
                        new OptionItem("Cola 33cl", 0f, true),
                        new OptionItem("Sprite 33cl"),
                        new OptionItem("Fanta 33cl"),
                        new OptionItem("Fruko 33cl"),
                        new OptionItem("Cappy 33cl"),
                        new OptionItem("7up 33cl")
                    })
                }
            };

            foreach (var choice in menuItem.Choices)
                foreach (var i in choice)
                    i.choice = choice;

            return menuItem;
        }

        public static MenuItem NewBurgerClassicDoubleMenu(float price)
        {
            var menuItem = new MenuItem
            {
                Name = "Classic Double Burger Menu",
                Description = "Burger, Potato, Beverage",
                Image = "mi_burger_menu",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>
                {
                    new Choice<ChoiceItem>("Ingredients", new List<ChoiceItem>
                    {
                        new IngredientItem("Onion"),
                        new IngredientItem("Pickles"),
                        new IngredientItem("Tomato"),
                        new IngredientItem("Mayonnaise"),
                        new IngredientItem("Lettuce")
                    }),

                    new Choice<ChoiceItem>("Hamburger Bread", new List<ChoiceItem>
                    {
                        new OptionItem("Classic", 0f, true),
                        new OptionItem("Bread with Sesame", 1f)
                    }),

                    new Choice<ChoiceItem>("Potato", new List<ChoiceItem>
                    {
                        new OptionItem("Apple slice", 0f, true),
                        new OptionItem("Finger")
                    }),

                    new Choice<ChoiceItem>("Beverage", new List<ChoiceItem>
                    {
                        new OptionItem("Cola 33cl", 0f, true),
                        new OptionItem("Sprite 33cl"),
                        new OptionItem("Fanta 33cl"),
                        new OptionItem("Fruko 33cl"),
                        new OptionItem("Cappy 33cl"),
                        new OptionItem("7up 33cl")
                    })
                }
            };

            foreach (var choice in menuItem.Choices)
                foreach (var i in choice)
                    i.choice = choice;

            return menuItem;
        }

        public static MenuItem NewBurgerChickenMenu(float price)
        {
            var menuItem = new MenuItem
            {
                Name = "Chicken Burger Menu",
                Description = "Chicken, bread, mayonnaise, lettuce",
                Image = "mi_burger_menu",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>
                {
                    new Choice<ChoiceItem>("Ingredients", new List<ChoiceItem>
                    {
                        new IngredientItem("Mayonnaise"),
                        new IngredientItem("Lettuce")
                    }),

                    new Choice<ChoiceItem>("Hamburger Bread", new List<ChoiceItem>
                    {
                        new OptionItem("Classic", 0f, true),
                        new OptionItem("Bread with Sesame", 1f)
                    }),

                    new Choice<ChoiceItem>("Potato", new List<ChoiceItem>
                    {
                        new OptionItem("Apple slice", 0f, true),
                        new OptionItem("Finger")
                    }),

                    new Choice<ChoiceItem>("Beverage", new List<ChoiceItem>
                    {
                        new OptionItem("Cola 33cl", 0f, true),
                        new OptionItem("Sprite 33cl"),
                        new OptionItem("Fanta 33cl"),
                        new OptionItem("Fruko 33cl"),
                        new OptionItem("Cappy 33cl"),
                        new OptionItem("7up 33cl")
                    })
                }
            };

            foreach (var choice in menuItem.Choices)
                foreach (var i in choice)
                    i.choice = choice;

            return menuItem;
        }

        public static MenuItem NewBurgerDoubleChickenMenu(float price)
        {
            var menuItem = new MenuItem
            {
                Name = "Double Chicken Burger Menu",
                Description = "Chicken, bread, mayonnaise, lettuce",
                Image = "mi_burger_menu",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>
                {
                    new Choice<ChoiceItem>("Ingredients", new List<ChoiceItem>
                    {
                        new IngredientItem("Mayonnaise"),
                        new IngredientItem("Lettuce")
                    }),

                    new Choice<ChoiceItem>("Hamburger Bread", new List<ChoiceItem>
                    {
                        new OptionItem("Classic", 0f, true),
                        new OptionItem("Bread with Sesame", 1f)
                    }),

                    new Choice<ChoiceItem>("Potato", new List<ChoiceItem>
                    {
                        new OptionItem("Apple slice", 0f, true),
                        new OptionItem("Finger")
                    }),

                    new Choice<ChoiceItem>("Beverage", new List<ChoiceItem>
                    {
                        new OptionItem("Cola 33cl", 0f, true),
                        new OptionItem("Sprite 33cl"),
                        new OptionItem("Fanta 33cl"),
                        new OptionItem("Fruko 33cl"),
                        new OptionItem("Cappy 33cl"),
                        new OptionItem("7up 33cl")
                    })
                }
            };

            foreach (var choice in menuItem.Choices)
                foreach (var i in choice)
                    i.choice = choice;

            return menuItem;
        }

        public static MenuItem NewBurgerClassic(float price)
        {
            var menuItem = new MenuItem
            {
                Name = "Classic Burger",
                Description = "Beef, bread, pickles, ketchup, mayonnaise, lettuce, tomato, onion.",
                Image = "mi_burger",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>
                {
                    new Choice<ChoiceItem>("Ingredients", new List<ChoiceItem>
                    {
                        new IngredientItem("Onion"),
                        new IngredientItem("Pickles"),
                        new IngredientItem("Tomato"),
                        new IngredientItem("Mayonnaise"),
                        new IngredientItem("Lettuce")
                    }),

                    new Choice<ChoiceItem>("Hamburger Bread", new List<ChoiceItem>
                    {
                        new OptionItem("Classic", 0f, true),
                        new OptionItem("Bread with Sesame", 1f)
                    })
                }
            };

            foreach (var choice in menuItem.Choices)
                foreach (var i in choice)
                    i.choice = choice;

            return menuItem;
        }

        public static MenuItem NewBurgerClassicDouble(float price)
        {
            var menuItem = new MenuItem
            {
                Name = "Double Burger",
                Description = "Beef, bread, pickles, ketchup, mayonnaise, lettuce, tomato, onion.",
                Image = "mi_double_burger",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>
                {
                    new Choice<ChoiceItem>("Ingredients", new List<ChoiceItem>
                    {
                        new IngredientItem("Onion"),
                        new IngredientItem("Pickles"),
                        new IngredientItem("Tomato"),
                        new IngredientItem("Mayonnaise"),
                        new IngredientItem("Lettuce")
                    }),

                    new Choice<ChoiceItem>("Hamburger Bread", new List<ChoiceItem>
                    {
                        new OptionItem("Classic", 0f, true),
                        new OptionItem("Bread with Sesame", 1f)
                    })
                }
            };

            foreach (var choice in menuItem.Choices)
                foreach (var i in choice)
                    i.choice = choice;

            return menuItem;
        }

        public static MenuItem NewBurgerChicken(float price)
        {
            var menuItem = new MenuItem
            {
                Name = "Chicken Burger",
                Description = "Chicken, bread, mayonnaise, lettuce",
                Image = "mi_chicken_burger",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>
                {
                    new Choice<ChoiceItem>("Ingredients", new List<ChoiceItem>
                    {
                        new IngredientItem("Mayonnaise"),
                        new IngredientItem("Lettuce")
                    }),

                    new Choice<ChoiceItem>("Hamburger Bread", new List<ChoiceItem>
                    {
                        new OptionItem("Classic", 0f, true),
                        new OptionItem("Bread with Sesame", 1f)
                    })
                }
            };

            foreach (var choice in menuItem.Choices)
                foreach (var i in choice)
                    i.choice = choice;

            return menuItem;
        }

        public static MenuItem NewBurgerDoubleChicken(float price)
        {
            var menuItem = new MenuItem
            {
                Name = "Double Chicken Burger",
                Description = "Chicken, bread, mayonnaise, lettuce.",
                Image = "mi_double_chicken_burger",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>
                {
                    new Choice<ChoiceItem>("Ingredients", new List<ChoiceItem>
                    {
                        new IngredientItem("Mayonnaise"),
                        new IngredientItem("Lettuce")
                    }),

                    new Choice<ChoiceItem>("Hamburger Bread", new List<ChoiceItem>
                    {
                        new OptionItem("Classic", 0f, true),
                        new OptionItem("Bread with Sesame", 1f)
                    })
                }
            };

            foreach (var choice in menuItem.Choices)
                foreach (var i in choice)
                    i.choice = choice;

            return menuItem;
        }

        // chicken

        public static MenuItem NewChickenAliNazik(float price)
        {
            var menuItem = new MenuItem
            {
                Name = "Alinazik Chicken",
                Description = "Chicken chop, yogurt, eggplant",
                Image = "mi_alinazik_chicken",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>
                {
                    new Choice<ChoiceItem>("Extra Ingredients", new List<ChoiceItem>
                    {
                        new ExtraItem("Mushroom", 3f),
                        new ExtraItem("Special Sauce", 2f)
                    })
                }
            };

            foreach (var choice in menuItem.Choices)
                foreach (var i in choice)
                    i.choice = choice;

            return menuItem;
        }

        public static MenuItem NewChickenSteak(float price)
        {
            var menuItem = new MenuItem
            {
                Name = "Grilled Chicken Steak",
                Description = "Grilled chicken steak, pasta, salad",
                Image = "mi_grilled_chicken_steak",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>
                {
                    new Choice<ChoiceItem>("Extra Ingredients", new List<ChoiceItem>
                    {
                        new ExtraItem("Mushroom", 3f),
                        new ExtraItem("Special Sauce", 2f)
                    })
                }
            };

            foreach (var choice in menuItem.Choices)
                foreach (var i in choice)
                    i.choice = choice;

            return menuItem;
        }

        public static MenuItem NewChickenCurrySauce(float price)
        {
            var menuItem = new MenuItem
            {
                Name = "Chicken with curry sauce",
                Description = "Chicken curry sauce, mushroom, pasta, onion, salad",
                Image = "mi_curry_chicken",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>
                {
                    new Choice<ChoiceItem>("Extra Ingredients", new List<ChoiceItem>
                    {
                        new ExtraItem("Mushroom", 3f),
                        new ExtraItem("Special Sauce", 2f)
                    })
                }
            };

            foreach (var choice in menuItem.Choices)
                foreach (var i in choice)
                    i.choice = choice;

            return menuItem;
        }

        public static MenuItem NewChickenFajitas(float price)
        {
            var menuItem = new MenuItem
            {
                Name = "Chicken Fajitas",
                Description = "Chicken fajitas, mushroom, onion, salad, pepper",
                Image = "mi_chicken_fajitas",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>
                {
                    new Choice<ChoiceItem>("Ingredients", new List<ChoiceItem>
                    {
                        new IngredientItem("Onion"),
                        new IngredientItem("Pepper")
                    }),

                    new Choice<ChoiceItem>("Potato", new List<ChoiceItem>
                    {
                        new OptionItem("Apple slice", 0f, true),
                        new OptionItem("Finger")
                    }),

                    new Choice<ChoiceItem>("Extra Ingredients", new List<ChoiceItem>
                    {
                        new ExtraItem("Mushroom", 3f),
                        new ExtraItem("Special Sauce", 2f)
                    })
                }
            };

            foreach (var choice in menuItem.Choices)
                foreach (var i in choice)
                    i.choice = choice;

            return menuItem;
        }

        // pasta

        public static MenuItem NewPastaNoodleChicken(float price)
        {
            var menuItem = new MenuItem
            {
                Name = "Noodle Chicken",
                Description = "Chicken with sauce, mushroom, pepper",
                Image = "mi_noodle_chicken",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>
                {
                    new Choice<ChoiceItem>("Ingredients", new List<ChoiceItem>
                    {
                        new IngredientItem("Pepper")
                    })
                }
            };

            foreach (var choice in menuItem.Choices)
                foreach (var i in choice)
                    i.choice = choice;

            return menuItem;
        }

        public static MenuItem NewPastaSpaghettiBolognese(float price)
        {
            return new MenuItem
            {
                Name = "Spaghetti Bolognese",
                Description = "Tomato sauce, mince, pasta",
                Image = "mi_spaghetti_bolognese",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>()
            };

        }

        public static MenuItem NewPastaNapoliten(float price)
        {
            return new MenuItem
            {
                Name = "Napoliten Pasta",
                Description = "Napolitan sauce, cheddar, pasta",
                Image = "mi_napolitan_pasta",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>()
            };
        }

        public static MenuItem NewPastaAlfredo(float price)
        {
            return new MenuItem
            {
                Name = "Alfredo Pasta",
                Description = "Chicken with sauce, cheddar, mushroom, pasta, custard",
                Image = "mi_alfredo_pasta",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>()
            };
        }

        // Meat

        public static MenuItem NewMeatTenderloin(float price)
        {
            var menuItem = new MenuItem
            {
                Name = "Tenderloin",
                Description = "Tenderloin, salad, pasta.",
                Image = "mi_tenderloin",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>
                {
                    new Choice<ChoiceItem>("Sauces", new List<ChoiceItem>
                    {
                        new ExtraItem("Barbeque", 2f),
                        new ExtraItem("Ranch", 2f),
                        new ExtraItem("Garlic", 2f),
                        new ExtraItem("Mustrad", 2f),
                        new ExtraItem("Cheddar", 2f),
                        new ExtraItem("Chili", 2f)
                    })
                }
            };

            foreach (var choice in menuItem.Choices)
                foreach (var i in choice)
                    i.choice = choice;

            return menuItem;
        }

        public static MenuItem NewMeatTenderloinMushroom(float price)
        {
            var menuItem = new MenuItem
            {
                Name = "Tenderloin with Mushroom Sauce",
                Description = "Tenderloin, mushroom sauce, salad, pasta.",
                Image = "mi_tenderloin_mushroom",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>
                {
                    new Choice<ChoiceItem>("Sauces", new List<ChoiceItem>
                    {
                        new ExtraItem("Barbeque", 2f),
                        new ExtraItem("Ranch", 2f),
                        new ExtraItem("Garlic", 2f),
                        new ExtraItem("Mustrad", 2f),
                        new ExtraItem("Cheddar", 2f),
                        new ExtraItem("Chili", 2f)
                    })
                }
            };

            foreach (var choice in menuItem.Choices)
                foreach (var i in choice)
                    i.choice = choice;

            return menuItem;
        }

        public static MenuItem NewMeatGrilledMeatBall(float price)
        {
            var menuItem = new MenuItem
            {
                Name = "Grilled Meatball",
                Description = "Grilled meatball, salad, potato.",
                Image = "mi_tenderloin",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>
                {
                    new Choice<ChoiceItem>("Sauces", new List<ChoiceItem>
                    {
                        new ExtraItem("Barbeque", 2f),
                        new ExtraItem("Ranch", 2f),
                        new ExtraItem("Garlic", 2f),
                        new ExtraItem("Mustrad", 2f),
                        new ExtraItem("Cheddar", 2f),
                        new ExtraItem("Chili", 2f)
                    })
                }
            };

            foreach (var choice in menuItem.Choices)
                foreach (var i in choice)
                    i.choice = choice;

            return menuItem;
        }

        // salad

        public static MenuItem NewSaladCaesar(float price)
        {
            return new MenuItem
            {
                Name = "Caesar Salad",
                Description = "Chicken fillet, cucumber, tomato, lettuce, caesar sauce.",
                Image = "mi_caesar_salad",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>()
            };
        }

        public static MenuItem NewSaladMexican(float price)
        {
            return new MenuItem
            {
                Name = "Mexican Salad",
                Description = "Chicken with Mexican sauce, cucumber, tomato, corn, lettuce.",
                Image = "mi_mexican_salad",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>()
            };
        }

        public static MenuItem NewSaladThai(float price)
        {
            return new MenuItem
            {
                Name = "Thai Salad",
                Description = "Mushrooms in sauce, beans, lettuce, cucumber, tomato, corn.",
                Image = "mi_thai_salad",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>()
            };
        }

        public static MenuItem NewSaladTuna(float price)
        {
            return new MenuItem
            {
                Name = "Tuna Salad",
                Description = "Mediterranean salad, tuna, tomato, cucumber, corn, lettuce.",
                Image = "mi_tuna_salad",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>()
            };
        }

        // beverage

        public static MenuItem NewCola33(float price)
        {
            return new MenuItem
            {
                Name = "Cola 33cl.",
                Image = "mi_cola_33",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>()
            };
        }

        public static MenuItem NewSprite33(float price)
        {
            return new MenuItem
            {
                Name = "Sprite 33cl.",
                Image = "mi_sprite_33",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>()
            };
        }

        public static MenuItem NewFanta33(float price)
        {
            return new MenuItem
            {
                Name = "Fanta 33cl.",
                Image = "mi_fanta_33",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>()
            };
        }

        public static MenuItem NewFruko33(float price)
        {
            return new MenuItem
            {
                Name = "Fruko 33cl.",
                Image = "mi_fruko_33",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>()
            };
        }

        public static MenuItem NewCappy33(float price)
        {
            return new MenuItem
            {
                Name = "Cappy 33cl.",
                Image = "mi_cappy_33",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>()
            };
        }

        public static MenuItem NewSevenup33(float price)
        {
            return new MenuItem
            {
                Name = "7up 33cl.",
                Image = "mi_seven_up_33",
                Price = price,
                Choices = new List<Choice<ChoiceItem>>()
            };
        }
    }
}
