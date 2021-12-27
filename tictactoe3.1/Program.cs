using System;

namespace tictactoe3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("╔═══╦═══╦═══╗");
            Console.WriteLine("║ 0 ║ 1 ║ 2 ║");
            Console.WriteLine("╠═══╬═══╬═══╣");
            Console.WriteLine("║ 3 ║ 4 ║ 5 ║");
            Console.WriteLine("╠═══╬═══╬═══╣");
            Console.WriteLine("║ 6 ║ 7 ║ 8 ║");
            Console.WriteLine("╚═══╩═══╩═══╝");
            */
            char[] numbers = { '0','1','2', 
                               '3','4','5', 
                               '6','7','8'};
            //drawBoard(numbers);
            char[] playingBoard = { ' ','_',' ',
                               '_',' ','_',
                               ' ','_',' '};
            Console.WriteLine("Welcome to Tic-Tac-Toe");
            drawBoard(numbers);
            int i = 0;
            bool notwin = true;
            char move = ' ';
            while (notwin)
            {
                
                if (i % 2 == 0)
                {
                    Console.WriteLine("Player X move");
                    move = 'X';
                }
                else {
                    Console.WriteLine("Player O move");
                    move = 'O';
                }
                if (handleInput(playingBoard, move)) {
                    i++;
                }
                drawBoard(playingBoard);
                drawBoard(numbers);

                if (i > 2) {
                    if (checkWin(playingBoard)) {
                        Console.WriteLine("Player " + move + " Won!");
                        break;
                    }
                }
                if (i >= 8)
                {
                    Console.WriteLine("Neither player win! ");
                    break;
                }
                
            }
            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();



        }
        static bool checkWin(char[] board) {
            //0 1 2
            if ((board[0] == board[1]) && (board[1] == board[2]) && (board[0] == board[2])) {
                // Console.WriteLine("DEBUG Win condition 0");
                return true;
            }
            //3 4 5
            if ((board[3] == board[4]) && (board[5] == board[4]) && (board[5] == board[3]))
            {
                //Console.WriteLine("Win condition 1");
                return true;
            }
            //6 7 8
            if ( (board[6] == board[7]) && (board[8] == board[7]) && (board[8] == board[6]) )
            {
                //Console.WriteLine("Win condition 2");
                return true;
            }
            //0 3 6
            if ((board[0] == board[3]) && (board[6] == board[3] && (board[6] == board[0])))
            {
                //Console.WriteLine("Win condition 3");
                return true;
            }
            //1 4 7
            if ((board[1] == board[4]) && (board[7] == board[4]) && (board[7] == board[1]))
            {
               // Console.WriteLine("Win condition 4");
                return true;
            }
            // 2 5 8
            if ((board[2] == board[5]) && (board[8] == board[5] && (board[2] == board[5])))
            {
               // Console.WriteLine("Win condition 5");
                return true;
            }
            //0 4 8
            if ((board[0] == board[4]) && (board[8] == board[4]) && (board[8] == board[0]))
            {
               // Console.WriteLine("Win condition 6");
                return true;
            }
            //6 4 2
            if ((board[6] == board[4]) && (board[2] == board[4]) && (board[2] == board[6]))
            {
               // Console.WriteLine("Win condition 7");
                return true;
            }
            return false;
        }
        static bool handleInput(char[] board, char xorO) {
            
                Console.WriteLine("Type a coordinate to set");
                if (xorO != 'X' && xorO != 'O')
                {
                    Console.WriteLine("Invalid board marker set! line 99 code");
                    return false;
                }
                String s = Console.ReadLine();
                int s0 = 0;
                while (!Int32.TryParse(s,out s0)) {
                    Console.WriteLine("Valid input: 0-8. You inputtted: " + s);
                    s = Console.ReadLine();
            }
                

                switch (s0)
                {
                    case 0:
                        if (!(board[0].Equals('X') || board[0].Equals('O')))
                            board[0] = xorO;
                        else
                        {
                            Console.WriteLine("Position " + s0 + " already set before!");
                            return false;
                        }
                        break;
                    case 1:
                        if (!(board[1].Equals('X') || board[1].Equals('O')))
                            board[1] = xorO;
                        else
                        {
                            Console.WriteLine("Position " + s0 + " already set before!");
                            return false;
                        }
                        break;
                    case 2:
                        if (!(board[2].Equals('X') || board[2].Equals('O')))
                            board[2] = xorO;
                        else
                        {
                            Console.WriteLine("Position " + s0 + " already set before!");
                            return false;
                        }
                        break;
                    case 3:
                        if (!(board[3].Equals('X') || board[3].Equals('O')))
                            board[3] = xorO;
                        else
                        {
                            Console.WriteLine("Position " + s0 + " already set before!");
                            return false;
                        }
                        break;
                    case 4:
                        if (!(board[4].Equals('X') || board[4].Equals('O')))
                            board[4] = xorO;
                        else
                        {
                            Console.WriteLine("Position " + s0 + " already set before!");
                            return false;
                        }
                        break;
                    case 5:
                        if (!(board[5].Equals('X') || board[5].Equals('O')))
                            board[5] = xorO;
                        else
                        {
                            Console.WriteLine("Position " + s0 + " already set before!");
                            return false;
                        }
                        break;
                    case 6:
                        if (!(board[6].Equals('X') || board[6].Equals('O')))
                            board[6] = xorO;
                        else
                        {
                            Console.WriteLine("Position " + s0 + " already set before!");
                            return false;
                        }
                        break;
                    case 7:
                        if (!(board[7].Equals('X') || board[7].Equals('O')))
                            board[7] = xorO;
                        else
                        {
                            Console.WriteLine("Position " + s0 + " already set before!");
                            return false;
                        }
                        break;
                    case 8:
                        if (!(board[8].Equals('X') || board[8].Equals('O')))
                            board[8] = xorO;
                        else
                        {
                            Console.WriteLine("Position " + s0 + " already set before!");
                            return false;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid coordinate. You inputted: " + s);
                        return false;


                }
                return true;
            
        }
        static void drawBoard(char[] gameState) {
            //Console.SetCursorPosition(0, Console.CursorTop);
            String sboard = "╔═══╦═══╦═══╗\n" + "║ _ ║ _ ║ _ ║\n" + "╠═══╬═══╬═══╣\n" + "║ _ ║ _ ║ _ ║\n" + "╠═══╬═══╬═══╣\n" + "║ _ ║ _ ║ _ ║\n" + "╚═══╩═══╩═══╝\n";
            Char[] board = sboard.ToCharArray();

            String sboard2 = "╔═══╦═══╦═══╗\n" + "║ _ ║ _ ║ _ ║\n" + "╠═══╬═══╬═══╣\n" + "║ _ ║ _ ║ _ ║\n" + "╠═══╬═══╬═══╣\n" + "║ _ ║ _ ║ _ ║\n" + "╚═══╩═══╩═══╝\n";
            Char[] board2 = sboard.ToCharArray();
            string line = "╔═══╦═══╦═══╗";
            int lineSize = line.Length;
            // Console.WriteLine(lineSize);
            //16 20 24
            //44 48 52
            //72 76 80
            
            /*board[3+lineSize] = gameState[0];
            board[7+lineSize] = gameState[1];
            board[11+lineSize] = gameState[2];
            board[5 + lineSize*3] = gameState[3];
            board[9 + lineSize*3] = gameState[4];
            board[13 + lineSize*3] = gameState[5];
            board[7 + lineSize*5] = gameState[6];
            board[11 + lineSize*5] = gameState[7];
            board[15 + lineSize*5] = gameState[8];*/
            board[16] = gameState[0];
            board[20] = gameState[1];
            board[24] = gameState[2];
            board[44] = gameState[3];
            board[48] = gameState[4];
            board[52] = gameState[5];
            board[72] = gameState[6];
            board[76] = gameState[7];
            board[80] = gameState[8];
            foreach (char c in board)
            {
                
                Console.Write(c);
            }
            
        }
        static void drawBoard()
        {
            String sboard = "╔═══╦═══╦═══╗\n" + "║   ║   ║   ║\n" + "╠═══╬═══╬═══╣\n" + "║   ║   ║   ║\n" + "╠═══╬═══╬═══╣\n" + "║   ║   ║   ║\n" + "╚═══╩═══╩═══╝\n";
            Char[] board = sboard.ToCharArray();
            string line = "╔═══╦═══╦═══╗";
            int lineSize = line.Length;
            
            foreach (char c in board)
            {
                Console.Write(c);
            }
        }
    }
}
