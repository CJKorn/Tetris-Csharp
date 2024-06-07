using System;
using System.Collections;

namespace Tetris {
    class Tetris {
        static int[,] board = new int[10, 24];
        static void Main() {
            // int[,] board = new int[10, 24];
            InitializeBoard();
            TestWriteRandomBlocks();
            PrintBoard();
        }

        public static void PrintBoard() {
            for (int y = 0; y < 24; y++) {
                Console.Write("|");
                for (int x = 0; x < 10; x++) {
                    Console.Write(board[x, y] == 0 ? " " : "■");
                }
                Console.Write("|");
                Console.WriteLine();
            }
        }

        public static void InitializeBoard() {
            for (int y = 0; y < 24; y++) {
                for (int x = 0; x < 10; x++) {
                    board[x, y] = 0;
                }
            }
        }

        public static void TestWriteRandomBlocks() {
            Random random = new Random();
            for (int y = 0; y < 24; y++) {
                for (int x = 0; x < 10; x++) {
                    board[x, y] = random.Next(0, 2);
                }
            }
        }
    }
}