using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFThesisManagementSystem.Models
{
    public class Student : Person
    {
        public Student() { }

        public Student(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }
    }
}
