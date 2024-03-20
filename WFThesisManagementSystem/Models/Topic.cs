using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFThesisManagementSystem.Models
{
    public class Topic
    {
        private string id;
        private string name;
        private string description;
        private string category;
        private string technology;
        private string requirement;
        private string number;
        public Topic() { }
        public Topic(string id, string name,string description,string category,string technology,string requirement,string number)
        {
            Id = id;
            Name = name;
            Description = description;
            Category = category;
            Technology = technology;
            Requirement = requirement;
            Number = number;
        }

        public string Id
        {
            get { return id; }
            set
            {
                id = value;
            }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string Category
        {
            get { return category; }
            set
            {
                category = value;
            }

        }
        public string Technology
        {
            get { return technology; }
            set { technology = value; }
        }
        public string Requirement
        {
            get { return requirement; }
            set
            {
                requirement = value;
            }
        }
        public string Number
        {
            get { return number; }
            set
            {
                number = value;
            }
        }

    }
}
