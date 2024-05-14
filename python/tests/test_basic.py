import unittest
from example.greeting import Greeter

class Testing(unittest.TestCase):

    def test_boolean(self):
        g = Greeter()
        self.assertEqual(g.sayHello(), "hello")

if __name__ == '__main__':
    unittest.main()