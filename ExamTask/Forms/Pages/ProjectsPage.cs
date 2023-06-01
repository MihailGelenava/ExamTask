
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace ExamTask.Forms.Pages
{
    public class ProjectsPage : Form
    {
        public ProjectsPage() : base(By.ClassName("panel-heading"), "Projects list page"){}

        public void OpenProjectByName(string name) => ElementFactory.Get<ILink>(By.XPath($"//div[@class='list-group']/a[text()='{name}']"),$"{name} project link").Click();
    }
}
