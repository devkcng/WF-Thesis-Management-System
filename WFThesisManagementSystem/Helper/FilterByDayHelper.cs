using System;
using System.Collections.Generic;
using System.Linq;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Repositories;

namespace WFThesisManagementSystem.Helper
{
    public class FilterByDayHelper
    {
        //this is logic for filtering tasks. Input of this method is a list of tasks, open day and close day
        private TaskRepository _taskRepository;
        private ThesisManagementContext _context;
        private List<Task> _listTasks;
        private List<SubTask> _listSubTasks;

        public FilterByDayHelper(List<Task> listTasks, ThesisManagementContext context)
        {
            _listTasks = listTasks;
            _context = context;
            _taskRepository = new TaskRepository(_context);
        }
        public FilterByDayHelper(List<SubTask> listSubTasks, ThesisManagementContext context)
        {
            _listSubTasks = listSubTasks;
            _context = context;
            _taskRepository = new TaskRepository(_context);
        }
        public List<Task> FilterTasksByDay(DateTime openDay, DateTime closeDay)
        {
            List<Task> result = new List<Task>();
            foreach (var task in _listTasks)
            {
                if (task.open_day >= openDay && task.open_day <= closeDay)
                {
                    result.Add(task);
                }
            }

            return GetSortedTasks(result);
        }
        public List<SubTask> FilterSubTasksByDay(DateTime openDay, DateTime closeDay)
        {
            List<SubTask> result = new List<SubTask>();
            foreach (var subTask in _listSubTasks)
            {
                if (subTask.open_day >= openDay && subTask.open_day <= closeDay)
                {
                    result.Add(subTask);
                }
            }

            return GetSortedSubTasks(result);
        }
        public List<Task> FilterTaskByMonth()
        {
            DateTime startDay, endDay;
            List<Task> result = new List<Task>();
            DateTime today = DateTime.Today;
            startDay = new DateTime(today.Year, today.Month, 1); // Ngày đầu tiên của tháng
            endDay = startDay.AddMonths(1).AddDays(-1); // Ngày cuối cùng của tháng
            return FilterTasksByDay(startDay, endDay);
        }
        public List<SubTask> FilterSubTaskByMonth()
        {
            DateTime startDay, endDay;
            List<Task> result = new List<Task>();
            DateTime today = DateTime.Today;
            startDay = new DateTime(today.Year, today.Month, 1); // Ngày đầu tiên của tháng
            endDay = startDay.AddMonths(1).AddDays(-1); // Ngày cuối cùng của tháng
            return FilterSubTasksByDay(startDay, endDay);
        }
        public List<Task> FilterTaskByWeek()
        {
            DateTime startDay, endDay;
            List<Task> result = new List<Task>();
            DateTime today = DateTime.Today;
            int diff = (7 + (today.DayOfWeek - DayOfWeek.Monday)) % 7;
            startDay = today.AddDays(-1 * diff).Date;
            endDay = startDay.AddDays(6);
            return FilterTasksByDay(startDay, endDay);
        }
        public List<SubTask> FilterSubTaskByWeek()
        {
            DateTime startDay, endDay;
            List<Task> result = new List<Task>();
            DateTime today = DateTime.Today;
            int diff = (7 + (today.DayOfWeek - DayOfWeek.Monday)) % 7;
            startDay = today.AddDays(-1 * diff).Date;
            endDay = startDay.AddDays(6);
            return FilterSubTasksByDay(startDay, endDay);
        }
        public List<Task> GetSortedTasks(List<Task> listTasks)
        {
            return listTasks.OrderBy(x => x.submit_day.HasValue ? 1 : 0)
            .ThenBy(x => x.due_date)                       // Sắp xếp các task theo thứ tự tăng dần của due_date
            .ToList();
        }
        public List<Task> GetSortedTasks()
        {
            return _listTasks.OrderBy(x => x.submit_day.HasValue ? 1 : 0)
            .ThenBy(x => x.due_date)                       // Sắp xếp các task theo thứ tự tăng dần của due_date
            .ToList();
        }
        public List<SubTask> GetSortedSubTasks(List<SubTask> listSubTasks)
        {
            return listSubTasks.OrderBy(x => x.submit_day.HasValue ? 1 : 0)
            .ThenBy(x => x.due_date)                       // Sắp xếp các task theo thứ tự tăng dần của due_date
            .ToList();
        }
        public List<SubTask> GetSortedSubTasks()
        {
            return _listSubTasks.OrderBy(x => x.submit_day.HasValue ? 1 : 0)
            .ThenBy(x => x.due_date)                       // Sắp xếp các task theo thứ tự tăng dần của due_date
            .ToList();
        }
    }
}
