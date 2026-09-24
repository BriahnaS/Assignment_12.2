// (#203)Given the head of a linked list and an integer val, remove all the nodes of the linked list that has Node.val == val, and return the new head.
using Assignment_12._2._1.Models;
using System.ComponentModel.DataAnnotations;

MyLinkedList list = new();
list.AddLast(1);
list.AddLast(2);
list.AddLast(6);
list.AddLast(3);
list.AddLast(4);
list.AddLast(5);
list.AddLast(6);

int val = 6;

// Test 2 
//int val = 1;

// Test 3
//list.AddLast(7);
//list.AddLast(7);
//list.AddLast(7);
//list.AddLast(7);

//int val = 7;

RemoveValue(ref list, val).PrintList();

// Go through list, find when current == val and remove it
// make current = Node.next and continue

static MyLinkedList RemoveValue(ref MyLinkedList list, int val)
{
    while (list.Head != null && list.Head.Data == val)
    {
        list.Head = list.Head.Next;
    }

    var current = list.Head;
    while (current != null && current.Next != null)
    {
        if (current.Next.Data == val)
        {
            current.Next = current.Next.Next;
        }
        else
        {
            current = current.Next;
        }
    }

    return list;
}
