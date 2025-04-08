using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestAca.Entities
{
    public partial class Classroom
    {
        // atributos
        public int MaxCapacity { get; set; }
        [Key] public string Name { get; set; }

        // relaciones
        public virtual ICollection<TaughtCourse> TaughtCourses { get; set; }

    }
}
