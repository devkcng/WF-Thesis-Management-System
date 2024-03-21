using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WFThesisManagementSystem.Models
{
    internal class StudentGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }

        public int TopicID { get; set; }
        public float Point { get; set; }

        public StudentGroup() { }
        public StudentGroup(int id, string name, int size, float point)
        {
            Id = id;
            Name = name;
            Size = size;
            Point = point;
        }

    }
}
