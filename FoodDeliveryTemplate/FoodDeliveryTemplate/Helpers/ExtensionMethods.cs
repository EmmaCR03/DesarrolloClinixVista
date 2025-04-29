using FoodDeliveryTemplate.DataStores;

namespace FoodDeliveryTemplate.Helpers
{
    /// <summary>
    /// Provides friendly names for the SortBy enum.
    /// </summary>
    public static class ExtensionMethods
    {
        public const string UNSORTED = "Default";
        public const string NAME_AZ = "Name (A-Z)";
        public const string NAME_ZA = "Name (Z-A)";
        public const string HIGHEST_RATE = "Highest Rate";
        public const string RATE_COUNT = "Rate Count";

        public static string FriendlyName(this SortBy sortBy)
        {
            switch(sortBy)
            {
                case SortBy.Name_AZ: return NAME_AZ;
                case SortBy.Name_ZA: return NAME_ZA;
                case SortBy.Highest_Rate: return HIGHEST_RATE;
                case SortBy.Rate_Count: return RATE_COUNT;
                default: return UNSORTED;
            }
        }

        public static SortBy SortByFromFriendlyName(this string name)
        {
            switch(name)
            {
                case NAME_AZ: return SortBy.Name_AZ;
                case NAME_ZA: return SortBy.Name_ZA;
                case HIGHEST_RATE: return SortBy.Highest_Rate;
                case RATE_COUNT: return SortBy.Rate_Count;
                default: return SortBy.Unsorted;
            }
        }
    }
}
