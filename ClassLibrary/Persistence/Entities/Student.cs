using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestAca.Entities
{
    public partial class Student : Person 
    {
        // atributos
        public string IBAN { get; set; }

        // relaciones
        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}
