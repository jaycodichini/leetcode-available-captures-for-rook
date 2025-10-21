# LeetCode 999. Available Captures for Rook
[999. Available Captures for Rook](https://leetcode.com/problems/available-captures-for-rook)

# Description
You are given an `8 x 8` matrix representing a chessboard. There is exactly one white rook represented by `'R'`, some number of white bishops `'B'`, and some number of black pawns `'p'`. Empty squares are represented by `'.'`.

A rook can move any number of squares horizontally or vertically (up, down, left, right) until it reaches another piece or the edge of the board. A rook is attacking a pawn if it can move to the pawn's square in one move.

> Note: A rook cannot move through other pieces, such as bishops or pawns. This means a rook cannot attack a pawn if there is another piece blocking the path.

Return the **number of pawns** the white rook is **attacking**.

## Constraints
- `board.length == 8`
- `board[i].length == 8`
- `board[i][j]` is either `'R'`, `'.'`, `'B'`, or `'p'`
- There is exactly one cell with `board[i][j] == 'R'`

## Example 1
```csharp
var board = new char[][]
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
```

### Output
```
3
```

### Explanation

> In this example, the rook is attacking all the pawns.

## Example 2
```csharp
var board = new char[][]
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
```

### Output
```
0
```

### Explanation

> The bishops are blocking the rook from attacking any of the pawns.

## Example 3
```csharp
var board = new char[][]
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
```

### Ouput
```
3
```

### Explanation
> The rook is attacking the pawns at positions [2][3], [3][1], and [3][5]. The rook is blocked from attacking the pawn at [6][3].