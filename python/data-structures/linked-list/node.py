'''
node for singly linked list
'''


class Node:
    '''
    next - reference to the next node
    '''

    def __init__(self, value=0):
        self.value = value
        self.next = None
