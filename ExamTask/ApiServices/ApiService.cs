using AngleSharp;
using ExamTask.Configurations;
using ExamTask.Models;
using ExamTask.Utils;
using RestSharp;
using RestSharp.Authenticators;

namespace ExamTask.ApiServices
{
    public static class ApiService
    {
        private static readonly RestClient apiClient = new RestClient(ApiConfiguration.BaseApiClientUrl);

        public static string GetVariantToken(int variant)
        {
            RestRequest request = new RestRequest("/token/get");
            request.AddParameter("variant", variant);
            var response = apiClient.Post(request);
            return response.Content.ToString();
        }

        public static List<TestTableRowModel> GetListOfTestsByProject(int projectId)
        {
            RestRequest request = new RestRequest("/test/get/json");
            request.AddParameter("projectId", projectId);
            var response = apiClient.Post(request);
            List < TestTableRowModel > tests = new List < TestTableRowModel >();
            try
            {
                tests = ApiUtils.GetContent<List<TestTableRowModel>>(response);
            } 
            catch(Exception e)
            {
            }
            return tests;
        }

        public static void PushTokenIntoCookies(string token)
        {
            var newClient = new RestClient("http://login:password@localhost:8080/web");
            RestRequest request = new RestRequest("");
            request.AddHeader("Cookie", $"token={token};");
            //request.AddCookie("token", token, "http://login:password@localhost:8080", "/web");
            var response = newClient.Get(request);
            Console.WriteLine( response.Content.ToString());
        }
    }
}
