using System;
using System.Collections.Generic;

namespace PuzzleGameApp
{
    class PuzzleGame
    {
        private int[,] puzzle;
        private int size;
        private int emptyRow, emptyCol;

        public PuzzleGame(int size)
        {
            this.size = size;
            puzzle = new int[size, size];
            InitializePuzzle();
        }

        private void InitializePuzzle()
        {
            int value = 1;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    puzzle[i, j] = value;
                    value++;
                }
            }
            puzzle[size - 1, size - 1] = 0; // empty space
            emptyRow = size - 1;
            emptyCol = size - 1;
        }

        public void DisplayPuzzle()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (puzzle[i, j] == 0)
                        Console.Write("__ ");
                    else
                        Console.Write(puzzle[i, j].ToString().PadLeft(2) + " ");
                }
                Console.WriteLine();
            }
        }

        public bool MakeMove(string direction)
        {
            int newRow = emptyRow;
            int newCol = emptyCol;

            switch (direction.ToLower())
            {
                case "up": newRow--; break;
                case "down": newRow++; break;
                case "left": newCol--; break;
                case "right": newCol++; break;
                default: Console.WriteLine("Invalid move. Use 'up', 'down', 'left', or 'right'."); return false;
            }

            if (IsValidMove(newRow, newCol))
            {
                puzzle[emptyRow, emptyCol] = puzzle[newRow, newCol];
                puzzle[newRow, newCol] = 0;
                emptyRow = newRow;
                emptyCol = newCol;
                return true;
            }

            return false;
        }

        private bool IsValidMove(int row, int col)
        {
            return row >= 0 && row < size && col >= 0 && col < size;
        }

        public bool IsSolved()
        {
            int value = 1;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == size - 1 && j == size - 1)
                        return puzzle[i, j] == 0;
                    if (puzzle[i, j] != value++)
                        return false;
                }
            }
            return true;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Puzzle Game!");
            Console.WriteLine("Select difficulty (3 = Easy, 4 = Medium, 5 = Hard):");
            int size = int.Parse(Console.ReadLine());
            PuzzleGame game = new PuzzleGame(size);
            game.DisplayPuzzle();

            while (!game.IsSolved())
            {
                Console.WriteLine("Enter your move (up, down, left, right):");
                string direction = Console.ReadLine();
                if (game.MakeMove(direction))
                {
                    game.DisplayPuzzle();
                }
            }

            Console.WriteLine("Congratulations! You've solved the puzzle.");
        }
    }
}