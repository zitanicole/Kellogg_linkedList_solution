using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kellogg_linkedList
{
	internal class LinkedList
	{
		private Node? _head;
		public LinkedList() 
		{ 
			_head = null;
		}

 		public void Add(string item)
		{
			Node newNode = new Node(item);
			Node current = _head; 

			if (_head == null || string.Compare(item.ToLower(), _head.Data.ToLower()) <= 0)
			{
				newNode.Next = current;
				_head = newNode;
			}
			else
			{
				while (current.Next != null && string.Compare(item.ToLower(), current.Next.Data.ToLower()) > 0)
				{
					current = current.Next;	
				}
				newNode.Next = current.Next;
				current.Next = newNode;
			}
		}

		public Node Contains(string item)
		{
			Node current = _head;
			while (current != null)
			{
				if (current.Data.ToLower() == item.ToLower())
				{
					return current;
				}
				current = current.Next;	
			}
			return null;
		}

		public bool Remove(string item) 
		{
			Node current = _head;
			if (current == null)
			{
				return false;
			}
			if (current.Data.ToLower() == item.ToLower())
			{
				current= current.Next;
				return true;
			}
			while ( current != null)
			{
				if (current.Next.Data.ToLower() == item.ToLower())
				{
					current.Next = current.Next.Next;
					return true;
				}
				current = current.Next;
			}
			return false;
		}

		public void PrintAllNodes()
		{
			Console.WriteLine("\n");
			Node current = _head;
			while (current != null)
			{
				Console.WriteLine(current.Data);
				current = current.Next;
			}
			Console.WriteLine("\n\n");
		}
	}
}
