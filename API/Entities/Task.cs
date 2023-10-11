using System;
using System.Collections.Generic;

namespace API.Entities
{
    public class Task
    {
        public int Task_Id { get; set; }
        public string Task_title { get; set; }
        public string Task_desc { get; set; }
        public List<string> Assignee { get; set; } = new List<string>();
        public DateTime Duedate { get; set; }
        public task_status Status { get; set; } = task_status.ToDo;

    }
}
