using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoryQ.Test.Framework;

namespace StoryQ.Test
{
    [TestClass]
    public partial class EqualsTest : StoryQSpecBase
    {
        private Person _freddy;
        private Person _lucy;

        public EqualsTest()
        {
            MyFeature = new Story("Test Object.Equls Method ")
                    .InOrderTo("Test simulates behavior of Object Equal for Instances and Structures")
                    .AsA("User")
                    .IWant("");

            _freddy = new Person("Freddy");
            _lucy = new Person("Lucy");
        }



        [TestMethod]
        public void ReferenceEquals()
        {            
            Scenario
                .Given(ThereIsAPerson_, _freddy)
                .And(ThereIsAPerson_, _lucy)
                .When(AssignFisrtPersonToSecond__,_lucy, _freddy)
                .Then(ObjectsAreReferenceEqual_,true)
                .Run();
        }


       [TestMethod]
        public void ReferenceNotEaquals()
        {       
            Scenario
                .Given(ThereIsAPerson_, new Person("Freddy"))
                .And(ThereIsAPerson_, new Person("Lucy"))
                .When(SkipAssigment)
                .Then(ObjectsAreReferenceEqual_, false)
                .Run();
        }
        

        private void ThereIsAPerson_(Person obj)
        {            
        }


        private void ObjectsAreReferenceEqual_( bool result)
        {
            _freddy.Equals(_lucy).Should().Be(result);
        }


        private void AssignFisrtPersonToSecond__(Person arg1, Person arg2)
        {
            _freddy = _lucy;
        }

        private void SkipAssigment()
        {            
        }
    }
}
