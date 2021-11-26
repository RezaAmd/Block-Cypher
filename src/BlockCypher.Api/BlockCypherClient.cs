using BlockCypher.Api.Enums;
using BlockCypher.Api.Extension;
using BlockCypher.Api.Models;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Service;
using System.Net;
using System.Threading.Tasks;

namespace BlockCypher.Api
{
    public class BlockCypherClient
    {
        #region initialize
        private string _token { get; set; }
        private string _baseUrl = "https://api.blockcypher.com/";
        private readonly IRestService _restService = new RestService();
        // Get your token - https://accounts.blockcypher.com/tokens
        public BlockCypherClient(string token,
            BlockCypherVersion version = BlockCypherVersion.v1)
        {
            _token = token;
            _baseUrl = _baseUrl + version.ToDisplay();

        }
        #endregion

        public async Task<BCAddressKeychain> CreateAsync(BlockCypherCoinType coin = BlockCypherCoinType.Bitcoin)
        {
            var response = await _restService.RequestAsync(_baseUrl + coin.ToDisplay() + "addrs", Method.POST);
            if (response.StatusCode == HttpStatusCode.OK)
                return JsonConvert.DeserializeObject<BCAddressKeychain>(response.Content);
            return default;
        }

        public async Task<BCAddressInfo> GetInfoByAddress(string address, BlockCypherCoinType coin = BlockCypherCoinType.Bitcoin)
        {
            var response = await _restService.RequestAsync(_baseUrl + coin.ToDisplay() + "addrs/" + address);
            if (response.StatusCode == HttpStatusCode.OK)
                return JsonConvert.DeserializeObject<BCAddressInfo>(response.Content);
            return default;
        }


        public async Task<BCAccountInfo> GetAccountInfoAsync()
        {
            var response = await _restService.RequestAsync(_baseUrl + "tokens/" + _token);
            if (response.StatusCode == HttpStatusCode.OK)
                return JsonConvert.DeserializeObject<BCAccountInfo>(response.Content);
            return default;
        }
    }
}