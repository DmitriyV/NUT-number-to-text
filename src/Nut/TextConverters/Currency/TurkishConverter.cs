﻿using Nut.Constants;
using Nut.Models;

namespace Nut.TextConverters 
{
    public sealed partial class TurkishConverter 
    {
        protected override CurrencyModel GetCurrencyModel(string currency) 
        {
            switch (currency) 
            {
                case Currency.EUR:
                    return new CurrencyModel 
                    {
                        Currency = currency,
                        Names = new[] { "avro", "avro" },
                        ChildCurrency = new BaseCurrencyModel { Names = new[] { "avro sent", "avro sent" } }
                    };
                case Currency.USD:
                    return new CurrencyModel 
                    {
                        Currency = currency,
                        Names = new[] { "dolar", "dolar" },
                        ChildCurrency = new BaseCurrencyModel { Names = new[] { "sent", "sent" } }
                    };
                case Currency.RUB:
                    return new CurrencyModel 
                    {
                        Currency = currency,
                        Names = new[] { "ruble", "ruble" },
                        ChildCurrency = new BaseCurrencyModel { Names = new[] { "kopek", "kopek" } }
                    };
                case Currency.TRY:
                    return new CurrencyModel 
                    {
                        Currency = currency,
                        Names = new[] { "türk lirası", "türk lirası" },
                        ChildCurrency = new BaseCurrencyModel { Names = new[] { "kuruş", "kuruş" } }
                    };
            }
            return null;
        }

    }
}
