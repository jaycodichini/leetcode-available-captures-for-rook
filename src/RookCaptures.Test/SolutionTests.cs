using RookCaptures.Main;

namespace RookCaptures.Test
{
    [TestFixture]
    internal class SolutionTests
    {
        private Solution _solution;

        [SetUp]
        public void SetUp()
        {
            _solution = new Solution();
        }

        [Test]
        [TestCaseSource(typeof(SolutionTestCases), nameof(SolutionTestCases.BoardCases))]
        public int NumRookCaptures_ReturnsExpectedCaptures(char[][] board)
        {
            Console.WriteLine(string.Join(Environment.NewLine, board.Select(characters => string.Join(",", characters.Select(character => $"\"{character}\"")))));
            return _solution.NumRookCaptures(board);
        }

        private static class SolutionTestCases
        {
            public static IEnumerable<TestCaseData> BoardCases
            {
                get
                {
                    object board = new char[][]
                    {
                        ['.', '.', '.', '.', '.', '.', '.', '.'],
                        ['.', '.', '.', 'p', '.', '.', '.', '.'],
                        ['.', '.', '.', 'R', '.', '.', '.', 'p'],
                        ['.', '.', '.', '.', '.', '.', '.', '.'],
                        ['.', '.', '.', '.', '.', '.', '.', '.'],
                        ['.', '.', '.', 'p', '.', '.', '.', '.'],
                        ['.', '.', '.', '.', '.', '.', '.', '.'],
                        ['.', '.', '.', '.', '.', '.', '.', '.']
                    };
                    yield return new TestCaseData(board)
                        .SetName("NumRookCaptures_WithPawnAboveAndBelowAndRight_ReturnsThreeCaptures")
                        .Returns(3);

                    board = new char[][]
                    {
                        ['.','.','.','.','.','.','.','.'],
                        ['.','p','p','p','p','p','.','.'],
                        ['.','p','p','B','p','p','.','.'],
                        ['.','p','B','R','B','p','.','.'],
                        ['.','p','p','B','p','p','.','.'],
                        ['.','p','p','p','p','p','.','.'],
                        ['.','.','.','.','.','.','.','.'],
                        ['.','.','.','.','.','.','.','.']
                    };
                    yield return new TestCaseData(board)
                        .SetName("NumRookCaptures_WithBishopLeftAndAboveAndRightAndBelow_ReturnsZeroCaptures")
                        .Returns(0);

                    board = new char[][]
                    {
                        ['.','.','.','.','.','.','.','.'],
                        ['.','.','.','p','.','.','.','.'],
                        ['.','.','.','p','.','.','.','.'],
                        ['p','p','.','R','.','p','B','.'],
                        ['.','.','.','.','.','.','.','.'],
                        ['.','.','.','B','.','.','.','.'],
                        ['.','.','.','p','.','.','.','.'],
                        ['.','.','.','.','.','.','.','.']
                    };
                    yield return new TestCaseData(board)
                        .SetName("NumRookCaptures_WithPawnLeftAndAboveAndRightAndBishopBelow_ReturnsThreeCaptures")
                        .Returns(3);
                }
            }
        }
    }
}
