namespace BlockCypher.Api.Models
{
    public class BCAddressInfo
    {
        public long Balance { get; set; }
        public long UnconfirmedBalance { get; set; }
        public long TotalReceived { get; set; }
        public long TotalSent { get; set; }
    }
}