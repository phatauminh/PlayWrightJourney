using SimpleAutomate.Core.Drivers;
using SimpleAutomate.SwagLabs.Tests.Pages.Sections;

namespace SimpleAutomate.SwagLabs.Tests.Pages
{
	public class BasePage : PlaywrightDriver
	{
        protected BasePage()
        {
            MainMenuSection = new MainMenuSection();
            CartInfoSection = new CartInfoSection();
        }

        public MainMenuSection MainMenuSection { get; }
        public CartInfoSection CartInfoSection { get; }

        public async Task ElementScreenshot(string element)
        {
            if (IsScreenshotToggleOn)
                await Page.ElementScreenshotAsync(element, $"{ScreenshotDirectory}/{TestContext.CurrentContext.Test.Name}-{DateTime.Now.Ticks}.png");
        }
    }
}

