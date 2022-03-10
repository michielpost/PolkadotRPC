using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolkadotRPC.Models
{
    public class MethodsRequest : BaseRequest
    {
        public MethodsRequest() : base("rpc_methods") { }
    }
}
