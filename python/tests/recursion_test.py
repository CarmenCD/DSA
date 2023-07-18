'''
recursion module unit test
'''

import unittest
# import sys  # added!
# sys.path.append("..")  # add
# ed!
from practice import recursion


class TestMain(unittest.TestCase):

    def test_fib_fitst_term(self):
        '''
        test_fib_fitst_term test fib 1
        '''
        test_num = 1
        res = recursion.get_nth_fib(test_num)
        self.assertEqual(res, 0)

    def test_fib_second_term(self):
        test_num = 2
        res = recursion.get_nth_fib(test_num)
        self.assertEqual(res, 1)

    def test_fib_nth_term(self):
        test_num = 6
        res = recursion.get_nth_fib(test_num)
        self.assertEqual(res, 5)


if __name__ == '__main__':
    unittest.main()
