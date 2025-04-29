using System;

namespace FoodDeliveryTemplate.Models
{
    /// <summary>
    /// Type represent cuisine entity
    /// </summary>
    public class Cuisine : Entity
    {
        /// <summary>
        /// Name for the cuisine
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Image for the cuisine
        /// </summary>
        public string Image { get; set; }
    }
}
