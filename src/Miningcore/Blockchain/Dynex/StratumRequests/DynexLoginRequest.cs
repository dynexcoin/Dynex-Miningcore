using Newtonsoft.Json;

namespace Miningcore.Blockchain.Dynex.StratumRequests;

public class DynexLoginRequest
{
    [JsonProperty("login")]
    public string Login { get; set; }

    [JsonProperty("pass")]
    public string Password { get; set; }

    [JsonProperty("agent")]
    public string UserAgent { get; set; }

    [JsonProperty("mallob_id")]
    public string MallobId { get; set; }

    [JsonProperty("algo")]
    public string Algo { get; set; }
}