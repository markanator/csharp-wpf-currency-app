﻿namespace CurrencyLibs.Interfaces
{
    public interface IBankNote : ICurrency
    {
        public int Year { get; }
    }
}