from behave import given, when, then, step
from example.greeting import Greeter


@when(u'the greeter says hello')
def step_impl(context):
    greeter = Greeter()
    message = greeter.sayHello()
    context.message = message

@then(u'I should have heard "{expected}"')
def step_impl(context, expected):
    assert context.message == expected