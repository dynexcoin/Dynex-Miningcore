using Miningcore.Configuration;
using Newtonsoft.Json.Linq;

namespace Miningcore.Blockchain.Dynex.Configuration;

public class DynexPoolConfigExtra
{
    /// <summary>
    /// Blocktemplate stream published via ZMQ
    /// </summary>
    public ZmqPubSubEndpointConfig BtStream { get; set; }
    
    /// <summary>
    /// Dynex does not have a RPC method which returns on which network it is operating, so user can specify which one
    /// Defaults to `testnet` if not specified
    /// </summary>
    public string NetworkTypeOverride { get; set; } = null;
}
