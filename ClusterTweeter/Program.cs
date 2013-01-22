using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitterizer;

namespace ClusterTweeter
{
    class Program
    {
        static void Main(string[] args)
        {
            OAuthTokens tokens = new OAuthTokens();
            tokens.AccessToken = "XXX";
            tokens.AccessTokenSecret = "XXX";
            tokens.ConsumerKey = "XXX";
            tokens.ConsumerSecret = "XXX";

            TwitterResponse<TwitterStatus> tweetResponse = TwitterStatus.Update(tokens, "Hello, #Twitterizer");
            if (tweetResponse.Result == RequestResult.Success)
            {
                // Tweet posted successfully!
            }
            else
            {
                // Something bad happened
            }
        }
    }
}
