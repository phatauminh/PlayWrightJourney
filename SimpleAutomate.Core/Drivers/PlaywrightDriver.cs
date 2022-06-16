using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using SimpleAutomate.Core.Configurations;
using SimpleAutomate.Core.Decorators;

namespace SimpleAutomate.Core.Drivers
{
    public class PlaywrightDriver : PageTest
    {
        private static readonly TestSettings Configuration = ConfigurationService.GetTestSettings();

        public static IPageDecorator Page { get; set; }

        public static IBrowserContext BrowserContext { get; set; }

        protected bool IsScreenshotToggleOn => Configuration.PlaywrightSettings.ScreenshotSettings.IsToggleOn;

        protected string ScreenshotDirectory => Configuration.PlaywrightSettings.ScreenshotSettings.StoredDirectory;

        public BrowserTypeLaunchOptions ChromeOptions = new()
        {
            Headless = Configuration.PlaywrightSettings.Headless,
            SlowMo = Configuration.PlaywrightSettings.SlowMo
        };

        public BrowserTypeLaunchOptions FirefoxOptions = new()
        {
            Headless = Configuration.PlaywrightSettings.Headless,
            SlowMo = Configuration.PlaywrightSettings.SlowMo
        };

        public BrowserTypeLaunchOptions SafariOptions = new()
        {
            Headless = Configuration.PlaywrightSettings.Headless,
            SlowMo = Configuration.PlaywrightSettings.SlowMo
        };

        public async Task<IPageDecorator> InitalizePlaywright()
        {
            var browserType = Configuration.BrowserType;

            IBrowser browser = browserType.ToLower() switch
            {
                "chrome" => await Playwright.Chromium.LaunchAsync(ChromeOptions),
                "firefox" => await Playwright.Firefox.LaunchAsync(FirefoxOptions),
                "safari" => await Playwright.Firefox.LaunchAsync(FirefoxOptions),
                _ => throw new ArgumentException($"The parameter for 'Browser' is not correct, please provide Chrome, Firefox or Safari."),
            };

            BrowserNewContextOptions options = null;

            if (Configuration.PlaywrightSettings.RecordSettings.IsToggleOn)
            {
                options = new BrowserNewContextOptions
                {
                    RecordVideoDir = Configuration.PlaywrightSettings.RecordSettings.StoredDirectory,
                };
            }

            BrowserContext = await browser.NewContextAsync(options);

            var page = await BrowserContext.NewPageAsync();

            var pageDecorator = new PageDecorator(page);

            return pageDecorator;
        }

        public async Task OpenURL()
        {
            await Page.GotoAsync(Configuration.BaseUrl);
        }
    }

}

