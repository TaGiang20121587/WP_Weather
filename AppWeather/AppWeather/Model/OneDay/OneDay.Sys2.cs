﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TaGiang.OneDay
{

    internal partial class OneDay
    {
        internal class Sys2
        {

            [JsonProperty("message")]
            public double Message { get; set; }

            [JsonProperty("country")]
            public string Country { get; set; }

            [JsonProperty("sunrise")]
            public int Sunrise { get; set; }

            [JsonProperty("sunset")]
            public int Sunset { get; set; }
        }
    }

}