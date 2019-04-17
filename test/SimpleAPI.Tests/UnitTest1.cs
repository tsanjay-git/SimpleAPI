using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Tests
{
    public class UnitTest1
    {
        
        [Fact]
        public void Test1()
        {

        }
        ValuesController Controller = new ValuesController();
        [Fact]
        public void GetReturnsMyName()
        {
            var returnValue = Controller.Get(1);
            Assert.Equal("Sanjay Kumar Tiwary", returnValue.Value);
        }
    }
}
