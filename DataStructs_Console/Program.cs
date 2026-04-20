using LinkedListLab;
using MyArrayLib;
using System.Linq;

MyLinkedList<int> list = new MyLinkedList<int>();
list.AddFirst(3);
list.AddLast(1);
list.AddLast(1);
list.AddLast(1);
list.AddLast(3);
list.AddLast(3);
list.AddLast(3);
list.AddLast(5);
list.AddLast(5);

Console.WriteLine($"The count of list is: {list.Count}");
//list.AddLast(7);
//list.AddLast(9);

//list.RemoveFirst();
//list.RemoveLast();

//list.Remove(7);

//RemoveKthNodeFromEnd(list, 2);

//MyLinkedListNode<int> current = list.Head;
//while (current != null)
//{
//    Console.WriteLine(current.Value);
//    current = current.Next;
//}

// 2. RemoveKthNodeFromEnd

//MyLinkedList<int> newList = list.RemoveKthNodeFromEnd(list, 1);
//Console.WriteLine(newList);
//MyLinkedList<int> newList = list.DeleteDuplicates(list);

//foreach (var node in list)
//    Console.WriteLine(node);

MyArray<int> element1 = new MyArray<int>(3);

for (int i = 0; i < element1.Length; i++)
{
    Console.WriteLine(element1[i]);
}
