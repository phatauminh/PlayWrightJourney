using SimpleAutomate.Core.Drivers;

namespace SimpleAutomate.SwagLabs.Tests.Pages.Sections
{
	public class CartInfoSection : PlaywrightDriver
	{
		private string CartIcon => "id=shopping_cart_container";

		public async Task OpenCart()
		{
			await Page.ClickAsync(CartIcon);
		}
	}
}

