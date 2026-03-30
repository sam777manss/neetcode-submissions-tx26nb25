public class Solution {
    public bool IsValidSudoku(char[][] board) {
            bool isValid = true;
            int i = 0, j = 0, k = 0;
            while(k < board.Length)
            {
                for (i = 0; i < board.Length; i++)
                {
                    for (j = 0; j < board.Length; j++)
                    {
                        if (i != j)
                        {
                            if (board[k][i] == board[k][j] && board[k][i].ToString() != "." && board[k][j].ToString() != ".")
                            {
                                return false;
                            }
                            //Console.Write(board[k][i] + "==" + board[k][j] + ", ");
                        }
                        if (i != j)
                        {
                            if(board[i][k] == board[j][k] && board[i][k].ToString() != "." && board[j][k].ToString() != ".")
                            {
                                return false;
                            }
                            //Console.Write(board[i][k] + "==" + board[j][k] + ", ");
                        }
                    }
                    //Console.WriteLine();
                }
                //Console.WriteLine("==============================================");

                k++;
            }
            i = 0; j = 0; k = 3;
            for (; i < k;)
            {
                for (; j < 8;)
                {
                    Console.WriteLine("Row");
                    Console.WriteLine(board[i][j] + "==" + board[i + 1][j + 1] + "==" + board[i + 2][j + 2]);
                    if (
                        (board[i][j] == board[i + 1][j + 1] && board[i][j].ToString() != "." && board[i + 1][j + 1].ToString() != ".")
                        || (board[i][j] == board[i + 2][j + 2] && board[i][j].ToString() != "." && board[i + 2][j + 2].ToString() != ".")
                        || (board[i + 1][j + 1] == board[i + 2][j + 2] && board[i + 1][j + 1].ToString() != "." && board[i + 2][j + 2].ToString() != ".")
                        )
                    {
                        isValid = false;
                        return isValid;
                    }
                    Console.WriteLine("Column");
                    Console.WriteLine(board[i + 2][j] + "==" + board[i + 1][j + 1] + "==" + board[i][j + 2]);
                    if (
                        (board[i + 2][j] == board[i + 1][j + 1] && board[i + 2][j].ToString() != "." && board[i + 1][j + 1].ToString() != ".")
                        || (board[i][j + 2] == board[i + 1][j + 1] && board[i][j + 2].ToString() != "." && board[i + 1][j + 1].ToString() != ".")
                        || (board[i + 2][j] == board[i][j + 2] && board[i + 2][j].ToString() != "." && board[i][j + 2].ToString() != ".")
                        )
                    {
                        isValid = false;
                        return isValid;

                    }
                    j += 3;
                }
                Console.WriteLine();
                j = 0;
                k += 3;
                i += 3;
                if (k >= 12)
                {
                    break;
                }
            }
            for (i = 0; i < 9; i += 3)
            {
                for (j = 0; j < 9; j += 3)
                {
                    for (int r1 = i; r1 < i + 3; r1++)
                    {
                        for (int c1 = j; c1 < j + 3; c1++)
                        {
                            if (board[r1][c1] == '.')
                                continue;

                            for (int r2 = i; r2 < i + 3; r2++)
                            {
                                for (int c2 = j; c2 < j + 3; c2++)
                                {
                                    if (r1 == r2 && c1 == c2)
                                        continue;

                                    Console.WriteLine($"[{r1},{c1}]={board[r1][c1]} vs [{r2},{c2}]={board[r2][c2]}");

                                    if (board[r1][c1] == board[r2][c2] && board[r1][c1] != '.')
                                    {
                                        Console.WriteLine($"Duplicate in block: {board[r1][c1]} at [{r1},{c1}] and [{r2},{c2}]");
                                        return false;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return isValid;
    }
}
