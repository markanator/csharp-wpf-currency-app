﻿using CurrencyLibs.US;

namespace CurrencyLibs.US
{
    public class DollarCoin : USCoin
    {
        public DollarCoin()
        {
            this.MonetaryValue = 1.0;
            this.Name = "DollarCoin";
        }

        public DollarCoin(USCoinMintMark cm)
        {
            this.MintMark = cm;
            this.MonetaryValue = 1.0;
            this.Name = "DollarCoin";
        }
    }
}