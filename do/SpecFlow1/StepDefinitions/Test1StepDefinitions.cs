using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlow1.StepDefinitions
{
    [Binding]
    public class Test1StepDefinitions
    {

        public int Param1;
        public int Param2;
        public int Result;

        [Given(@"the first number es (.*)")]
        public void GivenTheFirstNumberEs(int p0)
        {
            Param1 = p0;
        }

        [Given(@"the second number es (.*)")]
        public void GivenTheSecondNumberEs(int p0)
        {
            Param2 = p0;
        }

        [When(@"the two numbers son added")]
        public void WhenTheTwoNumbersSonAdded()
        {
            Result = Param1 + Param2;
        }

        [Then(@"the result should es (.*)")]
        public void ThenTheResultShouldEs(int p0)
        {
           
            Assert.AreEqual(p0, Result);

        }
    }
}
