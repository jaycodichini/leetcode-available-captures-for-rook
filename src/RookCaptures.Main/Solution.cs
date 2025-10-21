namespace RookCaptures.Main
{
    public class Solution
    {
        public int NumRookCaptures(char[][] board)
        {
            var rook = new ChessPiece(-1, -1);

            var row = 0;
            var column = 0;
            while (row <= 7)
            {
                if (ChessPiece.IsRook(board[row][column]))
                {
                    rook = new ChessPiece(row, column);
                    break;
                }

                column++;
                if (column != 8)
                    continue;

                row++;
                column = 0;
            }

            if (rook.Row == -1 || rook.Column == -1)
                return 0;

            return GetRowCaptures(board, rook) + GetColumnCaptures(board, rook);
        }

        private static int GetRowCaptures(char[][] board, ChessPiece rook)
        {
            var captures = 0;
            if (rook.Column > 0)
            {
                for (var i = rook.Column - 1; i >= 0; i--)
                {
                    if (ChessPiece.IsBishop(board[rook.Row][i]))
                        break;

                    if (!ChessPiece.IsPawn(board[rook.Row][i]))
                        continue;

                    captures++;
                    break;
                }
            }

            if (rook.Column < 7)
            {
                for (var i = rook.Column + 1; i <= 7; i++)
                {
                    if (ChessPiece.IsBishop(board[rook.Row][i]))
                        break;

                    if (!ChessPiece.IsPawn(board[rook.Row][i]))
                        continue;

                    captures++;
                    break;
                }
            }
            
            return captures;
        }

        private static int GetColumnCaptures(char[][] board, ChessPiece rook)
        {
            var captures = 0;
            if (rook.Row > 0)
            {
                for (var i = rook.Row - 1; i >= 0; i--)
                {
                    if (ChessPiece.IsBishop(board[i][rook.Column]))
                        break;

                    if (!ChessPiece.IsPawn(board[i][rook.Column]))
                        continue;

                    captures++;
                    break;
                }
            }

            if (rook.Row < 7)
            {
                for (var i = rook.Row + 1; i <= 7; i++)
                {
                    if (ChessPiece.IsBishop(board[i][rook.Column]))
                        break;

                    if (!ChessPiece.IsPawn(board[i][rook.Column]))
                        continue;

                    captures++;
                    break;
                }
            }

            return captures;
        }

        private class ChessPiece(int row, int column)
        {
            public int Row { get; } = row;
            public int Column { get; } = column;

            public static bool IsBishop(char value)
            {
                return value == 'B';
            }

            public static bool IsPawn(char value)
            {
                return value == 'p';
            }

            public static bool IsRook(char value)
            {
                return value == 'R';
            }
        }
    }
}
