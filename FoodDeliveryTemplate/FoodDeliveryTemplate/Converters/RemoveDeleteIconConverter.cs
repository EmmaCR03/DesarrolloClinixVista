﻿using System.Globalization;
using FoodDeliveryTemplate.MaterialDesign;

namespace FoodDeliveryTemplate.Converters
{
    /// <summary>
    /// Binding value converter that returns a bin or minus icon corresponding to the amount in the shopping cart.
    /// <seealso href="https://docs.microsoft.com/en-us/dotnet/maui/xaml/fundamentals/data-binding-basics#binding-value-converters"/>
    /// </summary>
    public class RemoveDeleteIconConverter : IValueConverter
    {
        /// <param name="value">The amount of items in the shopping cart (int).</param>
        /// <param name="targetType">Unused</param>
        /// <param name="parameter">Unused</param>
        /// <param name="culture">Unused</param>
        /// <returns>Unicode string of a Material icon.</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (int)value > 1 ? Icons.Remove : Icons.DeleteOutline; 
        }

        /// <summary>
        /// It is unnecessary to implement.
        /// </summary>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
