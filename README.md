[![.NET](https://img.shields.io/badge/--512BD4?logo=.net&logoColor=ffffff)](https://dotnet.microsoft.com/) [![Generic badge](https://img.shields.io/badge/Status-Under_Construction-red.svg)](https://shields.io/)
# Block Cypher
 A .net library application to wrap the [BlockCypher Explorer](https://live.blockcypher.com/) web service.
 
## How to use?
At first, you need an Api token from [BlockCypher](https://accounts.blockcypher.com/), Then in .Net:
```
Install-Package BlockCypher.Api
```

## Quick start
```
var blockCypher = new BlockCypherClient("YOUR_TOKEN");
var wallet = blockCypher.CreateAsync(); // Btc - mainnet
```
wallet => { PrivateKey, PublicKey, Address, Wif }
```
var addressInfo = await blockCypher.GetInfoByAddress(wallet.Address);
```
addressInfo => { Balance, TotalSent, TotalReceived, UnconfirmedBalance, TransactionHistory, UnconfirmedTransactionHistory }
