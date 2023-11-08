// Nicci Kellogg
// IT113
// NOTES: _head and current drove my brain crazy, but I got it working!
// BEHAVIORS NOT IMPLIMENTED AND WHY: I believe I implemented all the required behaviors.

namespace Kellogg_linkedList
{
	internal class Program
	{
		static void Main(string[] args)
		{
			LinkedList myList = new LinkedList();
			bool exit = false;
			Console.WriteLine("Welcome to List of Names\n");

			while (!exit)
			{
			    Console.WriteLine("\nMenu:");
				Console.WriteLine("1. Add a name");
				Console.WriteLine("2. Remove a name");
				Console.WriteLine("3. Search for a name");
				Console.WriteLine("4. Print the list of names");
				Console.WriteLine("5. Exit");
				Console.Write("Please enter which number you would like to choose from the menu: ");
				string choice = Console.ReadLine();

				if (choice == "1")
				{
					Console.WriteLine("Please enter the name you would like to add to List of Names: ");
					string addName = Console.ReadLine();
					myList.Add(addName);
				}

				else if (choice == "2")
				{
					Console.WriteLine("Please enter the name you would like to remove from List of Names: ");
					string removeName = Console.ReadLine();
					bool removed = myList.Remove(removeName);
					if (removed)
						Console.WriteLine("\n" + removeName + " has been removed from List of Names.");
					else
						Console.WriteLine("\nSorry, " + removeName + " cannot be found in List of Names.");
				}

				else if (choice == "3")
				{
					Console.WriteLine("Please enter the name you would like to search for in List of Names: ");
					string searchName = Console.ReadLine();
					if (myList.Contains(searchName) != null)
						Console.WriteLine("\n" + searchName + " has been found in List of Names.");
					else
						Console.WriteLine("\nSorry, " + searchName + " cannot be found in List of Names.");
				}

				else if (choice == "4")
				{
					Console.WriteLine("\nList of Names:");
					myList.PrintAllNodes();
				}

				else if (choice == "5")
					exit = true;

				else
					Console.WriteLine("\nInvalid choice, please try again.");

			}
		}
	}
}