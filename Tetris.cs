using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

//Basic Idea, I will have the static board of placed blocks and then I will have a block that is falling down separate until it lands

namespace Tetris {
    class Tetris {
        public static int[,] board = new int[10, 24];
        static void Main() {
            // int[,] board = new int[10, 24];
            InitializeBoard();
            TestWriteRandomBlocks();
            PrintBoard();
        }

        public static int[,] getBoard() {
            return board;
        }

        public static int getTile(int x, int y) {
            return board[x, y];
        }

        public static void writeTile(int x, int y, int value) {
            board[x, y] = value;
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