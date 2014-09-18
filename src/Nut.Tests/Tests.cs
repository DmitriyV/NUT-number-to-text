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
        public void Test1()
        {
            const decimal dec = 15.51m;
            Assert.AreEqual("пятнадцать рублей пятьдесят одна копейка", dec.ToText(Currency.RUB, Language.Russian));
        }

        [Test]
        public void Test2()
        {
            const decimal dec = 15.52m;
            Assert.AreEqual("пятнадцать рублей пятьдесят две копейки", dec.ToText(Currency.RUB, Language.Russian));
        }

        [Test]
        public void Test3()
        {
            const decimal dec = 12.13m;
            Assert.AreEqual("двенадцать рублей тринадцать копеек", dec.ToText(Currency.RUB, Language.Russian));
        }

        [Test]
        public void Test4()
        {
            const decimal dec = 2.02m;
            Assert.AreEqual("два рубля две копейки", dec.ToText(Currency.RUB, Language.Russian));
        }
    }
}