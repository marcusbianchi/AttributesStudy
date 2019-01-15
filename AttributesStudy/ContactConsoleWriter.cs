using System;
using System.Diagnostics;
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

        //[Obsolete("This will be removed in next version",true)]
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
            OutputDebugInfo();
            OutputDebugExtra();
            WriteLine(_contact.AgeInYears);
        }

        [Conditional("EXTRA")]
        private void OutputDebugExtra()
        {
            WriteLine("****EXTRA INFO****");
        }

        [Conditional("DEBUG")]
        private void OutputDebugInfo()
        {
            WriteLine("****DEBUG MODE****");
        }
    }
}
