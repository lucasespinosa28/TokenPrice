﻿using Nethereum.Web3;
using TokenPrice.Core;
using Xunit;


namespace Chainlink
{
    public class GetRoundDataAsyncTest
    {
        [Fact]
        public void GetRoundDataAsync()
        {
            var price = new TokenPrice.Core.Chainlink.Oracle
            {
                Web3 = Connect.Web3("334274fca6ad64d523d9dee7c8e98d54d5cfc23f28eb4f811a8238f6fc13fd11", "")
            };
            var data = price.GetRoundDataAsync("0xDC530D9457755926550b59e8ECcdaE7624181557", "55340232221128658058").Result;
            Assert.NotNull(data);
            Assert.NotEqual(0, data.Answer);
            Assert.NotEqual(0, data.RoundId);
            Assert.NotEqual(0, data.UpdatedAt);
        }
    }
}
