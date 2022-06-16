namespace SimpleAutomate.SwagLabs.Tests.Pages.Login
{
	public partial class LoginPage : BasePage
	{
		public async Task AssertInventoryShouldBePresent()
		{
			await Expect(Page.Locator(InventoryContainer)).ToBeVisibleAsync(new Microsoft.Playwright.LocatorAssertionsToBeVisibleOptions { Timeout = 300});
		}
	}
}

