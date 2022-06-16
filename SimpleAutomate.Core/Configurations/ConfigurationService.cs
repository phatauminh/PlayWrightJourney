using System.Reflection;
using Microsoft.Extensions.Configuration;

namespace SimpleAutomate.Core.Configurations
{
    public static class ConfigurationService
    {
        private static readonly IConfigurationRoot Root = InitializeConfiguration();

        public static TestSettings GetTestSettings()
        {
            var result = Root.GetSection("TestSettings").Get<TestSettings>();

            if (result == null)
            {
                throw new ConfigurationNotFoundException(typeof(TestSettings).ToString());
            }

            return result;
        }


        private static IConfigurationRoot InitializeConfiguration()
        {
            var filesInExecutionDir = Directory.GetFiles(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            var settingsFile = filesInExecutionDir.FirstOrDefault(x => x.Contains("appsettings") && x.EndsWith(".json"));
            var builder = new ConfigurationBuilder();
            if (settingsFile != null)
            {
                builder.AddJsonFile(settingsFile, optional: true, reloadOnChange: true);
            }

            return builder.Build();
        }
    }
}
