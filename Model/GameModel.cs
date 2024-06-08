namespace TetrisCSharp {
    public class GameModel {
        public int Score { get; private set; }
        public int[,] Board;

        public GameModel() {
            Score = 0;
            Board = new int[10, 24];
            RandomizeBoard();
        }

        public int[,] GetBoard() {
            return Board;
        }

        public int GetTile(int x, int y) {
            return Board[x, y];
        }

        public void SetBoard(int[,] board) {
            this.Board = board;
        }

        public void ClearBoard() {
            Board = new int[10, 24];
        }

        public int GetScore() {
            return Score;
        }

        public void SetScore(int score) {
            Score = score;
        }

        public void RandomizeBoard() {
            for (int i = 0; i < 10; i++) {
                for (int j = 0; j < 24; j++) {
                    Board[i, j] = Random.Shared.Next(0,2);
                    //MessageBox.Show(Board[i, j].ToString());
                }
            }
        }
    }
}