using System.Collections.Generic;
using System.Threading.Tasks;
using FoodDeliveryTemplate.DataStores;
using FoodDeliveryTemplate.Models;

namespace FoodDeliveryTemplate.Services
{
    /// <summary>
    /// Interface with common tasks
    /// </summary>
    public interface IService
    {
        /// <summary>
        /// Get cuisines by name
        /// </summary>
        /// <param name="name">Keyword for the cuisine name</param>
        /// <returns>List of cuisines filtered by name</returns>
        Task<IEnumerable<Cuisine>> GetCuisinesAsync(string name);

        /// <summary>
        /// Get the place by id
        /// </summary>
        /// <param name="id">place id</param>
        /// <returns>Place object or null</returns>
        Task<Place> GetPlaceAsync(string id);

        /// <summary>
        /// Get places by parameters
        /// </summary>
        /// <param name="cuisineId">Associated cuisine id. Default is null.</param>
        /// <param name="key">Keyword for place name. Default is null.</param>
        /// <param name="onlyFavorite">Get only favorited items. Default is false.</param>
        /// <param name="onlyNew">Get only new places. Default is false.</param>
        /// <param name="onlyFeatured">Get only featured items. Default is false.</param>
        /// <param name="onlyPopular">Get only popular items. Default is false.</param>
        /// <param name="sortBy">SortBy enumaration. Default is unsorted.</param>
        /// <returns></returns>
        Task<IEnumerable<Place>> GetPlacesAsync(string cuisineId = null, string key = null,
                                            bool onlyFavorite = false, bool onlyNew = false,
                                            bool onlyFeatured = false, bool onlyPopular = false,
                                            SortBy sortBy = SortBy.Unsorted);

        /// <summary>
        /// Get customer by id
        /// </summary>
        /// <param name="id">Customer Id</param>
        /// <returns>Customer object or null</returns>
        Task<Customer> GetCustomerAsync(string id);

        /// <summary>
        /// Update the customer
        /// </summary>
        /// <param name="customer">Customer object</param>
        /// <returns>True, if successful</returns>
        Task<bool> UpdateCustomerAsync(Customer customer);

        // Address
        /// <summary>
        /// Get address by id
        /// </summary>
        /// <param name="id">Address id</param>
        /// <returns>Address object or null</returns>
        Task<Address> GetAddressAsync(string id);

        /// <summary>
        /// Get list of addresses by customer id
        /// </summary>
        /// <param name="customerId">Customer id</param>
        /// <returns>List of address of customer</returns>
        Task<IEnumerable<Address>> GetAddressesAsync(string customerId);

        /// <summary>
        /// Delete the address
        /// </summary>
        /// <param name="id">Address Id</param>
        /// <returns>True, if successful</returns>
        Task<bool> DeleteAddressAsync(string id);

        /// <summary>
        /// Add the address
        /// </summary>
        /// <param name="address">Address object</param>
        /// <returns>Added address</returns>
        Task<Address> AddAddressAsync(Address address);

        /// <summary>
        /// Update the address
        /// </summary>
        /// <param name="address">Address object</param>
        /// <returns>True, if successful</returns>
        Task<bool> UpdateAddressAsync(Address address);

        /// <summary>
        /// Get cart item by id
        /// </summary>
        /// <param name="id">CartItem id</param>
        /// <returns>CartItem object or null</returns>
        Task<BasketItem> GetCartItemAsync(string id);

        /// <summary>
        /// Add the cart item
        /// </summary>
        /// <param name="cartItem">CartItem object</param>
        /// <returns>Added cart item</returns>
        Task<BasketItem> AddCartItemAsync(BasketItem cartItem);

        /// <summary>
        /// Update the CartItem
        /// </summary>
        /// <param name="cartItem">CartItem object</param>
        /// <returns>True, if successful</returns>
        Task<bool> UpdateCartItemAsync(BasketItem cartItem);

        /// <summary>
        /// Get all items in the cart
        /// </summary>
        /// <returns>All CartItems in the cart</returns>
        Task<IEnumerable<BasketItem>> GetCartItemsAsync();

        /// <summary>
        /// Delete cart by id
        /// </summary>
        /// <param name="id">CartItem id</param>
        /// <returns>True, if successful</returns>
        Task<bool> DeleteCartItemAsync(string id);

        /// <summary>
        /// Delete all items in the cart
        /// </summary>
        /// <returns>True, if successful</returns>
        Task<bool> DeleteAllCartItemsAsync();

        /// <summary>
        /// Get order by id
        /// </summary>
        /// <param name="id">Order id</param>
        /// <returns>Order object or null</returns>
        Task<Order> GetOrderAsync(string id);

        /// <summary>
        /// Get orders by customer id
        /// </summary>
        /// <param name="customerId">Customer id</param>
        /// <returns>List of orders of customer</returns>
        Task<IEnumerable<Order>> GetOrdersAsync(string customerId);

        /// <summary>
        /// Add the order object
        /// </summary>
        /// <param name="order">Order object</param>
        /// <returns>Added order object</returns>
        Task<Order> AddOrderAsync(Order order);

        /// <summary>
        /// Get items in the order
        /// </summary>
        /// <param name="orederId">Order id</param>
        /// <returns>Items in the order</returns>
        Task<IEnumerable<OrderItem>> GetOrderItemsAsync(string orederId);

        /// <summary>
        /// Add order item
        /// </summary>
        /// <param name="orderItem">OrderItem object</param>
        /// <returns>Added order item</returns>
        Task<OrderItem> AddOrderItemAsync(OrderItem orderItem);

        /// <summary>
        /// Get list of ratings by product id
        /// </summary>
        /// <param name="productId">Product id</param>
        /// <returns>List of rating objects filtered by product id</returns>
        Task<IEnumerable<Rating>> GetRatingsAsync(string productId);

        /// <summary>
        /// Add the rating
        /// </summary>
        /// <param name="rating">Rating object</param>
        /// <returns>Added rating object</returns>
        Task<Rating> AddRatingAsync(Rating rating);

        /// <summary>
        /// Add the favorite
        /// </summary>
        /// <param name="favorite">Favorite object</param>
        /// <returns>Added favorite object</returns>
        Task<Favorite> AddFavoriteAsync(Favorite favorite);

        /// <summary>
        /// Delete the Favorite
        /// </summary>
        /// <param name="id">Favorite id</param>
        /// <returns>True, if successful</returns>
        Task<bool> DeleteFavoriteAsync(string id);

        /// <summary>
        /// Determine the product is favorite 
        /// </summary>
        /// <param name="customerId">Customer id</param>
        /// <param name="productId">Product id</param>
        /// <returns>True, if product has been addes to favorites for customer</returns>
        Task<bool> IsFavoriteAsync(string customerId, string productId);

        /// <summary>
        /// Get the Favorite object by parameters
        /// </summary>
        /// <param name="customerId">Customer id</param>
        /// <param name="productId">Product id</param>
        /// <returns>Favorite object or null</returns>
        Task<Favorite> GetFavoriteAsync(string customerId, string productId);

    }
}
