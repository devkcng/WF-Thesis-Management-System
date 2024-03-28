using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WFThesisManagementSystem.Models;

namespace WFThesisManagementSystem.DataAccess
{
    internal class TaskDAO
    {
        public bool CheckData(Task task)
        {
            if (task.Name=="" || task.Description == "" || Convert.ToString(task.Id) == "" || task.OpenDate.Date.ToString() == "" || task.DueDate.Date.ToString() == "" ) return false;
            for(int i=0;i< Convert.ToString(task.Id).Length;i++)
            {
                if (Convert.ToString(task.Id)[i] <'0' || Convert.ToString(task.Id)[i] >'9') return false;
            }    
            return true;
        }
        public string AddTask(Task task)
        {
            return string.Format("INSERT INTO Tasks (task_id , task_name, task_description, open_day,due_date,status) " +
                                 "VALUES ('{0}', '{1}' ,'{2}','{3}','{4}')",
                                            task.Id, task.Name, task.Description,task.OpenDate.Date.ToString(),task.DueDate.Date.ToString(),false);
        }
        public string DeleteTask(Task task)
        {
            return string.Format("DELETE FROM Topics WHERE task_id = '{0}'", task.Id);
        }
        public string UpdateTask(Task task)
        {
            return string.Format("UPDATE Topics SET task_name = '{0}', task_description ='{1}', open_day = '{2}',due_date = '{3},status = '{4}' WHERE task_id = '{5}' ",
                                    task.Name, task.Description, task.OpenDate.Date, task.OpenDate.Date.ToString(), task.DueDate.Date.ToString(), task.Status.ToString(), task.Id);
        }
    }
}
