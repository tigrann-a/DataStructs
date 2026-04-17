using LinkedListLab;
using System.Linq;

MyLinkedList<int> list = new MyLinkedList<int>();
list.AddLast(1);
//list.AddLast(3);
//list.AddLast(5);
list.AddLast(7);
list.AddLast(9);

//list.RemoveFirst();

list.Remove(9);

//RemoveKthNodeFromEnd(list, 2);

//MyLinkedListNode<int> current = list.Head;
//while (current != null)
//{
//    Console.WriteLine(current.Value);
//    current = current.Next;
//}

foreach (var node in list)
    Console.WriteLine(node);
