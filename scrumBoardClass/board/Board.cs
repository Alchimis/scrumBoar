using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using scrumBoard.scrumBoardClass.board;
using scrumBoard.scrumBoardClass.task;
using scrumBoard.scrumBoardClass.column;

namespace ScrumBoardService
{
    internal class Board : IBoard
    {
        private const int SIZE_OF_BOARD = 10;
        public List<IColumn> Columns { get; set; } 
        public string Name { get; set; }
        public Board(string name) 
        { 
            Name = name;
            Columns = new List<IColumn>();
        }
        public void AddTask(IScrumBoardTask task,int index = 0) 
        {
            if (index > Columns.Count || index < 0) 
            {
                throw new ArgumentException("OUT_OF_RANGE");
            };
            this.Columns[index].AddTask(task);
            
        }
        public void AddColumn(IColumn column) 
        {
            if ((Columns.Count <= SIZE_OF_BOARD-1))
            {
                Columns.Add(column);
            }
            else 
            { 
                throw new ArgumentException("TO_BIG"); 
            }
        }
    }
    //доска состоит из подразделов которые состоят из прикреплённых к ним тасков
    // у таска есть название и содержание
    

}
