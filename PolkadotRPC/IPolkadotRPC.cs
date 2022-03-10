using PolkadotRPC.Models;
using RestEase;
using System;
using System.Collections.Generic;
using System.Text;

namespace PolkadotRPC
{
    public interface IPolkadotRPC
    {
        [Post("")]
        Task<BaseResult<MethodsResult>> Methods([Body] MethodsRequest req);
    }
}
