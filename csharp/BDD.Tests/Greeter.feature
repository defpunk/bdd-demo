Feature: Greeting

  Scenario: Say hello
    When the greeter says hello
    Then I should have heard "hello"
    And magic fairy dust is sprinkled