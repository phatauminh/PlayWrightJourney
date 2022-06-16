namespace SimpleAutomate.SwagLabs.Tests.Pages.Login
{
	public partial class LoginPage : BasePage
    {
        public async Task FillUserName(string userName) => await Page.FillAsync(UsernameField, userName);

        public async Task FillPassword(string password) => await Page.FillAsync(PasswordField, password);

        public async Task ClickLoginButton() => await Page.ClickAsync(LoginButton);

        public async Task LoginSuccessfully(string userName, string password)
        {
            await FillUserName(userName);
            await FillPassword(password);
            await ClickLoginButton();
            await AssertInventoryShouldBePresent();
            await ElementScreenshot(InventoryContainer);
        }
    }
}

