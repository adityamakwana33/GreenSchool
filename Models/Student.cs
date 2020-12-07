using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GreenSchool.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public string StudentType { get; set; }
        public string StudentAge { get; set; }
        public Professor Professor { get; set; }
        [ForeignKey("Professor")]
        public int ProfessorFK { get; set; }

    }
}
