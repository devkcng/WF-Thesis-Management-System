using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFThesisManagementSystem.Models
{
    public class Topic
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        public string Category { get; set; }

        public string Technology { get; set; }

        public string Requirement { get; set; }

        public int MaxMember { get; set; }

        public Topic() { }
        public Topic(int id, string name,string description,string category,string technology,string requirement,int maxMember)
        {
            Id = id;
            Name = name;
            Description = description;
            Category = category;
            Technology = technology;
            Requirement = requirement;
            MaxMember = maxMember;
        }

        

    }
}
