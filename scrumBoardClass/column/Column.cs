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
            Tasks = new List<ITask>(); 
        }
        public string Name { get; set; }

        public void AddTask(ITask task) 
        {
            this.Tasks.Add(task);
        }
        public List<ITask> Tasks { get; set; }
    }
}
