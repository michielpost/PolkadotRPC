using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolkadotRPC.Models
{
    public abstract class BaseRequest : IRPCAction
    {
        public BaseRequest(string method, string? id = null)
        {
            Id = id ?? "1";
            Method = method;
        }

        public string Id { get; }
        public string Jsonrpc { get; set; } = "2.0";

        public string Method { get; }
    }
}
