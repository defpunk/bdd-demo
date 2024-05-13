import Greeter from './greeter'

describe('greeter', () => {
    it('should say hello', () => {
        const greeter = new Greeter();
        expect(greeter.sayHello()).toBe('hello')
    })
})