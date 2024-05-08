using System.Linq;
using WFThesisManagementSystem.Models;

namespace WFThesisManagementSystem.Repositories
{
    //
    public class SubTaskRepository : IRepository<SubTask>
    {
        private ThesisManagementContext _context;
        public SubTaskRepository(ThesisManagementContext context)
        {
            _context = context;
        }

        public IQueryable<SubTask> GetAll()
        {
            return _context.SubTasks;
        }

        public IQueryable<SubTask> GetAllById(int id)
        {
            return _context.SubTasks.Where(x => x.subtask_id == id);
        }
        public SubTask GetById(int id)
        {
            return _context.SubTasks.FirstOrDefault(x => x.subtask_id == id);
        }

        public IQueryable<SubTask> GetAllByStudentId(int id)
        {
            return _context.SubTasks.Where(x => x.student_id == id);
        }
        public IQueryable<SubTask> GetAllByTaskId(int id)
        {
            return _context.SubTasks.Where(x => x.task_id == id);
        }
        public IQueryable<SubTask> GetAllByStudentIdAndTaskId(int studentID, int taskID)
        {
            return _context.SubTasks.Where(x => x.task_id == taskID && x.student_id == studentID);
        }
        public void Add(SubTask entity)
        {
            _context.SubTasks.Add(entity);
            _context.SaveChanges();

        }

        public void Update(SubTask entity)
        {
            _context.SubTasks.Attach(entity);
            _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(SubTask entity)
        {
            _context.SubTasks.Remove(entity);
            _context.SaveChanges();
        }

        public int GetNumberOfCompletedSubTaskOfStudents(int studentID)
        {
            return _context.SubTasks.Count(subTask => subTask.submit_day != null && subTask.student_id == studentID);
        }
        public int GetNumberOfUncompletedSubTaskOfStudents(int studentID)
        {
            return _context.SubTasks.Count(subTask => subTask.submit_day == null && subTask.student_id == studentID);
        }
        public int GetNumberOfLateSubmittedSubTasksOfStudents(int studentID)
        {
            return _context.SubTasks.Count(subTask => subTask.submit_day > subTask.due_date && subTask.student_id == studentID);
        }

    }
}
