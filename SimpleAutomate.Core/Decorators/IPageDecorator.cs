using Microsoft.Playwright;

namespace SimpleAutomate.Core.Decorators
{
	public interface IPageDecorator : IPage
	{
		Task ElementScreenshotAsync(string element, string imagePath);
	}
}

