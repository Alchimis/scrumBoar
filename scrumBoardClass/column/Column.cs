using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using scrumBoard.scrumBoardClass.task;

namespace scrumBoard.scrumBoardClass.column
{
    internal class Column : IColumn
    {
        public Column(string name) 
        {
            Name = name;
            Tasks = new List<IScrumBoardTask>(); 
        }
        public string Name { get; set; }

        public void AddTask(IScrumBoardTask task) 
        {
            this.Tasks.Add(task);
        }
        public List<IScrumBoardTask> Tasks { get; set; }
    }
}
