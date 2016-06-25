# Cryptocurrency.Blockchain

[![Build](https://ci.appveyor.com/api/projects/status/y1rox466gbqe3j98?svg=true)](https://ci.appveyor.com/project/skthomasjr/cryptocurrency-blockchain)
[![Release](https://img.shields.io/github/release/skthomasjr/Cryptocurrency.Blockchain.svg?maxAge=2592000)](https://github.com/skthomasjr/Cryptocurrency.Blockchain/releases)
[![NuGet](https://img.shields.io/nuget/v/Cryptocurrency.Blockchain.svg)](https://www.nuget.org/packages/Cryptocurrency.Blockchain)
[![License](https://img.shields.io/github/license/skthomasjr/Cryptocurrency.Blockchain.svg?maxAge=2592000)](LICENSE.md)
[![Author](https://img.shields.io/badge/author-Scott%20K.%20Thomas%2C%20Jr.-blue.svg?maxAge=2592000)](https://www.linkedin.com/in/skthomasjr)
[![Join the chat at https://gitter.im/skthomasjr/Cryptocurrency.Blockchain](https://badges.gitter.im/skthomasjr/Cryptocurrency.Blockchain.svg)](https://gitter.im/skthomasjr/Cryptocurrency.Blockchain?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)

Cryptocurrency.Blockchain is a library for interacting with the Blockchain Data API provided by Blockchain.info. The [Blockchain Data API documentation](https://blockchain.info/api/blockchain_api) is provided by [Blockchain.info](https://blockchain.info).

The API library is implemented using NetClient.Rest - a generic & asyncronous REST API client that allows you to make API calls using LINQ syntax. Current API call support:

API Call | Supported
--- | :---:
Block Height | soon
Blocks | soon
Inventory Data | soon
Latest Block | ✔
Multiple Addresses | soon
Single Address | ✔
Single Block | ✔
Single Transaction | ✔
Unconfirmed Transactions | soon
Unspent Outputs | soon

```c#
  var client = new BlockchainDataClient { OnError = ex => Console.WriteLine(ex.Message) };
  
  var addresses = from a in client.Addresses where a.Base58 == "1FW8KHjgtPTngKLHAw4YALtWoENsRpjt33" select a;
  var address = addresses.ToArray().SingleOrDefault();
  
  Console.WriteLine(address?.Base58);
```
