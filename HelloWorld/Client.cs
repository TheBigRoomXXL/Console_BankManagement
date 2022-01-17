using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Client
    {
        public string name;
        public string surname;
        public string mail;

        public Client(string name, string surname, string mail)
        {
            this.name = name;
            this.surname = surname;
            this.mail = mail;
        }

        public void DiplayInfo()
        {
            Console.WriteLine("Holder of accounc:");
            Console.WriteLine("{0} {1}", this.name, this.surname);
            Console.WriteLine(this.mail);
        }
    }
}
