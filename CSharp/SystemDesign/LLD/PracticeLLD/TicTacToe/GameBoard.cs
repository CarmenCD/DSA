using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class GameBoard
    {
        public Board GeneralGameBoard;
        public Player P1;
        public Player P2;

        public Queue<Player> CurrentPayer;

        public int Moves = 0;

        public GameBoard(Board board, User u1, User u2)
        {
            GeneralGameBoard = board;
            P1 = new Player(u1, "Alex", Symbol.Cross);
            P2 = new Player(u2, "Bob", Symbol.Zero);

            // initialize queue
            CurrentPayer = new Queue<Player>();
            CurrentPayer.Enqueue(P1);
            CurrentPayer.Enqueue(P2);
        }
        
        /// <summary>
        /// main method thaat will be called by client
        /// </summary>
        public void MakeMove()
        {
            Player p = CurrentPayer.Dequeue();
            Console.WriteLine($"Turn of Player:" + p.Alias);

            var choice = MakeChoice(p);
            while (!IsValidChoice(choice))
            {
                choice = MakeChoice(p);
            }

            DoChanges(choice, p);

            CurrentPayer.Enqueue(p);
        }
        private int MakeChoice(Player p)
        {
            int input;
            var size = GeneralGameBoard.BoardSize;
            bool isPassed;
            do
            {
                Console.WriteLine($"{p.Alias} Please make choice between 0 and {size * size - 1}");
                string? userInput = Console.ReadLine();
                isPassed = int.TryParse(userInput, out input);
            } while (!isPassed);

            return input;
        }
        private bool IsValidChoice(int choice)
        {
            // max value / min val - not beyond size^2

            var size = GeneralGameBoard.BoardSize;

            if (choice < 0 || choice >= size * size)
            {
                return false;
            }
            
            // empty location
            var x = choice / size; //row
            var y = choice % size;      //column

            if (GeneralGameBoard.GeneralBoard[x, y] != Symbol.Start)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// change the board to the current state
        /// </summary>
        /// <param name="choice"></param>
        /// <param name="p"></param>
        private void DoChanges(int choice, Player p)
        {
            int size = GeneralGameBoard.BoardSize;
            var x = choice / size;
            var y = choice % size;

            GeneralGameBoard.GeneralBoard[x, y] = p.UserSymbol;
            Judge(choice);
        }
        
        /// <summary>
        /// we want to know after each choice of a user if the user is the winner 
        /// </summary>
        private void Judge(int choice)
        {
            var size = GeneralGameBoard.BoardSize;
            var x = choice / size;
            var y = choice % size;

            Symbol userSymbol = GeneralGameBoard.GeneralBoard[x, y];

            bool gameOver = true;

            // horizontal check columns
            for (var j = 0; j < size; j++)
            {
                if (GeneralGameBoard.GeneralBoard[x, j] != userSymbol)
                {
                    gameOver = false;
                    break;
                }
            }

            if (gameOver)
            {
                GeneralGameBoard.Situation = BoardSituation.Finished;
                return;
            }
            
            // vertical check rows
            for (var i = 0; i < size; i++)
            {
                if (GeneralGameBoard.GeneralBoard[i, y] != userSymbol)
                {
                    gameOver = false;
                    break;
                }
            }

            if (gameOver)
            {
                GeneralGameBoard.Situation = BoardSituation.Finished;
                return;
            }

            // diagonal check

            // reverse diagonal
        }
    }
}
