using System.Drawing;
using System.Windows.Forms;
using TetrisCSharp;

namespace TetrisCSharp {
    public partial class GameView : Form {
        private GameController controller;

        public GameView() {
            controller = new GameController(this);
            InitializeComponent();
            Invalidate();
            //MessageBox.Show("I am here2!");
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);

            // Get the current game state
            var board = controller.GetBoard();

            // Calculate the size of each block
            int blockSize = Math.Min(ClientSize.Width / board.GetLength(0), ClientSize.Height / board.GetLength(1)/2);

            // Draw each block
            for (int x = 0; x < board.GetLength(0); x++) {
                for (int y = 0; y < board.GetLength(1); y++) {
                    // Choose a color based on the block's value
                    Brush brush;
                    switch (board[x, y]) {
                        case 0: brush = Brushes.Black; break; // Empty space
                        case 1: brush = Brushes.Red; break; // Tetris block
                        // Add more cases as needed
                        default: brush = Brushes.Blue; break;
                    }

                    // Draw the block
                    e.Graphics.FillRectangle(brush, x * blockSize, y * blockSize, blockSize, blockSize);
                }
            }
        }

        // Add more methods to update the UI based on the game state here
    }
}