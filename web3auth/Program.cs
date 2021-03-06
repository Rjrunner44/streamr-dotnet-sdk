using System;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
using System.Collections.Generic;
using Nethereum.Web3;
using Nethereum.Web3.Accounts;
using Nethereum.Util;
using System.Text;
using Nethereum.Signer;
using Nethereum.Hex.HexConvertors.Extensions;
using Nethereum.ABI.Encoders;
namespace ListStreams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Streamr!");
var _loginAPI = new LoginApi();
            var publicAddr = "your eth address goes here";
            var privateKey = "your private key goes here";
            try
            {
                // you can get your eth account also if you wanted:
                //var account = new Account(privateKey);
                //Console.WriteLine("Our account: " + account.Address);
// and also web3 is available if needed (we don't need it):
                //var web3 = new Web3(account, "your infura api url here");
Challenge challenge = _loginAPI.LoginChallengeAddressPost(publicAddr);
                ChallengeResponseChallenge c = new ChallengeResponseChallenge(challenge.Id, challenge._Challenge);
                var signer1 = new EthereumMessageSigner();
                var signature = signer1.EncodeUTF8AndSign(challenge._Challenge, new EthECKey(privateKey));
                ChallengeResponse response = new ChallengeResponse(c, signature, publicAddr);
SessionToken _sessionToken = _loginAPI.LoginResponsePost(response);
                Console.WriteLine("Login Ok: " + _sessionToken);
// Read the available streams:
                Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer " + _sessionToken.Token);
                Console.WriteLine("Reading Available Streams...");
var _streamsAPI = new StreamsApi();
                {
                    // List streams
                    List<Stream> result = _streamsAPI.StreamsGet(); // name, uiChannel, noConfig, search, sortBy, order, max, offset, grantedAccess, publicAccess, operation);
                    foreach (Stream s in result)
                    {
                        Console.WriteLine("Stream: Name='" + s.Name + "', Id='" + s.Id + "'");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception when calling StreamsApi.StreamsGet: " + e.Message);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling LoginApi.LoginPasswordPost: " + e.Message);
            }
        }
    }
}
