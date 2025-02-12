namespace LinkedListTutorial;

class Node(int value)
{
    public int Data = value;
    public Node? Next;
}

class LinkedList
{
    public Node? Head;

    public void Append(int value)
    {
        Node newNode = new Node(value);
        if (Head == null)
        {
            Head = newNode;
            return;
        }

        Node current = Head;

        while (current.Next != null)
        {
            current = current.Next;
        }

        current.Next = newNode;
    }

    public void Prepend(int value)
    {
        Node newNode = new Node(value);
        newNode.Next = Head;
        Head = newNode;
    }

    public void Delete(int value)
    {
        if (Head == null) return;

        if (Head.Data == value)
        {
            Head = Head.Next;
            return;
        }

        Node current = Head;

        while (current.Next != null && current.Next.Data != value)
        {
            current = current.Next;
        }

        if (current.Next != null)
        {
            current.Next = current.Next.Next;
        }
    }

    public void PrintList()
    {
        Node? current = Head;
        while (current != null)
        {
            Console.WriteLine(current.Data + " -> ");
            current = current.Next;
        }
        Console.WriteLine("null");
    }
}

class Program
{
    static void Main()
    {
        LinkedList list = new LinkedList();
        list.Append(1);
        list.Append(2);
        list.Append(3);
        list.Prepend(0);
        list.PrintList();  // Output: 0 -> 1 -> 2 -> 3 -> null

        list.Delete(2);
        list.PrintList();  // Output: 0 -> 1 -> 3 -> null
    }
}

// Homework for Session 2

// Create your own LinkedList

// Reverse a Singly Linked List
// Example:
// Input:  1 -> 2 -> 3 -> 4 -> null
// Output: 4 -> 3 -> 2 -> 1 -> null

// Detect a Cycle in a Linked List (Floyd’s Algorithm)
// Example:
// Input:  1 -> 2 -> 3 -> 4 -> 2 (Cycle exists)
// Output: True
