using BlockCypher.Api.Enums;
using BlockCypher.Api.Extension;
using BlockCypher.Api.Models;
using BlockCypher.Api.Modules.Address;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Service;
using System.Net;
using System.Text.Json;
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
        public async Task<AddressKeychain> CreateAsync(BlockCypherCoinType coin = BlockCypherCoinType.Bitcoin)
        {
            var response = await _restService.RequestAsync(_baseUrl + coin.ToDisplay() + "addrs", Method.POST);
            if (response.StatusCode == HttpStatusCode.OK)
                return JsonConvert.DeserializeObject<AddressKeychain>(response.Content);
            return default;
        }

        public async Task<BCAddressInfo> GetInfoByAddress(string address)
        {
            var result = new BCAddressInfo();
            var response = await _restService.RequestAsync(_baseUrl + address);
            if(response.StatusCode == HttpStatusCode.OK)
            {
                var deserializedResult = JsonSerializer.Deserialize<AddressInfoResult>(response.Content);
                result.Balance = deserializedResult.final_balance;
                result.UnconfirmedBalance = deserializedResult.unconfirmed_balance;
                result.TotalSent = deserializedResult.total_sent;
            }
            return result;
        }

        public async Task<object> GetAccountInfoAsync()
        {
            var response = await _restService.RequestAsync(_baseUrl + "tokens/" + _token);
            if(response.StatusCode == HttpStatusCode.OK)
                return JsonConvert.DeserializeObject<BCAccountInfo>(response.Content);
            return default;
        }
    }
}