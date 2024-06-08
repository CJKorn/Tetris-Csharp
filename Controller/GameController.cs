using TetrisCSharp;

namespace TetrisCSharp {
    public class GameController {
        private GameModel model;
        private GameView view;

        public GameController(GameView view) {
            this.view = view;
            model = new GameModel();
            model.RandomizeBoard();
            //MessageBox.Show("I am here!");
        }

        public int[,] GetBoard() {
            return model.GetBoard();
        }

        // Add methods to handle game logic here
    }
}