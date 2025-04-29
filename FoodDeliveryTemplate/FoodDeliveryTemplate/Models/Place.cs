using System;
using System.Collections.Generic;

namespace FoodDeliveryTemplate.Models
{
    /// <summary>
    /// Type represent place entity
    /// </summary>
    public class Place : Entity
    {
        /// <summary>
        /// Name for the Place
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Short Description for the place
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Image for the place
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Minimum order for delivery
        /// </summary>
        public float DeliveryPrice { get; set; }

        /// <summary>
        /// Minimum delivery time
        /// </summary>
        public string DeliveryTime { get; set; }

        /// <summary>
        /// District of place
        /// </summary>
        public string District { get; set; }

        /// <summary>
        /// Average rating of the place
        /// </summary>
        public float AverageRating { get; set; }

        /// <summary>
        /// Number of the reviews
        /// </summary>
        public int ReviewCount { get; set; }

        /// <summary>
        /// True if it is foverite item for the logged customer 
        /// </summary>
        public bool IsFavorite { get; set; }

        /// <summary>
        ///True, if prouct is featured
        /// </summary>
        public bool IsFeatured { get; set; }

        /// <summary>
        /// True, if product is new
        /// </summary>
        public bool IsNew { get; set; }

        /// <summary>
        /// True, if product is popular
        /// </summary>
        public bool IsPopular { get; set; }

        /// <summary>
        /// List of ids of associated cuisines
        /// </summary>
        public string[] CuisineIds { get; set; }

        public List<MenuCategory> MenuCategories { get; set; }

    }
}
