using Aquality.Selenium.Core.Configurations;
using Aquality.Selenium.Core.Utilities;

namespace ExamTask.Configurations
{
    public static class TestConfiguration
    {
        private static ISettingsFile TestConfigurationFile => new JsonSettingsFile("testConfiguration.json");

        public static string Url => TestConfigurationFile.GetValue<string>("url");
        public static string Login => TestConfigurationFile.GetValue<string>("login");
        public static string Password => TestConfigurationFile.GetValue<string>("password");
    }
}
