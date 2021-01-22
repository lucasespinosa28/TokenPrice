﻿using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace TokenPrice.Core.Chainlink
{
    public partial class Models
    {
        [Function("latestRoundData")]
        public class LatestRoundData : FunctionMessage { }
    }
}