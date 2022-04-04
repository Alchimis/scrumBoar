using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using scrumBoard.scrumBoardClass.task;
using scrumBoard.scrumBoardClass.column;


namespace scrumBoard.scrumBoardClass.board
{
    internal interface IBoard
    {

       private const int SIZE_OF_BOARD = 10;
       public List<IColumn> Columns { get; set; } 
       public void AddTask(ITask task,int index = 0) { }
       public void AddColumn(IColumn column) { }
       public string Name { get; set; }

    }
}
