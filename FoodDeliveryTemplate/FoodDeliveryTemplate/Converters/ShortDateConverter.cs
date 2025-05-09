﻿using System.Globalization;

namespace FoodDeliveryTemplate.Converters
{
    /// <summary>
    /// Binding value converter that returns a short-form string of a date.
    /// <seealso href="https://docs.microsoft.com/en-us/dotnet/maui/xaml/fundamentals/data-binding-basics#binding-value-converters"/>
    /// </summary>
    public class ShortDateConverter : IValueConverter
    {
        /// <param name="value">DateTime</param>
        /// <param name="targetType">Unused</param>
        /// <param name="parameter">Unused</param>
        /// <param name="culture">Unused</param>
        /// <returns>A short-form string of the date.</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((DateTime)value).ToShortDateString();
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
