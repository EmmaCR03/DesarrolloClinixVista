using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryTemplate.Converters
{
    /// <summary>
    /// Binding value converter that returns a value multiplied by 0.75.
    /// <seealso href="https://docs.microsoft.com/en-us/dotnet/maui/xaml/fundamentals/data-binding-basics#binding-value-converters"/>
    /// </summary>

    class MultiplyConverter : IValueConverter
    {
        /// <param name="value">A double value to multiply</param>
        /// <param name="targetType">Unused</param>
        /// <param name="parameter">A double to multiply by the value parameter</param>
        /// <param name="culture">Unused</param>
        /// <returns>A short-form string of the date.</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((double)value) * ((double)parameter);
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
