using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xuexi.Models;

namespace Xuexi.Util
{
    class GetAnswer
    {
        public List<ThisModel> Mydatas = new List<ThisModel>();
        public GetAnswer(BaseRequest baseRequest)
        {
            var client = new RestClient(baseRequest.RequestUrl);
            var request = new RestRequest(baseRequest.IsGetRequest?Method.GET:Method.POST);
            request.AddParameter(baseRequest.ContentType, baseRequest.Content, ParameterType.RequestBody);
            this.SendRequest(client, request);
        }

        internal void SendRequest(IRestClient client,IRestRequest request)
        {
            var response = client.Execute(request).Content;
            JObject jObject = (JObject)JsonConvert.DeserializeObject(response);
            if (jObject == null || jObject["data"].ToString() == "[]") return;
            foreach (var item in jObject["data"])
            {
                ThisModel study = JsonConvert.DeserializeObject<ThisModel>(item.ToString());
                Mydatas.Add(study);
            }
        }
    }
}
