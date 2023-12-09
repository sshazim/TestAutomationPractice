﻿using Newtonsoft.Json;

namespace TestAutomationPractice.src.API.Requests
{
    public class LoginRequest
    {
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }
    }
}
