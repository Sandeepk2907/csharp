using System;
using System.Collections.Generic;
using System.Linq;

class Book
{
    public int Id;
    public string Name;
    public Book(int id, string name) { Id = id; Name = name; }
    public override string ToString() => $"ID:{Id}, Name:{Name}";
}

class Program
{
    static void Main()
    {
        List<Book> books = new List<Book>();
        while (true)
        {
            Console.WriteLine("\n 1.Add 2.Display 3.Search 4.Remove 5.Count 6.Exit");
            Console.Write("Enter Choice: ");
            if (!int.TryParse(Console.ReadLine(), out int ch)) continue;
            switch (ch)
            {
                case 1:
                    Console.Write("ID: "); int id = int.Parse(Console.ReadLine());
                    Console.Write("Name: "); string name = Console.ReadLine();
                    books.Add(new Book(id, name));
                    Console.WriteLine("Book Added");
                    break;

                case 2:
                    if (books.Count == 0)
                    {
                        Console.WriteLine("No books.");
                        break;
                    }
                    books.ForEach(s => Console.WriteLine(s));
                    break;

                case 3:
                    Console.Write("Search ID: ");
                    int sid = int.Parse(Console.ReadLine());
                    var s1 = books.FirstOrDefault(s => s.Id == sid);
                    Console.WriteLine(s1 != null ? s1 : "Not found");
                    break;

                case 4:
                    Console.Write("Remove ID: ");
                    int rid = int.Parse(Console.ReadLine());
                    books.RemoveAll(s => s.Id == rid);
                    Console.WriteLine("Removed (if existed).");
                    break;

                case 5:
                    Console.WriteLine($"Total Books:{books.Count}");
                    break;
                case 6:
                    return;
            }
        }
    }
}