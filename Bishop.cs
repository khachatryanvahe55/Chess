

namespace Chess
{
    public class Bishop
    {
        public string Color { get; }

        public Bishop(string color)
        {
            Color = color;
        }

        public bool IsValidMove(Tuple<char, int> start, Tuple<char, int> end)
        {
            return Math.Abs(start.Item1 - end.Item1) == Math.Abs(start.Item2 - end.Item2);
        }
    }
}
