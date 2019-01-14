using System;
using static System.Console;

namespace AttributesStudy
{
    class Program
    {
        static void Main(string[] args)
        {          

            Contact contact = new Contact
            {
                FirstName = "Jonathan",
                AgeInYears = 42
            };

            var contactWriter = new ContactConsoleWriter(contact);

            contactWriter.Write();

            var teste = "11988318668";
            Console.WriteLine(teste.Substring(0, 2));
            Console.WriteLine(teste.Substring(2));


            ReadLine();

        }
    }
}
