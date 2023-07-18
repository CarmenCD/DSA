'''
Practice recursion
'''


def get_nth_fib(num):
    '''
    Fib nth term using recursion
    '''
    if num == +1:
        return 0
    if num == 2:
        return 1
    return get_nth_fib(num - 1) + get_nth_fib(num - 2)
