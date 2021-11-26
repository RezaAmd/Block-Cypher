using System.ComponentModel.DataAnnotations;

namespace BlockCypher.Api.Enums
{
    public enum BlockCypherCoinType
    {
        [Display(Name = "btc/main/")]
        Bitcoin,
        [Display(Name = "btc/test3/")]
        BitcoinTestnet3,
        [Display(Name = "dash/main/")]
        Dash,
        [Display(Name = "doge/main/")]
        Dogecoin,
        [Display(Name = "ltc/main/")]
        Litecoin,
        [Display(Name = "bcy/test/")]
        BlockCypher
    }
}
