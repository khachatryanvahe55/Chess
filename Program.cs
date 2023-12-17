using Chess;


namespace Chess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChessTable chesstable = new ChessTable();

            Console.WriteLine("Enter the starting position (row, column):");
            Tuple<char, int> startPosition = GetPosition();

            Console.WriteLine("Enter the ending position (row, column):");
            Tuple<char, int> endPosition = GetPosition();

            Rook rook = new Rook("white");
            Knight knight = new Knight("black");
            Bishop bishop = new Bishop("white");
            Queen queen = new Queen("black");
            King king = new King("white");

            CheckAndPrintMove(rook, "Rook", startPosition, endPosition);
            CheckAndPrintMove(knight, "Knight", startPosition, endPosition);
            CheckAndPrintMove(bishop, "Bishop", startPosition, endPosition);
            CheckAndPrintMove(queen, "Queen", startPosition, endPosition);
            CheckAndPrintMove(king, "King", startPosition, endPosition);
        }

        static Tuple<char, int> GetPosition()
        {
            Console.Write("Row: ");
            char row = Console.ReadKey().KeyChar;
            Console.WriteLine(); 

            Console.Write("Column: ");
            int col = int.Parse(Console.ReadLine());

            return Tuple.Create(row, col);
        }

        static void CheckAndPrintMove(dynamic piece, string pieceName, Tuple<char, int> start, Tuple<char, int> end)
        {
            bool isValidMove = piece.IsValidMove(start, end);
            Console.WriteLine($"{pieceName}: {PrintValidity(isValidMove)}");
        }

        static string PrintValidity(bool isValid)
        {
            return isValid ? "Valid move" : "Invalid move";
        }
    }
 }
