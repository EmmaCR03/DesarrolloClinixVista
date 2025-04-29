using FoodDeliveryTemplate.Views;

namespace FoodDeliveryTemplate;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
        Routing.RegisterRoute(nameof(ResetPasswordPage), typeof(ResetPasswordPage));
        Routing.RegisterRoute(nameof(RatingsPage), typeof(RatingsPage));
        Routing.RegisterRoute(nameof(NewRatingPage), typeof(NewRatingPage));
        Routing.RegisterRoute(nameof(MyAccountPage), typeof(MyAccountPage));
        Routing.RegisterRoute(nameof(OrdersPage), typeof(OrdersPage));
        Routing.RegisterRoute(nameof(OrderDetailPage), typeof(OrderDetailPage));
        Routing.RegisterRoute(nameof(AddressesPage), typeof(AddressesPage));
        Routing.RegisterRoute(nameof(AddressDetailPage), typeof(AddressDetailPage));
        Routing.RegisterRoute(nameof(AccountDetailsPage), typeof(AccountDetailsPage));
        Routing.RegisterRoute(nameof(ChangePasswordPage), typeof(ChangePasswordPage));
        Routing.RegisterRoute(nameof(SignUpPage), typeof(SignUpPage));
        Routing.RegisterRoute(nameof(CheckoutAddressPage), typeof(CheckoutAddressPage));
        Routing.RegisterRoute(nameof(CheckoutPaymentPage), typeof(CheckoutPaymentPage));
        Routing.RegisterRoute(nameof(CheckoutCompletedPage), typeof(CheckoutCompletedPage));
        Routing.RegisterRoute(nameof(PlaceDetailPage), typeof(PlaceDetailPage));
        Routing.RegisterRoute(nameof(PlacesPage), typeof(PlacesPage));

    }
}
