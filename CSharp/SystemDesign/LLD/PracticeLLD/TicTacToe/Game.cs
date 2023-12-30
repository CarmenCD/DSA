using System.Drawing;

namespace TicTacToe
{
    public class Game
    {
        private GameBoard _gameBoard;

        public Game(GameBoard gameBoard)
        {
            _gameBoard = gameBoard;
            _gameBoard.GeneralGameBoard.Display();
        }

        public void Run()
        {
            // is ongoing till game end

            // allow to make a move

            // display board once

            // someone is winner or not 

            while (_gameBoard.GeneralGameBoard.Situation == BoardSituation.Ongoing)
            {
                Console.WriteLine($"Board Situation {_gameBoard.GeneralGameBoard.Situation}");
                _gameBoard.MakeMove();

                Console.WriteLine($"========== BOARD =========");
                _gameBoard.GeneralGameBoard.Display();
                Console.WriteLine($"========== BOARD =========");

                _gameBoard.Moves++;

                if (_gameBoard.Moves == _gameBoard.GeneralGameBoard.BoardSize * _gameBoard.GeneralGameBoard.BoardSize)
                {
                    break;
                }
            }

            if (_gameBoard.GeneralGameBoard.Situation == BoardSituation.Finished)
            {
                AnnounceWinner( _gameBoard.CurrentPayer.Last());
            }
            else
            {
                Console.WriteLine("Match is a draw");
            }
        }

        public void AnnounceWinner(Player p)
        {
            Console.WriteLine($"Winner is Player: {p.Alias}");
        }
        
}
}