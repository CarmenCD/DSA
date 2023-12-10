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
        }

    }
}