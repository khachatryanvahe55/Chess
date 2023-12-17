
namespace Chess
{
    public class Knight
    {
        public string Color { get; }

        public Knight(string color)
        {
            Color = color;
        }

        public bool IsValidMove(Tuple<char, int> start, Tuple<char, int> end)
        {
            int dx = Math.Abs(start.Item1 - end.Item1);
            int dy = Math.Abs(start.Item2 - end.Item2);
            return (dx == 1 && dy == 2) || (dx == 2 && dy == 1);
        }
    }
}
