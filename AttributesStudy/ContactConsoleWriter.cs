using System;
using static System.Console;

namespace AttributesStudy
{
    public class ContactConsoleWriter
    {
        private readonly Contact _contact;
        public ContactConsoleWriter(Contact contact)
        {
            _contact = contact;
        }
        [Obsolete("This will be removed in next version")]
        public void Write() {
            WriteFirstName();
            WriteFirstAge();
        }

        private void WriteFirstAge()
        {
            WriteLine(_contact.FirstName);
        }

        private void WriteFirstName()
        {
            WriteLine(_contact.AgeInYears);
        }
    }
}
