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
            ReadLine();

        }
    }
}
