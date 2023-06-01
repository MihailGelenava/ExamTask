
namespace ExamTask.Utils
{
    public static class UiUtils
    {
        public static string CreateAuthorizationLink(string url,string login, string password)
        {
            return $"http://{login}:{password}@{url}";
        } 
    }
}
