This folder contains a very basic setup for running BDD tests using the Behave Framewoerk - see (https://behave.readthedocs.io/en/stable/index.html) for more details

To get this to work you'll need to create a virtual environment

Here are the commands to run in the terminal

1. python3 -m venv bdd-demo
2. source bdd-demo/bin/activate
3. python -m pip install behave
4. behave

If all is well you should see the output below

```
Feature: Greeting # features/greeting.feature:1

  Scenario: Say hello                # features/greeting.feature:3
    When the greeter says hello      # features/steps/greeting_steps.py:5 0.000s
    Then I should have heard "hello" # features/steps/greeting_steps.py:11 0.000s

1 feature passed, 0 failed, 0 skipped
1 scenario passed, 0 failed, 0 skipped
2 steps passed, 0 failed, 0 skipped, 0 undefined
Took 0m0.000s
```

Now you can start to add your own features and steps