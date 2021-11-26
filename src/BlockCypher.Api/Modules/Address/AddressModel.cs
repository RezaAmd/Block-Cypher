namespace BlockCypher.Api.Modules.Address
{
    internal class AddressKeychainResult
    {
        public string @private { get; set; }
        public string @public { get; set; }
        public string address { get; set; }
        public string wif { get; set; }
    }
    internal class AddressInfoResult
    {
        public long total_received { get; set; }
        public long total_sent { get; set; }
        public long balance { get; set; }
        public long unconfirmed_balance { get; set; }
        public long final_balance { get; set; }
        // Number of confirmed transactions on this address. Only transactions that have made it into a block (confirmations > 0) are counted.
        public long n_tx { get; set; }
        // Number of unconfirmed transactions for this address. Only unconfirmed transactions (confirmations == 0) are counted.
        public long unconfirmed_n_tx { get; set; }
        // Final number of transactions, including confirmed and unconfirmed transactions, for this address.
        public long final_n_tx { get; set; }
    }
}
