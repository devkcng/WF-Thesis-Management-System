using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFThesisManagementSystem.Models
{
    internal class Task
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }

        public DateTime OpenDate { get; set; }
        public DateTime DueDate { get; set; }
        public int Id { get; set; }

        public Task() { }
        public Task(string name, string description, bool status, DateTime openDate, DateTime dueDate, int id)
        {
            Name = name;
            Description = description;
            Status = status;
            OpenDate = openDate;
            DueDate = dueDate;
            Id = id;
        }
    }
}
