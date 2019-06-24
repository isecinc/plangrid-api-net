
using System;
using Newtonsoft.Json;

namespace PlanGrid.Api
{
    public class IssueList : Record
    {
        [JsonProperty("uid")]
        public string uid { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("deleted")]
        public bool deleted { get; set; }

        [JsonProperty("project_uid")]
        public string project_uid { get; set; }
    }
}
