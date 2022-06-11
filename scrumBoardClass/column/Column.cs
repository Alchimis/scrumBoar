using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using scrumBoard.scrumBoardClass.task;

namespace scrumBoard.scrumBoardClass.column;

public class Column
{
    public Column(string name)
    {
        Name = name;
        Tasks = new List<ScrumBoardTask>();
    }
    public string Name { get; set; }

    public void AddTask(ScrumBoardTask task)
    {
        this.Tasks.Add(task);
    }
    public List<ScrumBoardTask> Tasks { get; set; }
}
