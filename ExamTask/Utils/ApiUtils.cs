
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using RestSharp;

namespace ExamTask.Utils
{
    public static class ApiUtils
    {
        public static T GetContent<T>(RestResponse response)
        {
            return JsonConvert.DeserializeObject<T>(response.Content);
        }

        public static JToken GetFieldFromResponse(RestResponse response, string fieldName)
        {
            JObject responseObj = JObject.Parse(response.Content);

            return responseObj[fieldName];
        }
    }
}
