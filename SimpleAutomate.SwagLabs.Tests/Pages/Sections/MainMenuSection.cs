using SimpleAutomate.Core.Drivers;

namespace SimpleAutomate.SwagLabs.Tests.Pages.Sections
{
	public class MainMenuSection : PlaywrightDriver
	{
		private string MenuButton => "id=react-burger-menu-btn";
		private string AboutSidebarLink => "id=about_sidebar_link";
		private string InventorySidebarLink => "id=inventory_sidebar_link";

		public async Task OpenAboutPage()
		{
			await Page.ClickAsync(MenuButton);
			await Page.ClickAsync(AboutSidebarLink);
		}

		public async Task OpenInventoryPage()
		{
			await Page.ClickAsync(MenuButton);
			await Page.ClickAsync(InventorySidebarLink);
		}
	}
}

