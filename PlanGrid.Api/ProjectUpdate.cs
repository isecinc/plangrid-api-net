﻿// <copyright file="ProjectUpdate.cs" company="PlanGrid, Inc.">
//     Copyright (c) 2016 PlanGrid, Inc. All rights reserved.
// </copyright>
using Newtonsoft.Json;

namespace PlanGrid.Api
{
    public class ProjectUpdate
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
