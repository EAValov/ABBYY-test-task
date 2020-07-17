using System;

class Program
{
	/// <summary>
	/// Инвертировать односвязный список за линейное время и
	/// константную дополнительную память.
	/// </summary>
	static void Main(string[] args)
	{
		LinkedList<char> list = new LinkedList<char>();

		list.Add('A');
		list.Add('B');
		list.Add('C');

		list.PrintList();
		list.Reverse();
		list.PrintList();
	}

	class LinkedList<T>
	{
		Node head;

		class Node
		{
			public T data;
			public Node next;

			public Node(T _data)
			{
				data = _data;
				next = null;
			}
		}

		public void Add(T data)
		{
			if (head == null)
				head = new Node(data);
			else
			{
				Node temp = head;

				while (temp.next != null)
					temp = temp.next;

				temp.next = new Node(data);
			}
		}

		public void Reverse()
		{
			Node prev = null;
			Node current = head;
			Node next = null;

			while (current != null)
			{
				next = current.next;
				current.next = prev;
				prev = current;
				current = next;
			}

			head = prev;
		}

		public void PrintList()
		{
			Node current = head;
			
			while (current != null)
			{
				Console.Write(current.data.ToString() + " ");
				current = current.next;
			}
			
			Console.WriteLine();
		}
	}
}


