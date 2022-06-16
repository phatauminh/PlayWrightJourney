using SimpleAutomate.SwagLabs.Tests.Hooks;
using SimpleAutomate.SwagLabs.Tests.Pages.Login;

namespace SimpleAutomate.SwagLabs.Tests.Tests
{
    public class LoginPageTests : InitializeHooks
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task Verify_Login_Success()
        {
            var page = new LoginPage();
            await page.OpenURL();
            await page.LoginSuccessfully("standard_user", "secret_sauce");
        }
    }
}

