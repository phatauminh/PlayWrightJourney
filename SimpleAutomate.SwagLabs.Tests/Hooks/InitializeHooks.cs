using SimpleAutomate.Core.Drivers;

namespace SimpleAutomate.SwagLabs.Tests.Hooks
{
	public class InitializeHooks : PlaywrightDriver
	{
		[SetUp]
		public async Task SetUp()
		{
			Page = await InitalizePlaywright();
		}

		[TearDown]
		public async Task TearDown()
		{
			await BrowserContext.CloseAsync();
		}
	}
}

