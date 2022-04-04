using scrumBoard.scrumBoardClass.board;
using scrumBoard.scrumBoardClass.task;
using scrumBoard.scrumBoardClass.column;


namespace ScrumBoardService
{
    class Program
    {
        public static int Main(string[] argvs) 
        {
            
            IScrumBoardTask task = new ScrumBoardTask("Find Path","someone lost their folder and YOU must find PATH",TaskPriority.HIGH);
            IColumn column = new Column("FOLDER");
            IBoard board = new Board("you_can_always_make_a_calculator_out_of_this");
            board.AddColumn(column);
            board.AddTask(task,0);
            //board.AddTask(task, 10);
            return 0;
        }
    }
}