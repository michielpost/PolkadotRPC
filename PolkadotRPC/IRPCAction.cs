using System;
using System.Collections.Generic;
using System.Text;

namespace PolkadotRPC
{
    public interface IRPCAction
    {
        string Method { get; }
    }
}
