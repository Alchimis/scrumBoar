using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using scrumBoard.scrumBoardClass.task;

namespace scrumBoard.scrumBoardClass.column
{
    internal interface IColumn
    {
        public string Name { get; set; }
        public void AddTask(ITask task) { }
        public List<ITask> Tasks { get; set; }
    }
}
