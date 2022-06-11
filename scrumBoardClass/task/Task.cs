using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scrumBoard.scrumBoardClass.task;

public class ScrumBoardTask
{
    public ScrumBoardTask(string name, string discription, TaskPriority priority)
    {
        Name = name;
        Description = discription;
        Priority = priority;
    }
    public string Name { get; set; }
    public string Description { get; set; }
    public void SetName(string name) { Name = name; }
    public void SetDescription(string description) { Description = description; }
    public TaskPriority Priority { get; set; }

}
