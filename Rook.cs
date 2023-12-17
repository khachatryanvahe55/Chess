

namespace Chess
{
    public class Rook
    {
        public string Color { get; }

        public Rook(string color)
        {
            Color = color;
        }

        public bool IsValidMove(Tuple<char, int> start, Tuple<char, int> end)
        {
            return start.Item1 == end.Item1 || start.Item2 == end.Item2;
        }
    }
}
