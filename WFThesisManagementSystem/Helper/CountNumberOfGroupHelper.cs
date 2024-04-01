﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Repositories;

namespace WFThesisManagementSystem.Helper
{
    public class CountNumberOfGroupHelper
    {
        public int CountNumberOfGroup(int groupId)
        {
            var context = new ThesisManagementContext();
            var studentRepository = new StudentRepository(context);
            var students = studentRepository.GetAll().Where(x => x.group_id == groupId).ToList();
            return students.Count;
        }
    }
}