using LinkedListLab;
using System.Linq;

MyLinkedList<int> list = new MyLinkedList<int>();
list.AddLast(1);
list.AddLast(2);
list.AddLast(3);

list.RemoveFirst();

//list.Remove(2);

//RemoveKthNodeFromEnd(list, 2);

MyLinkedListNode<int> current = list.Head;
while (current != null)
{
    Console.WriteLine(current.Value);
    current = current.Next;
}
