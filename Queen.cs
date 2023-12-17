

namespace Chess
{
    public class Queen
    {
        public string Color { get; }

        public Queen(string color)
        {
            Color = color;
        }

        public bool IsValidMove(Tuple<char, int> start, Tuple<char, int> end)
        {
            return new Rook(Color).IsValidMove(start, end) || new Bishop(Color).IsValidMove(start, end);
        }
    }
}
