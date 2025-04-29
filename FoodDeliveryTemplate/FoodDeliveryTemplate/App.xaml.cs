using FoodDeliveryTemplate.DataStores.MockDataStore;
using FoodDeliveryTemplate.Services;

namespace FoodDeliveryTemplate;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        DependencyService.RegisterSingleton(new CuisineDataStore());
        DependencyService.RegisterSingleton(new PlaceDataStore());
        DependencyService.RegisterSingleton(new CustomerDataStore());
        DependencyService.RegisterSingleton(new AddressDataStore());
        DependencyService.RegisterSingleton(new RatingDataStore());
        DependencyService.RegisterSingleton(new FavoriteDataStore());
        DependencyService.RegisterSingleton(new BasketItemDataStore());
        DependencyService.RegisterSingleton(new OrderItemDataStore());
        DependencyService.RegisterSingleton(new OrderDataStore());

        DependencyService.Register<IService, MockService>();

        MainPage = new AppShell();
	}
}
