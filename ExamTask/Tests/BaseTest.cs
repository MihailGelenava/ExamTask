
using Aquality.Selenium.Browsers;

namespace ExamTask.Tests
{
    public abstract class BaseTest
    {

        [SetUp]
        public void Setup()
        {
            AqualityServices.Browser.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            AqualityServices.Browser.Quit();
        }

    }
}
