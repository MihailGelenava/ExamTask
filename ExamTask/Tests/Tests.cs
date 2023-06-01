using Aquality.Selenium.Browsers;
using ExamTask.ApiServices;
using ExamTask.Configurations;
using ExamTask.Forms.Pages;
using ExamTask.Utils;

namespace ExamTask.Tests
{
    public class Tests : BaseTest
    {
        private ProjectsPage projectsPage => new ProjectsPage();

        [Test]
        public void TC0001_AddProjectAndTest()
        {
            var variantToken = ApiService.GetVariantToken(2);

            Assert.That(variantToken, Is.Not.Empty, "Variant token wasn't generated");

            AqualityServices.Browser.GoTo(UiUtils.CreateAuthorizationLink(TestConfiguration.Url,TestConfiguration.Login,TestConfiguration.Password));
            AqualityServices.Browser.WaitForPageToLoad();
           
            //ApiService.PushTokenIntoCookies(variantToken);

            AqualityServices.Browser.Refresh();

            Assert.That(projectsPage.State.IsDisplayed, "Projects page wasn't opened");

            projectsPage.OpenProjectByName("Nexage");

            ApiService.GetListOfTestsByProject(6);

            Thread.Sleep(3000);
        }
    }
}