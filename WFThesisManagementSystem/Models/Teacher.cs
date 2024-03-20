using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFThesisManagementSystem.Models
{
    public class Teacher : Person
    {
        public Teacher(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }

        public Teacher()
        {

        }
    }
}
