using System.ComponentModel;

var myList = new List.LinkedList();

//var first = new List.Node(1, null);
//var second = new List.Node(2, null);
//var third = new List.Node(3, null);

//var first2 = new List.Node(11, null);
//var second2 = new List.Node(12, null);
//var third2 = new List.Node(13, null);


myList.Add(1);
myList.Add(2);
myList.Add(3);

myList.Add(11, 0);
myList.Add(12, 2);
myList.Add(13, 5);


myList.Display();


namespace List
{
    public class Node
    {
        public int Value { get; set; }

        public Node? _next;
        public Node? Next { get { return _next; } set { _next = value; } }

        public Node(int value, Node next)
        {
            Value = value;
            Next = next;
        }
    }

    public class LinkedList
    {
        private Node? head;
        private Node? Head { get { return head; } set { head = value; } }

        private int count;
        public int Count { get { return count; } }
        

        public void Add(int val)
        {
            Node node = new Node(val, null);
            if (node != null)
            {
                if (head == null) 
                { 
                    head = node;
                    count++;
                }
                else
                {
                    var currentNode = head;
                    while (currentNode.Next != null)
                    {
                        currentNode = currentNode.Next;
                    }
                    currentNode.Next = node;
                    count++;
                }
            }
        }

        public void Add(int val, int index)
        {
            Node node = new Node(val, null);
            if (index < 0 || index > count || node == null) return;
            if(index == 0)
            {
                if (head == null)
                {
                    head = node;
                    count++;
                }
                else
                {
                    var secondNode = head;
                    head = node;
                    head.Next = secondNode;
                    count++;
                }
            }
            else
            {
                var i = 1;
                Node currentNode = head;
                while (i < index)
                {
                    currentNode = currentNode.Next;
                    i++;
                }
                var temp = currentNode.Next;
                currentNode.Next = node;
                node.Next = temp;
                count++;
            }
        }

        public void Display()
        {
            if (head == null) return;

            var currentNode = head;
            while (currentNode.Next != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Next;
            }
            Console.WriteLine(currentNode.Value);
        }

    }
}
