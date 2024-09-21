using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class exercises
{
    [JsonProperty("name")]
    public string name { get; set; }

    [JsonProperty("force")]
    public string force { get; set; }

    [JsonProperty("level")]
    public string level { get; set; }

    [JsonProperty("mechanic")]
    public string mechanic { get; set; }

    [JsonProperty("equipment")]
    public string equipment { get; set; }

    [JsonProperty("instructions")]
    public string[] instructions { get; set; }

    [JsonProperty("muscle")]
    public string muscle { get; set; }

}

public class data
{
    [JsonProperty("count")]
    public int count { get; set; }

    [JsonProperty("exercises")]
    public exercises[] exercises { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
