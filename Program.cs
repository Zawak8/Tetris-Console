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
            Console.WindowHeight = ConsoleRows + 1;
            Console.WindowWidth = ConsoleCols;
            Console.BufferHeight = ConsoleRows + 1;
            Console.BufferWidth = ConsoleCols;
            DrawBorder();

            Console.ReadKey();
            /*
            ┌─┬┐  ╔═╦╗  ╓─╥╖  ╒═╤╕
            │ ││  ║ ║║  ║ ║║  │ ││
            ├─┼┤  ╠═╬╣  ╟─╫╢  ╞═╪╡
            └─┴┘  ╚═╩╝  ╙─╨╜  ╘═╧╛
             */

        }
        static void DrawBorder()
        {
            string line = "╔";
            for (int i = 0; i < TetrisCols; i++)  //alternative: line += new string('═', TetrisCols);
            {
                line += "═";
            }

            line += "╦";
            for (int i = 0; i < InfoCols; i++)
            {
                line += "═";
            }

            line += "╗";
            Console.WriteLine(line);

            string middleLine = "║";
            middleLine += new string(' ', TetrisCols);
            middleLine += "║";
            middleLine += new string(' ', InfoCols);
            middleLine += "║";
            for (int i = 0; i < TetrisRows; i++)
            {
                Console.WriteLine(middleLine);
            }

            string bottomLine = "╚";
            bottomLine += new string('═', TetrisCols);
            bottomLine += "╩";
            bottomLine += new string('═', InfoCols);
            bottomLine += "╝";
            Console.WriteLine(bottomLine);
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
