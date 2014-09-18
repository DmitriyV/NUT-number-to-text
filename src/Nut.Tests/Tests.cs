namespace Nut.Tests
{
    using Constants;
    using NUnit.Framework;

    public class Tests
    {
        [Test]
        public void ChildNumIsDigit()
        {
            const decimal dec = 13.5m;
            Assert.AreEqual("тринадцать рублей пятьдесят копеек", dec.ToText(Currency.RUB, Language.Russian));
        }

        [Test]
        public void Test()
        {
            const decimal dec = 15.51m;
            Assert.AreEqual("пятнадцать рублей пятьдесят две копейки", dec.ToText(Currency.RUB, Language.Russian));
        }
    }
}