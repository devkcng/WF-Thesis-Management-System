using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Repositories;

namespace WFThesisManagementSystem.Helper
{
    public class FilterByDayHelper
    {
        //this is logic for filtering tasks. Input of this method is a list of tasks, open day and close day
        private TaskRepository _topicRepository;
        private ThesisManagementContext _context;
        private List<Task> _listTasks;
        public FilterByDayHelper(List<Task> listTasks, ThesisManagementContext context)
        {
            _listTasks = listTasks;
            _context = context;
            _topicRepository = new TaskRepository(_context);
        }

        public List<Task> FilterByDay(DateTime openDay, DateTime closeDay)
        {
            List<Task> result = new List<Task>();
            foreach (var task in _listTasks)
            {
                if (task.open_day >= openDay && task.open_day <= closeDay)
                {
                    result.Add(task);
                }
            }
            return result;
        }
    }
}
