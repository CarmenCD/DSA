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

        public GameBoard(Board board, User u1, User u2)
        {
            GeneralGameBoard = board;
            P1 = new Player(u1, "Alex", Symbol.Start);
            P2 = new Player(u1, "Bob", Symbol.Start);

            // initialize queue
            CurrentPayer = new Queue<Player>();
            CurrentPayer.Enqueue(P1);
            CurrentPayer.Enqueue(P2);
        }

        private int MakeChoice(Player p)
        {
            int input;
            var size = GeneralGameBoard.BoardSize;
            bool isPassed;
            do
            {
                Console.WriteLine($"{p.Alias} Please mace choice between 0 and {size}");
                string userInput = Console.ReadLine();
                isPassed = int.TryParse(userInput, out input);
            } while (!isPassed);

            return input;
        }

        private bool IsValidChoice(int choice)
        {
            // max value / min val - not beyond size

            var size = GeneralGameBoard.BoardSize;

            if (choice < 0 || choice > size * size)
            {
                return false;
            }
            
            // empty location
            var x = choice / size;
            var y = x % size;

            if (GeneralGameBoard.GeneralBoard[x, y] != Symbol.Start)
            {
                return false;
            }

            return true;
        }

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

        private void DoChanges(int choice, Player p)
        {
            int size = GeneralGameBoard.BoardSize;
            var x = choice / size;
            var y = choice % size;

            GeneralGameBoard.GeneralBoard[x, y] = p.UserSymbol;
            Judge(choice);
        }
        
        /// <summary>
        /// we want to know if 
        /// </summary>
        private void Judge(int choice)
        {
            var size = GeneralGameBoard.BoardSize;
            var x = choice / size;
            var y = choice % size;

            Symbol userSymbol = GeneralGameBoard.GeneralBoard[x, y];
            // horizontal check
            // vertical check
            // diagonal check
            // reverse diagonal
        }
    }
}
