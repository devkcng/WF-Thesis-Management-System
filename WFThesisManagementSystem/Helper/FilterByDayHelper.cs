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
        public List<Task> FilterByMonth()
        {
            DateTime startDay, endDay;
            List<Task> result = new List<Task>();
            DateTime today = DateTime.Today;
            startDay = new DateTime(today.Year, today.Month, 1); // Ngày đầu tiên của tháng
            endDay = startDay.AddMonths(1).AddDays(-1); // Ngày cuối cùng của tháng
            return FilterByDay(startDay, endDay);
        }
        public List<Task> FilterByWeek()
        { 
            DateTime startDay, endDay;
            List<Task> result = new List<Task>();
            DateTime today = DateTime.Today;
            int diff = (7 + (today.DayOfWeek - DayOfWeek.Monday)) % 7;
            startDay = today.AddDays(-1 * diff).Date;
            endDay = startDay.AddDays(6);
            return FilterByDay(startDay, endDay);
        }

        public List<Task> GetSortedTasks()
        {
                return _listTasks.OrderBy(x => x.submit_day.HasValue ? 1 : 0)  
                .ThenBy(x => x.due_date)                       // Sắp xếp các task theo thứ tự tăng dần của due_date
                .ToList();
        }

    }
}
