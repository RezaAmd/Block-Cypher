using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BlockCypher.Api.Models
{
    public class BCAddressInfo
    {
        [JsonProperty("final_balance")]
        public long Balance { get; set; }

        [JsonProperty("unconfirmed_balance")]
        public long UnconfirmedBalance { get; set; }

        [JsonProperty("total_received")]
        public long TotalReceived { get; set; }

        [JsonProperty("total_sent")]
        public long TotalSent { get; set; }

        [JsonProperty("txrefs")]
        public List<TransactionHistoryRefBC> TransactionHistory { get; set; }


        [JsonProperty("unconfirmed_n_tx")]
        public int UnconfirmedTransaction { get; set; }
        [JsonProperty("unconfirmed_txrefs")]
        public List<TransactionHistoryRefBC> UnconfirmedTransactionHistory { get; set; }
    }

    public class TransactionHistoryRefBC
    {
        [JsonProperty("tx_hash")]
        public string Hash { get; set; }
        [JsonProperty("block_height")]
        public string BlockHeight { get; set; }
        [JsonProperty("value")]
        public string Amount { get; set; }

        [JsonProperty("confirmations")]
        public long Confirmations { get; set; }

        [JsonProperty("confirmed")]
        public DateTime DateTime { get; set; }

        [JsonProperty("spent")]
        public bool Spent { get; set; }
    }
}