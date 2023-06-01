
using Aquality.Selenium.Core.Configurations;
using Aquality.Selenium.Core.Utilities;

namespace ExamTask.Configurations
{
    public static class ApiConfiguration
    {
        private static ISettingsFile ApiConfigurationFile => new JsonSettingsFile("apiConfiguration.json");

        public static string BaseApiClientUrl => ApiConfigurationFile.GetValue<string>("base_url");
    }
}
