using Newtonsoft.Json;

namespace Miningcore.Blockchain.Dynex.StratumRequests;

public class DynexMallobRequest
{
    [JsonProperty("id")]
    public string WorkerId { get; set; }

    [JsonProperty("payload")]
    public string Payload { get; set; }
}
