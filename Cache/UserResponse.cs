﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cache
{
    public class UserResponse
    {
        [JsonProperty("page")]
        public int Page { get; set; }
        [JsonProperty("per_page")]
        public int PerPage { get; set; }
        [JsonProperty("total")]
        public int Total { get; set; }
        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }
        [JsonProperty("data")]
        public List<User> Data { get; set; }
    }
}
