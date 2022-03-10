using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolkadotRPC.Models
{
    public class MethodsResult
    {
        public List<string> Methods { get; set; } = new();
        public int Version { get; set; }
    }
}
