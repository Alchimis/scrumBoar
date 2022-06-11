using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using scrumBoard.scrumBoardClass.task;
using scrumBoard.scrumBoardClass.column;

namespace ScrumBoardService
{
    public class Board
    {
        private const int SizeOfBoard = 10;
        public List<Column> Columns { get; set; }
        public string Name { get; set; }
        public Board(string name)
        {
            Name = name;
            Columns = new List<Column>();
        }
        public void AddTask(ScrumBoardTask task, int index = 0)
        {
            if (index > Columns.Count || index < 0)
            {
                throw new ArgumentException("OUT_OF_RANGE");
            };
            this.Columns[index].AddTask(task);

        }
        public void AddColumn(Column column)
        {
            if ((Columns.Count <= SizeOfBoard - 1))
            {
                Columns.Add(column);
            }
            else
            {
                throw new ArgumentException("TO_BIG");
            }
        }
        public bool DeleteColumnByName(string Name)
        {
            foreach (Column col in Columns)
            {
                if (col.Name == Name)
                {
                    Columns.Remove(col);
                    return true;
                }
            }
            return false;
        }
        public ScrumBoardTask? GetTaskByName(string Name)
        {
            foreach (Column column in Columns)
            {
                foreach (ScrumBoardTask boardTask in column.Tasks)
                {
                    if (boardTask.Name == Name)
                    {
                        return boardTask;
                    }
                }
            }
            return null;
        }
        public ScrumBoardTask? GetTask(ScrumBoardTask task)
        {
            foreach (Column column in Columns)
            {
                foreach (ScrumBoardTask boardTask in column.Tasks)
                {
                    if (boardTask == task)
                    {
                        return boardTask;
                    }
                }
            }
            return null;
        }
        public ScrumBoardTask? GetTask(ScrumBoardTask task, int from)
        {

            if (from > Columns.Count || from < 0)
            {
                throw new ArgumentException("OUT_OF_RANGE");
            };

            foreach (ScrumBoardTask boardTask in Columns[from].Tasks)
            {
                if (boardTask == task)
                {
                    return boardTask;
                }
            }

            return null;
        }
        public bool DeleateTaskByName(string Name)
        {
            foreach (Column column in Columns)
            {
                foreach (ScrumBoardTask boardTask in column.Tasks)
                {
                    if (boardTask.Name == Name)
                    {
                        column.Tasks.Remove(boardTask);
                        return true;
                    }
                }
            }
            return false;
        }
        public bool DeleteTask(ScrumBoardTask task)
        {
            foreach (Column column in Columns)
            {
                foreach (ScrumBoardTask boardTask in column.Tasks)
                {
                    if (boardTask == task)
                    {
                        column.Tasks.Remove(boardTask);
                        return true;
                    }
                }
            }
            return false;
        }
        public bool MoveTask(ScrumBoardTask task, int from, int to)
        {
            if (from > Columns.Count || from < 0)
            {
                throw new ArgumentException("OUT_OF_RANGE");
            };
            if (to > Columns.Count || to < 0)
            {
                throw new ArgumentException("OUT_OF_RANGE");
            };
            ScrumBoardTask? getedTask = GetTask(task, from);
            if (getedTask == null)
            {
                return false;
            }
            AddTask(getedTask, to);
            return true;

        }
    }
}
