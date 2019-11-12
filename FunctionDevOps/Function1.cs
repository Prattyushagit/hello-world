using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using Newtonsoft.Json;

namespace FunctionDevOps
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static async Task<string> Run([HttpTrigger(AuthorizationLevel.Function, "get", Route = null)]HttpRequestMessage req, TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            // parse query parameter
            //string name = req.GetQueryNameValuePairs()
            //    .FirstOrDefault(q => string.Compare(q.Key, "name", true) == 0)
            //    .Value;

            //if (name == null)
            //{
            //    // Get request body
            //    dynamic data = await req.Content.ReadAsAsync<object>();
            //    name = data?.name;
            //}

            //return name == null
            //    ? req.CreateResponse(HttpStatusCode.BadRequest, "Please pass a name on the query string or in the request body")
            //    : req.CreateResponse(HttpStatusCode.OK, "Hello " + name);

            try
            {
                GitRepositoryManager gitRepositoryManager = new GitRepositoryManager("prattyusha.mandlik@gmail.com", "Prattyusha23!", @"https://github.com/Prattyushagit/hello-world", @"C:\Users\PrattyushaAshokMandl\Downloads\ExportedTemplate-Azure_Accel");

                gitRepositoryManager.CommitAllChanges("CheckinArmTemplate");

                //var personalaccesstoken = "6ua7i6gv4gjts6gzljf6ypkbonmf2atqeamp2alw4rpcohuxa7bq";
                //string responseBody = null;

                //using (HttpClient client = new HttpClient())
                //{
                //    client.DefaultRequestHeaders.Accept.Add(
                //        new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                //    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                //        Convert.ToBase64String(
                //            System.Text.ASCIIEncoding.ASCII.GetBytes(
                //                string.Format("{0}:{1}", "", personalaccesstoken))));

                //    using (HttpResponseMessage response = await client.GetAsync(
                //                "https://dev.azure.com/pmandli1/_apis/projects"))
                //    {
                //        response.EnsureSuccessStatusCode();
                //        responseBody = await response.Content.ReadAsStringAsync();
                //        log.Info("AzureDevOps Rest Api call successful.");
                //        dynamic json = JsonConvert.DeserializeObject(responseBody);
                //        return json.ToString();
                //    }
                //}

                return null;
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.ToString());

                return ex.ToString();
            }


        }
    }
}
