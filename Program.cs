using System;

namespace composition_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Author newAuthor = new Author("William Grace", 'm', "wjgrace@crimson.ua.edu");
            Console.WriteLine(newAuthor.ToString());

            Book newBook = new Book("122430", "My Book, your Book", newAuthor);
            System.Console.WriteLine(newBook.ToString());

            Book yourBook = new Book("4321", "The Phantom Book", new Author ("Jamie", 'f', "jamie@ua.edu"));
            System.Console.WriteLine(yourBook.ToString());
            yourBook.GetAuthor().SetEmail("jamie@crimson.ua.edu");
            System.Console.WriteLine(yourBook.ToString());
        }
    }
}
