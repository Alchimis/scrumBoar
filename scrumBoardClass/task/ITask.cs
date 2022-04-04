using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scrumBoard.scrumBoardClass.task
{
    public interface ITask
    {
        public string Name { get; set; }    
        public string Description { get; set; }
        
        public TaskPriority Priority { get; set; }  
    }
}
