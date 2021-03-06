﻿namespace ETradeApiV1.Client.Models
{
   public class EtOAuthConfig
    {
        public string BaseUrl { get; set; }
        public string AuthorizeUrl { get; set; }
        public string ConsumerKey { get; set; }
        public string OauthToken { get; set; }
        public string ConsumerSecret { get; set; }
        public string OauthTokenSecret { get; set; }
        public string AccessToken { get; set; }
        public string AccessSecret { get; set; }
        public string TokenUrl { get; set; }
    }
}
