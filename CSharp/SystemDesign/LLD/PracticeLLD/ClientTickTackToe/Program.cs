// See https://aka.ms/new-console-template for more information

using System.Reflection.Metadata;
using TicTacToe;

Console.WriteLine("Hello, World!");

User u1, u2;
u1 = new User();
u2 = new User();

Board board = new Board(3);
GameBoard gameBoard = new GameBoard(board, u1, u2);
Game tickTackToe = new Game(gameBoard);
tickTackToe.Run();
