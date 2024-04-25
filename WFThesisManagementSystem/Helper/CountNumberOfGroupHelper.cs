using System.Linq;
using WFThesisManagementSystem.Models;
using WFThesisManagementSystem.Repositories;

namespace WFThesisManagementSystem.Helper
{
    public class CountNumberOfGroupHelper
    {   
        ThesisManagementContext _context;

        public CountNumberOfGroupHelper(ThesisManagementContext context)
        {
            _context = context;
        }
        public int CountNumberOfGroup(int groupId)
        {
            var studentRepository = new StudentRepository(_context);
            var students = studentRepository.GetAll().Where(x => x.group_id == groupId).ToList();
            return students.Count;
        }
    }
}
