using TetrisCSharp;

namespace TetrisCSharp {
    public class GameController {
        private GameModel model;
        private GameView view;

        public GameController(GameModel model, GameView view) {
            this.model = model;
            this.view = view;
        }

        // Add methods to handle game logic here
    }
}