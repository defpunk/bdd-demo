using TechTalk.SpecFlow;
using BDD;
using FluentAssertions;


[Binding]
public sealed class GreeterStepDefinitions {

    private readonly ScenarioContext _scenarioContext;
    private  string _greeting;

    public GreeterStepDefinitions(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    [When(@"the greeter says hello")]
    public void greeterSaysHello()
    {
        Greeter greeter = new Greeter();
        _greeting = greeter.SayHello();
    }

    [Then(@"I should have heard ""(.*)""")]
    public void checkResponseIsExpected(string expected)
    {
         _greeting.Should().Be(expected);
    }
}