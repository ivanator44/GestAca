using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestAca.Entities
{
    public abstract partial class Person
    {
        // constructores
        public Person()
        {
        }
        public Person(string address, string id, string name, int zipCode)
        {
            this.Address = address;
            this.Id = id;
            this.Name = name;
            this.ZipCode = zipCode;
        }
    }
}
