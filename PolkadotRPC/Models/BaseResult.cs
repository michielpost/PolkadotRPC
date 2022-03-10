using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolkadotRPC.Models
{
    public class BaseResult<T>
    {
        public string Jsonrpc { get; set; } = default!;
        public T? Result { get; set; }
        public string Id { get; set; } = default!;
    }
}
