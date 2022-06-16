using SimpleAutomate.SwagLabs.Tests.Models;
using SimpleAutomate.SwagLabs.Tests.Pages.Cart;
using SimpleAutomate.SwagLabs.Tests.Pages.Checkout;
using SimpleAutomate.SwagLabs.Tests.Pages.Inventory;

namespace SimpleAutomate.SwagLabs.Tests.Facade
{
	public class PurchaseFacade
	{
        private readonly MainPage _mainPage;
		private readonly CartPage _cartPage;
		private readonly CheckoutPage _checkoutPage;

		public PurchaseFacade()
		{
			_mainPage = new MainPage();
			_cartPage = new CartPage();
			_checkoutPage = new CheckoutPage();
		}

		public void PurchaseItems(List<string> items, PurchaseInfo info, decimal expectedAmount)
		{

		}
	}
}

