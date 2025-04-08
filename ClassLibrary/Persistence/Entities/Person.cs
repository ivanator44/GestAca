using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestAca.Entities
{
    public abstract partial class Person
    {
        // atributos
        public string Address { get; set; }
        [Key] public string Id { get; set; }
        public string Name { get; set; }
        public int ZipCode { get; set; }

    }
}
