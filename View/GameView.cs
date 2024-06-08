using System.Windows.Forms;
using TetrisCSharp;

namespace TetrisCSharp
{
    public partial class GameView : Form {
        private GameController controller;

        public GameView(GameController controller) {
            InitializeComponent();
            this.controller = controller;
        }

        // Add methods to update the UI based on the game state here
    }
}

