using Xunit;
using BDD;

namespace BDD.Tests
{
        //Junit test to make sure all is working
        public class GreeterTests
        {
                [Fact]
                public void SayHelloReturns_hello()
                {
                        Greeter greeter = new Greeter();
                        string result = greeter.SayHello();
                        Assert.Equal("hello", result);
                }
        }
}
