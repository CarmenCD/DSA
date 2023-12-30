using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Board
    {
        public Symbol[,] GeneralBoard;

        public int BoardSize;

        public BoardSituation Situation;

        public Board(int size)
        {
            BoardSize = size;
            Situation = BoardSituation.Ongoing;
            GeneralBoard = new Symbol[BoardSize, BoardSize];
            Initialize();
        }

        public void Initialize()
        {
            for (int i = 0; i < BoardSize; i++)
            {
                for (int j = 0; j < BoardSize; j++)
                {
                    GeneralBoard[i, j] = Symbol.Start;
                }
                
            }
        }

        public void Display()
        {
            for (int i = 0; i < BoardSize; i++)
            {
                for (int j = 0; j < BoardSize; j++)
                {
                    Console.Write((char)GeneralBoard[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
