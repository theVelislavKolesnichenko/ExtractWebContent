using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ExtractWebContent.BLL
{
    public class GetStudentsFromTUVarna
    {
        private static readonly HttpClient client = new HttpClient();
        public async Task<string> GetContentAsync(string url, Dictionary<string, string> values) 
        {
            var content = new FormUrlEncodedContent(values);

            var response = await client.PostAsync(url, content);

            var responseString = await response.Content.ReadAsStringAsync();

            return responseString;
        }

        public string GetContent()
        {
            var task = MakeAsyncRequest("http://www.google.com", "text/html");
            return task.Result;
        }
        // Define other methods and classes here
        public static Task<string> MakeAsyncRequest(string url, string contentType)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.ContentType = contentType;
            request.Method = WebRequestMethods.Http.Get;
            request.Timeout = 20000;
            request.Proxy = null;

            Task<WebResponse> task = Task.Factory.FromAsync(
                request.BeginGetResponse,
                asyncResult => request.EndGetResponse(asyncResult),
                (object)null);

            return task.ContinueWith(t => ReadStreamFromResponse(t.Result));
        }

        private static string ReadStreamFromResponse(WebResponse response)
        {
            using (Stream responseStream = response.GetResponseStream())
            using (StreamReader sr = new StreamReader(responseStream))
            {
                //Need to return this response 
                string strContent = sr.ReadToEnd();
                return strContent;
            }
        }
    }
}
