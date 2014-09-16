using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoryQ.Test.Framework;

namespace StoryQ.Test
{
    partial class EqualsTest
    {
        [TestMethod]
        public void ValueTypesAreEqual()
        {
            var freddy = new SPerson("freddy");
            var lucy = new SPerson("lucy");
            Scenario
                .Given(ThereIsSPerson_, freddy)
                .And(ThereIsSPerson_, lucy)
                .When(SkipAssigment)
                .Then(ValuesAreEqual___, freddy, lucy, false)
                .Run();
        }


        [TestMethod]
        public void ValueTypesAreNotEqual()
        {
            var freddy = new SPerson("freddy");
            var lucy = new SPerson("freddy");
            Scenario
                .Given(ThereIsSPerson_, freddy)
                .And(ThereIsSPerson_, lucy)
                .When(SkipAssigment)
                .Then(ValuesAreEqual___, freddy, lucy, true)
                .Run();
        }


        private void ValuesAreEqual___(SPerson arg1, SPerson arg2, bool result)
        {
            arg1.Equals(arg2).Should().Be(result);
        }


        private void ThereIsSPerson_(SPerson structure)
        {
        }
    }
}
