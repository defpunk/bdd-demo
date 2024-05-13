import Greeter from "../../src/greeter";

const assert = require('assert')
const { When, Then } = require('@cucumber/cucumber')

let whatIHeard: string;

When('the greeter says hello', function () {
  const greeter = new Greeter();
  whatIHeard = greeter.sayHello()
});

Then('I should have heard {string}', function (expectedResponse: string) {
  assert.equal(whatIHeard, expectedResponse)
});