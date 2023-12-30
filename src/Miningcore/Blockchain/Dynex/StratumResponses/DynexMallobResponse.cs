using Newtonsoft.Json;

namespace Miningcore.Blockchain.Dynex.StratumResponses;

public class DynexMallobParams
{
    [JsonProperty("payload")]
    public string Payload { get; set; }
}

public class DynexMallobResponse
{
    public string Id { get; set; } = "1";
    public DynexMallobParams Mallob { get; set; }
}
