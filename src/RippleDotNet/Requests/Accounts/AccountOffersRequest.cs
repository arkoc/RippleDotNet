﻿using Newtonsoft.Json;

namespace RippleDotNet.Requests.Accounts
{
    public class AccountOffersRequest : LedgerRequest
    {
        public AccountOffersRequest(int requestId, string account) : base(requestId)
        {
            Account = account;
            Command = "account_offers";
        }

        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("marker")]
        public object Marker { get; set; }
    }
}