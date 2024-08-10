namespace Tetris_Console
{
    internal class Program
    {
        static int TetrisRows = 20;
        static int TetrisCols = 10;
        static int InfoCols = 10;
        static int ConsoleRows = 1 + TetrisRows + 1;
        static int ConsoleCols = 1 + TetrisCols + 1 + InfoCols + 1;
        static void Main(string[] args)
        {
            Console.Title = "Tetris v1.0";
            Console.WindowHeight = ConsoleRows;
            Console.WindowWidth = ConsoleCols;
            Console.ReadKey();

        }

        static void Write(string text, int row, int col, ConsoleColor color = ConsoleColor.Yellow)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(col, row);
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
