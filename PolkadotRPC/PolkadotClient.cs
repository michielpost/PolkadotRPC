using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RestEase;
using System;
using System.Collections.Generic;
using System.Text;

namespace PolkadotRPC
{
    public class PolkadotClient
    {
        public static IPolkadotRPC GetClient(string baseUrl)
        {
            var polkadotApi = new RestClient(baseUrl)
            {

                JsonSerializerSettings = new JsonSerializerSettings()
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver(),
                    NullValueHandling = NullValueHandling.Ignore
                }
            }.For<IPolkadotRPC>();
            return polkadotApi;
        }
    }
}
