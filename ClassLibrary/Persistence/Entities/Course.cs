﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestAca.Entities
{
    public partial class Course
    {
        // atributos
        public string Description { get; set; }
        [Key] public string Name { get; set; }

        // relaciones
        public virtual ICollection<TaughtCourse> TaughtCourses { get; set; }

    }
}
