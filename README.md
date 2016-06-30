# Cryptocurrency.Blockchain

[![Build](https://ci.appveyor.com/api/projects/status/y1rox466gbqe3j98?svg=true)](https://ci.appveyor.com/project/skthomasjr/cryptocurrency-blockchain)
[![Release](https://img.shields.io/github/release/skthomasjr/Cryptocurrency.Blockchain.svg?maxAge=2592000)](https://github.com/skthomasjr/Cryptocurrency.Blockchain/releases)
[![NuGet](https://img.shields.io/nuget/v/Cryptocurrency.Blockchain.svg)](https://www.nuget.org/packages/Cryptocurrency.Blockchain)
[![License](https://img.shields.io/github/license/skthomasjr/Cryptocurrency.Blockchain.svg?maxAge=2592000)](LICENSE.md)
[![Author](https://img.shields.io/badge/author-Scott%20K.%20Thomas%2C%20Jr.-blue.svg?maxAge=2592000)](https://www.linkedin.com/in/skthomasjr)
[![Join the chat at https://gitter.im/skthomasjr/Cryptocurrency.Blockchain](https://badges.gitter.im/skthomasjr/Cryptocurrency.Blockchain.svg)](https://gitter.im/skthomasjr/Cryptocurrency.Blockchain?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)

Cryptocurrency.Blockchain is a library for interacting with the Blockchain Data API provided by Blockchain. The [Blockchain Data API documentation](https://blockchain.info/api/blockchain_api) is provided by [Blockchain](https://blockchain.info).

See the [assembly help documentation](http://skthomasjr.github.io/Cryptocurrency.Blockchain/Site/Help/Index.html) for help on usage and code samples.

The API library is implemented using [NetClient.Rest](https://github.com/skthomasjr/NetClient.Rest) - an asynchronous REST API client that allows you to make API calls using LINQ syntax. Current API calls supported:

API Call | Supported
--- | :---:
Block Height | ✔
Mined Blocks | ✔
Inventory Data | ✔
Latest Block | ✔
Multiple Addresses | ✔
Single Address | ✔
Single Block | ✔
Single Transaction | ✔
Unconfirmed Transactions | ✔
Unspent Outputs | ✔

This API library allows interacting with the API service using LINQ query syntax or LINQ method syntax. Example of making an API call using LINQ query syntax:
```c#
var client = new BlockchainDataClient { OnError = ex => Console.WriteLine(ex.Message) };

var addresses = from a in client.Addresses where a.Base58 == "1A1zP1eP5QGefi2DMPTfTL5SLmv7DivfNa" select a;
var address = addresses.ToArray().SingleOrDefault();  // Actual HTTP call not made until we enumerate here.

Console.WriteLine(address?.Base58);
```
The came call using LINQ method syntax:
```c#
var client = new BlockchainDataClient { OnError = ex => Console.WriteLine(ex.Message) };

var address = client.Addresses
  .Where(a => a.Base58 == "1A1zP1eP5QGefi2DMPTfTL5SLmv7DivfNa")
  .ToArray().SingleOrDefault();

Console.WriteLine(address?.Base58);
```
