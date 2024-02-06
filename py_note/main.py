class Node:
    def __init__(self, data):
        self.data = data
        self.next = None
    def insertAtBegin(self, data):
        new_node = Node(data)
        if self.head is None:
            self.head = new_node
            return
        else:
            new_node.next = self.head
            self.head = new_node
if __name__ == '__main__':
    x = Node(1)
    x.insertAtBegin(2)
    print(x)
