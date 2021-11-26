namespace BlockCypher.Api.Models
{
    public class AddressKeychain
    {
        public string PrivateKey { get; set; }
        public string PublicKey { get; set; }
        public string Address { get; set; }
        public string Wif { get; set; }
    }
}