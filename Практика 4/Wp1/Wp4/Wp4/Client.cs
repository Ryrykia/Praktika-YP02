using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wp4
{
    class Client
    {
        public string name;
        public string status;
        public int age;

        public Client(string name, string status, int age)
        {
            this.name = name;
            this.status = status;
            this.age = age;
        }

        public override string ToString()
        {
            return $"{name} {age} {status}";
        }


    }
}
