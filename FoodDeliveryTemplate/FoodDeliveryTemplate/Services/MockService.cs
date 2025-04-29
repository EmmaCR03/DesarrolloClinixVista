using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryTemplate.DataStores;
using FoodDeliveryTemplate.Models;

namespace FoodDeliveryTemplate.Services
{
    /// <summary>
    /// Mock service that works with mock data stores for testing.
    /// </summary>
    public class MockService : IService
    {
        ICuisineDataStore dataCuisine => DependencyService.Get<ICuisineDataStore>();
        IPlaceDataStore dataPlace => DependencyService.Get<IPlaceDataStore>();
        ICustomerDataStore dataCustomer = DependencyService.Get<ICustomerDataStore>();
        IAddressDataStore dataAddress => DependencyService.Get<IAddressDataStore>();
        ICartItemDataStore dataCartItem => DependencyService.Get<ICartItemDataStore>();
        IOrderDataStore dataOrder => DependencyService.Get<IOrderDataStore>();
        IOrderItemDataStore dataOrderItem => DependencyService.Get<IOrderItemDataStore>();
        IRatingDataStore dataRating => DependencyService.Get<IRatingDataStore>();
        IFavoriteDataStore dataFavorite => DependencyService.Get<IFavoriteDataStore>();

        // Methods for Cuisine entity

        public async Task<IEnumerable<Cuisine>> GetCuisinesAsync(string name)
        {
            var result = await dataCuisine.GetByAsync(i => name == null || i.Name.Contains(name));

            return await Task.FromResult(result);
        }

        // Methods for place entity

        public async Task<Place> GetPlaceAsync(string id)
        {
            return await dataPlace.GetAsync(id);
        }

        public async Task<IEnumerable<Place>> GetPlacesAsync(string cuisineId = null, string key = null,
                                            bool onlyFavorite = false, bool onlyNew = false,
                                            bool onlyFeatured = false, bool onlyPopular = false,
                                            SortBy sortBy = SortBy.Unsorted)
        {
            var result = (await dataPlace.GetByAsync(p => (cuisineId == null || p.CuisineIds.Contains(cuisineId)) &&
                                            (key == null || p.Name.ToLower().Contains(key.ToLower())) &&
                                            (onlyNew == false || p.IsNew == true) &&
                                            (onlyFeatured == false || p.IsFeatured == true) &&
                                            (onlyPopular == false || p.IsPopular == true))).ToList()
                                            .Select(i =>
                                            {
                                                i.ReviewCount = dataRating.GetByAsync(r => r.PlaceId == i.Id).Result.Count();
                                                i.AverageRating = i.ReviewCount > 0 ?
                                                    (float)dataRating.GetByAsync(r =>
                                                        r.PlaceId == i.Id).Result.Sum(r => r.Star) / i.ReviewCount : 0;
                                                i.IsFavorite = IsFavoriteAsync(Globals.LoggedCustomerId, i.Id).Result;
                                                return i;
                                            }).Where(p => onlyFavorite == false || p.IsFavorite == true);

            switch (sortBy)
            {
                case SortBy.Name_AZ: result = result.OrderBy(i => i.Name); break;
                case SortBy.Name_ZA: result = result.OrderByDescending(i => i.Name); break;
                case SortBy.Highest_Rate: result = result.OrderByDescending(i => i.AverageRating); break;
                case SortBy.Rate_Count: result = result.OrderByDescending(i => i.ReviewCount); break;
            };

            return result;
        }

        // Methods for Customer entity

        public async Task<Customer> GetCustomerAsync(string id)
        {
            return await dataCustomer.GetAsync(id);
        }

        public async Task<bool> UpdateCustomerAsync(Customer customer)
        {
            return await dataCustomer.UpdateAsync(customer);
        }

        // Methods for Address entity

        public async Task<Address> GetAddressAsync(string id)
        {
            return await dataAddress.GetAsync(id);
        }

        public async Task<IEnumerable<Address>> GetAddressesAsync(string customerId)
        {
            return (await dataAddress.GetByAsync(i => i.CustomerId == customerId))
                        .OrderBy(i => i.Title);
        }

        public async Task<bool> DeleteAddressAsync(string id)
        {
            return await dataAddress.DeleteAsync(id);
        }

        public async Task<Address> AddAddressAsync(Address address)
        {
            return await dataAddress.AddAsync(address);
        }

        public async Task<bool> UpdateAddressAsync(Address address)
        {
            return await dataAddress.UpdateAsync(address);
        }

        // Methods for CartItem entity

        public async Task<BasketItem> GetCartItemAsync(string id)
        {
            return await dataCartItem.GetAsync(id);
        }

        public async Task<BasketItem> AddCartItemAsync(BasketItem cartItem)
        {
            var oldItem = dataCartItem.GetByAsync(i => i.ProductName == cartItem.ProductName &&
                                                        i.IngredientString == cartItem.IngredientString &&
                                                        i.ChoiceString == cartItem.ChoiceString &&
                                                        i.PlaceName == cartItem.PlaceName &&
                                                        i.UnitPrice == cartItem.UnitPrice)
                            .Result.FirstOrDefault();

            if (oldItem == null)
                return await dataCartItem.AddAsync(cartItem);
            else
            {
                oldItem.Quantity += cartItem.Quantity;
                await dataCartItem.UpdateAsync(oldItem);
                return oldItem;
            }
        }

        public async Task<bool> UpdateCartItemAsync(BasketItem cartItem)
        {
            return await dataCartItem.UpdateAsync(cartItem);
        }

        public async Task<IEnumerable<BasketItem>> GetCartItemsAsync()
        {
            var result = (await dataCartItem.GetAllAsync());

            return await Task.FromResult(result);
        }

        public async Task<bool> DeleteCartItemAsync(string id)
        {
            return await dataCartItem.DeleteAsync(id);
        }

        public async Task<bool> DeleteAllCartItemsAsync()
        {
            return await dataCartItem.DeleteAllAsync();
        }

        // Methods for Order entity

        public async Task<Order> GetOrderAsync(string id)
        {
            return await dataOrder.GetAsync(id);
        }

        public async Task<IEnumerable<Order>> GetOrdersAsync(string customerId)
        {
            var result = (await dataOrder.GetByAsync(o => o.CustomerId == customerId)).ToList()
                            .Select(o => {
                                o.Total = 0;
                                dataOrderItem.GetByAsync(l =>
                                    l.OrderId == o.Id).Result.ToList().ForEach(li => o.Total += li.Total);
                                return o;
                            });

            return await Task.FromResult(result);
        }

        public async Task<Order> AddOrderAsync(Order order)
        {
            return await dataOrder.AddAsync(order);
        }

        // Methods for OrderItem entity

        public async Task<IEnumerable<OrderItem>> GetOrderItemsAsync(string orederId)
        {
            var result = await dataOrderItem.GetByAsync(s => s.OrderId == orederId);

            return await Task.FromResult(result);
        }

        public async Task<OrderItem> AddOrderItemAsync(OrderItem orderItem)
        {
            return await dataOrderItem.AddAsync(orderItem);
        }

        // Methods for Rating entity

        public async Task<Rating> AddRatingAsync(Rating rating)
        {
            return await dataRating.AddAsync(rating);
        }

        public async Task<IEnumerable<Rating>> GetRatingsAsync(string productId)
        {
            return (await dataRating.GetByAsync(r => r.PlaceId == productId)).ToList()
                            .Select(i => {
                                i.CustomerFullName = dataCustomer.GetAsync(i.CustomerId).Result.FullName;
                                return i;
                            }).OrderBy(t => t.DateGmt);
        }

        // Methods for Favorite entity

        public async Task<Favorite> AddFavoriteAsync(Favorite favorite)
        {
            return await dataFavorite.AddAsync(favorite);
        }

        public async Task<bool> DeleteFavoriteAsync(string id)
        {
            return await dataFavorite.DeleteAsync(id);
        }

        public async Task<bool> IsFavoriteAsync(string customerId, string productId)
        {
            return await dataFavorite.IsExistAsync(f => f.CustomerId == customerId && f.PlaceId == productId);
        }

        public async Task<Favorite> GetFavoriteAsync(string customerId, string productId)
        {
            return (await dataFavorite.GetByAsync(f => f.CustomerId == customerId && f.PlaceId == productId))
                        .FirstOrDefault();
        }

    }
}
