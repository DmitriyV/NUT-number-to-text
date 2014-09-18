namespace Nut.Tests
{
    using System;
    using Constants;
    using NUnit.Framework;

    public class Tests
    {
        [Test]
        public void Test()
        {
            var dec = new decimal(13.5);
            Console.WriteLine(dec.ToText(Currency.RUB, Language.Russian));
        }
    }
}