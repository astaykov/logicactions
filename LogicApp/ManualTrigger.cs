using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace LogicApp
{
    public class ManualTrigger
    {
        protected ManualTriggerConfiguration Configuration;
        public ManualTrigger(ManualTriggerConfiguration config)
        {
            Configuration = config;
        }

        public async void TriggerAction(string id, byte[] content)
        {
            WebClient clnt = new WebClient();
            dynamic webContent = new ExpandoObject();
            webContent.name = Configuration.TriggerName;
            webContent.outputs = new ExpandoObject();
            webContent.outputs.id = id;
            webContent.outputs.body = Convert.ToBase64String(content);
            string triggerOutputs = Newtonsoft.Json.JsonConvert.SerializeObject(webContent);
            clnt.Headers.Add(HttpRequestHeader.Authorization, Configuration.Authorization);
            clnt.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            var result = await clnt.UploadStringTaskAsync(new Uri(Configuration.Endpoint), triggerOutputs);
            System.Diagnostics.Debug.WriteLine(result);
        }
    }
}
