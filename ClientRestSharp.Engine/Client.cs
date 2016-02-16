using System.Runtime.InteropServices;
using RestSharp;

namespace ClientRestSharp.Engine
{
    public class Client
    {
        private readonly string _baseAddress;

        public Client(string add)
        {
            _baseAddress = add;
        }

        public string Send()
        {
            var client = new RestClient(_baseAddress);
            // client.Authenticator = new HttpBasicAuthenticator(username, password);

            var request = new RestRequest("/", Method.GET);
            //request.AddParameter("name", "value"); // adds to POST or URL querystring based on Method
            //request.AddUrlSegment("id", "123"); // replaces matching token in request.Resource

            // easily add HTTP Headers
            request.AddHeader("header", "value");

            IRestResponse response = client.Execute(request);
            return response.Content;
        }
    }
}
