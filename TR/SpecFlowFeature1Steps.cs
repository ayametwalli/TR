using System;
using TechTalk.SpecFlow;
using Xunit;

namespace TR
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        int f, s, u;
        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int p0)
        {
            f = p0;
        }
        
        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int p0)
        {
            s = p0;
        }
        
        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            u = f + s;
         
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            var actual = u;
            var expected = p0;
            Assert.Equal(actual, expected);
        }
    }
}
