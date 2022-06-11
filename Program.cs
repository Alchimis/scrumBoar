using scrumBoard.scrumBoardClass.task;
using scrumBoard.scrumBoardClass.column;


namespace ScrumBoardService
{
    class Program
    {
        public static int Main(string[] argvs)
        {

            ScrumBoardTask task = new ScrumBoardTask("Find Path", "someone lost their folder and YOU must find PATH", TaskPriority.Low);
            Column column = new Column("FOLDER");
            Board board = new Board("you_can_always_make_a_calculator_out_of_this");
            board.AddColumn(column);
            board.AddTask(task, 0);
            return 0;
        }
    }
}