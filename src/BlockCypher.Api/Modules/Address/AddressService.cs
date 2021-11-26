using BlockCypher.Api.Enums;
using BlockCypher.Api.Extension;
using BlockCypher.Api.Models;
using RestSharp;
using RestSharp.Service;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlockCypher.Api.Modules.Address
{
    public class AddressService
    {
        private string _baseUrl = "https://api.blockcypher.com/";
        private readonly IRestService _restService = new RestService();
        public AddressService(BlockCypherCoinType coin = BlockCypherCoinType.Bitcoin,
            BlockCypherVersion version = BlockCypherVersion.v1)
        {
            _baseUrl = _baseUrl + version.ToDisplay() + coin.ToDisplay();
        }
        public async Task<BCAddressKeychain> CreateAsync()
        {
            var response = await _restService.RequestAsync(_baseUrl + "addrs", Method.POST);
            if (response.StatusCode == HttpStatusCode.OK)
                return JsonSerializer.Deserialize<BCAddressKeychain>(response.Content);
            return default;
        }


    }
}