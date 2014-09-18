namespace Nut.Tests
{
    using Constants;
    using NUnit.Framework;

    public class Tests
    {
        [Test]
        public void Test()
        {
            const decimal dec = 13.5m;
            Assert.AreEqual("тринадцать рублей пять копеек", dec.ToText(Currency.RUB, Language.Russian));
        }
    }
}