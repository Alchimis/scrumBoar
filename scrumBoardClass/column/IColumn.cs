﻿using System;
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
        public void AddTask(IScrumBoardTask task) { }
        public List<IScrumBoardTask> Tasks { get; set; }
    }
}
