using System;

namespace Sudoku2DArrays
{
    class Program
    {
        public static void Main(string[] args)
        {
            //1 2 3 4 5 6 7 8 9
            int[,] sudokuTable = new int[9, 9];

            string[] Lines = new string[9];

            for (int i = 0; i < 9; i++)
            {
                Lines[i] = Console.ReadLine();
            }

            string numString = string.Join(" ", Lines);

            int[] intLines = Array.ConvertAll<string, int>(numString.Split(" "), int.Parse);

            int index = 0;
            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    sudokuTable[x, y] = intLines[index];
                    index++;
                }
            }

            //9 columns of sudoku
            int columnNumber1 = 0;
            int[] ColumnNo1 = Enumerable.Range(0, sudokuTable.GetLength(0))
                      .Select(x => sudokuTable[x, columnNumber1])
                      .ToArray();
            int columnNumber2 = 1;
            int[] ColumnNo2 = Enumerable.Range(0, sudokuTable.GetLength(0))
                      .Select(x => sudokuTable[x, columnNumber2])
                      .ToArray();
            int columnNumber3 = 2;
            int[] ColumnNo3 = Enumerable.Range(0, sudokuTable.GetLength(0))
                      .Select(x => sudokuTable[x, columnNumber3])
                      .ToArray();
            int columnNumber4 = 3;
            int[] ColumnNo4 = Enumerable.Range(0, sudokuTable.GetLength(0))
                      .Select(x => sudokuTable[x, columnNumber4])
                      .ToArray();
            int columnNumber5 = 4;
            int[] ColumnNo5 = Enumerable.Range(0, sudokuTable.GetLength(0))
                      .Select(x => sudokuTable[x, columnNumber5])
                      .ToArray();
            int columnNumber6 = 5;
            int[] ColumnNo6 = Enumerable.Range(0, sudokuTable.GetLength(0))
                      .Select(x => sudokuTable[x, columnNumber6])
                      .ToArray();
            int columnNumber7 = 6;
            int[] ColumnNo7 = Enumerable.Range(0, sudokuTable.GetLength(0))
                      .Select(x => sudokuTable[x, columnNumber7])
                      .ToArray();
            int columnNumber8 = 7;
            int[] ColumnNo8 = Enumerable.Range(0, sudokuTable.GetLength(0))
                      .Select(x => sudokuTable[x, columnNumber8])
                      .ToArray();
            int columnNumber9 = 8;
            int[] ColumnNo9 = Enumerable.Range(0, sudokuTable.GetLength(0))
                      .Select(x => sudokuTable[x, columnNumber9])
                      .ToArray();

            //9 rows of sudoku
            int rowNumber1 = 0;
            int[] RowNo1 = Enumerable.Range(0, sudokuTable.GetLength(1))
                      .Select(x => sudokuTable[rowNumber1, x])
                      .ToArray();
            int rowNumber2 = 1;
            int[] RowNo2 = Enumerable.Range(0, sudokuTable.GetLength(1))
                      .Select(x => sudokuTable[rowNumber2, x])
                      .ToArray();
            int rowNumber3 = 2;
            int[] RowNo3 = Enumerable.Range(0, sudokuTable.GetLength(1))
                      .Select(x => sudokuTable[rowNumber3, x])
                      .ToArray();
            int rowNumber4 = 3;
            int[] RowNo4 = Enumerable.Range(0, sudokuTable.GetLength(1))
                      .Select(x => sudokuTable[rowNumber4, x])
                      .ToArray();
            int rowNumber5 = 4;
            int[] RowNo5 = Enumerable.Range(0, sudokuTable.GetLength(1))
                      .Select(x => sudokuTable[rowNumber5, x])
                      .ToArray();
            int rowNumber6 = 5;
            int[] RowNo6 = Enumerable.Range(0, sudokuTable.GetLength(1))
                      .Select(x => sudokuTable[rowNumber6, x])
                      .ToArray();
            int rowNumber7 = 6;
            int[] RowNo7 = Enumerable.Range(0, sudokuTable.GetLength(1))
                      .Select(x => sudokuTable[rowNumber7, x])
                      .ToArray();
            int rowNumber8 = 7;
            int[] RowNo8 = Enumerable.Range(0, sudokuTable.GetLength(1))
                      .Select(x => sudokuTable[rowNumber8, x])
                      .ToArray();
            int rowNumber9 = 8;
            int[] RowNo9 = Enumerable.Range(0, sudokuTable.GetLength(1))
                      .Select(x => sudokuTable[rowNumber9, x])
                      .ToArray();

            //9 squares size 3x3
            int[,] squareLeftTop = new int[3, 3];
            squareLeftTop[0, 0] = RowNo1[0];
            squareLeftTop[0, 1] = RowNo1[1];
            squareLeftTop[0, 2] = RowNo1[2];
            squareLeftTop[1, 0] = RowNo2[0];
            squareLeftTop[1, 1] = RowNo2[1];
            squareLeftTop[1, 2] = RowNo2[2];
            squareLeftTop[2, 0] = RowNo3[0];
            squareLeftTop[2, 1] = RowNo3[1];
            squareLeftTop[2, 2] = RowNo3[2];

            index = 0;
            int[] sqLT_Nums = new int[9];
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    sqLT_Nums[index] = squareLeftTop[x, y];
                    index++;
                }
            }

            int[,] squareMidTop = new int[3, 3];
            squareMidTop[0, 0] = RowNo1[3];
            squareMidTop[0, 1] = RowNo1[4];
            squareMidTop[0, 2] = RowNo1[5];
            squareMidTop[1, 0] = RowNo2[3];
            squareMidTop[1, 1] = RowNo2[4];
            squareMidTop[1, 2] = RowNo2[5];
            squareMidTop[2, 0] = RowNo3[3];
            squareMidTop[2, 1] = RowNo3[4];
            squareMidTop[2, 2] = RowNo3[5];

            index = 0;
            int[] sqMT_Nums = new int[9];
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    sqMT_Nums[index] = squareMidTop[x, y];
                    index++;
                }
            }

            int[,] squareRightTop = new int[3, 3];
            squareRightTop[0, 0] = RowNo1[6];
            squareRightTop[0, 1] = RowNo1[7];
            squareRightTop[0, 2] = RowNo1[8];
            squareRightTop[1, 0] = RowNo2[6];
            squareRightTop[1, 1] = RowNo2[7];
            squareRightTop[1, 2] = RowNo2[8];
            squareRightTop[2, 0] = RowNo3[6];
            squareRightTop[2, 1] = RowNo3[7];
            squareRightTop[2, 2] = RowNo3[8];

            index = 0;
            int[] sqRT_Nums = new int[9];
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    sqRT_Nums[index] = squareRightTop[x, y];
                    index++;
                }
            }

            int[,] squareLeftMid = new int[3, 3];
            squareLeftMid[0, 0] = RowNo4[0];
            squareLeftMid[0, 1] = RowNo4[1];
            squareLeftMid[0, 2] = RowNo4[2];
            squareLeftMid[1, 0] = RowNo5[0];
            squareLeftMid[1, 1] = RowNo5[1];
            squareLeftMid[1, 2] = RowNo5[2];
            squareLeftMid[2, 0] = RowNo6[0];
            squareLeftMid[2, 1] = RowNo6[1];
            squareLeftMid[2, 2] = RowNo6[2];

            index = 0;
            int[] sqLM_Nums = new int[9];
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    sqLM_Nums[index] = squareLeftMid[x, y];
                    index++;
                }
            }

            int[,] squareMidMid = new int[3, 3];
            squareMidMid[0, 0] = RowNo4[3];
            squareMidMid[0, 1] = RowNo4[4];
            squareMidMid[0, 2] = RowNo4[5];
            squareMidMid[1, 0] = RowNo5[3];
            squareMidMid[1, 1] = RowNo5[4];
            squareMidMid[1, 2] = RowNo5[5];
            squareMidMid[2, 0] = RowNo6[3];
            squareMidMid[2, 1] = RowNo6[4];
            squareMidMid[2, 2] = RowNo6[5];

            index = 0;
            int[] sqMM_Nums = new int[9];
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    sqMM_Nums[index] = squareMidMid[x, y];
                    index++;
                }
            }

            int[,] squareRightMid = new int[3, 3];
            squareRightMid[0, 0] = RowNo4[6];
            squareRightMid[0, 1] = RowNo4[7];
            squareRightMid[0, 2] = RowNo4[8];
            squareRightMid[1, 0] = RowNo5[6];
            squareRightMid[1, 1] = RowNo5[7];
            squareRightMid[1, 2] = RowNo5[8];
            squareRightMid[2, 0] = RowNo6[6];
            squareRightMid[2, 1] = RowNo6[7];
            squareRightMid[2, 2] = RowNo6[8];

            index = 0;
            int[] sqRM_Nums = new int[9];
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    sqRM_Nums[index] = squareRightMid[x, y];
                    index++;
                }
            }

            int[,] squareLeftDown = new int[3, 3];
            squareLeftDown[0, 0] = RowNo7[0];
            squareLeftDown[0, 1] = RowNo7[1];
            squareLeftDown[0, 2] = RowNo7[2];
            squareLeftDown[1, 0] = RowNo8[0];
            squareLeftDown[1, 1] = RowNo8[1];
            squareLeftDown[1, 2] = RowNo8[2];
            squareLeftDown[2, 0] = RowNo9[0];
            squareLeftDown[2, 1] = RowNo9[1];
            squareLeftDown[2, 2] = RowNo9[2];

            index = 0;
            int[] sqLD_Nums = new int[9];
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    sqLD_Nums[index] = squareLeftDown[x, y];
                    index++;
                }
            }

            int[,] squareMidDown = new int[3, 3];
            squareMidDown[0, 0] = RowNo7[3];
            squareMidDown[0, 1] = RowNo7[4];
            squareMidDown[0, 2] = RowNo7[5];
            squareMidDown[1, 0] = RowNo8[3];
            squareMidDown[1, 1] = RowNo8[4];
            squareMidDown[1, 2] = RowNo8[5];
            squareMidDown[2, 0] = RowNo9[3];
            squareMidDown[2, 1] = RowNo9[4];
            squareMidDown[2, 2] = RowNo9[5];

            index = 0;
            int[] sqMD_Nums = new int[9];
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    sqMD_Nums[index] = squareMidDown[x, y];
                    index++;
                }
            }

            int[,] squareRightDown = new int[3, 3];
            squareRightDown[0, 0] = RowNo7[6];
            squareRightDown[0, 1] = RowNo7[7];
            squareRightDown[0, 2] = RowNo7[8];
            squareRightDown[1, 0] = RowNo8[6];
            squareRightDown[1, 1] = RowNo8[7];
            squareRightDown[1, 2] = RowNo8[8];
            squareRightDown[2, 0] = RowNo9[6];
            squareRightDown[2, 1] = RowNo9[7];
            squareRightDown[2, 2] = RowNo9[8];

            index = 0;
            int[] sqRD_Nums = new int[9];
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    sqRD_Nums[index] = squareRightDown[x, y];
                    index++;
                }
            }


            //Condition no.1
            foreach (var x in sudokuTable)
            {
                if (x > 9 || x < 1)
                {
                    Console.WriteLine("no");
                    return;
                }
            }
            //Condition no.2
            if (ColumnNo1.Length != ColumnNo1.Distinct().Count())
            {
                Console.WriteLine("no");
                return;
            }
            if (ColumnNo2.Length != ColumnNo2.Distinct().Count())
            {
                Console.WriteLine("no");
                return;
            }
            if (ColumnNo3.Length != ColumnNo3.Distinct().Count())
            {
                Console.WriteLine("no");
                return;
            }
            if (ColumnNo4.Length != ColumnNo4.Distinct().Count())
            {
                Console.WriteLine("no");
                return;
            }
            if (ColumnNo5.Length != ColumnNo5.Distinct().Count())
            {
                Console.WriteLine("no");
                return;
            }
            if (ColumnNo6.Length != ColumnNo6.Distinct().Count())
            {
                Console.WriteLine("no");
                return;
            }
            if (ColumnNo7.Length != ColumnNo7.Distinct().Count())
            {
                Console.WriteLine("no");
                return;
            }
            if (ColumnNo8.Length != ColumnNo8.Distinct().Count())
            {
                Console.WriteLine("no");
                return;
            }
            if (ColumnNo9.Length != ColumnNo9.Distinct().Count())
            {
                Console.WriteLine("no");
                return;
            }
            //Condition no.3
            if (RowNo1.Length != RowNo1.Distinct().Count())
            {
                Console.WriteLine("no");
                return;
            }
            if (RowNo2.Length != RowNo2.Distinct().Count())
            {
                Console.WriteLine("no");
                return;
            }
            if (RowNo3.Length != RowNo3.Distinct().Count())
            {
                Console.WriteLine("no");
                return;
            }
            if (RowNo4.Length != RowNo4.Distinct().Count())
            {
                Console.WriteLine("no");
                return;
            }
            if (RowNo5.Length != RowNo5.Distinct().Count())
            {
                Console.WriteLine("no");
                return;
            }
            if (RowNo6.Length != RowNo6.Distinct().Count())
            {
                Console.WriteLine("no");
                return;
            }
            if (RowNo7.Length != RowNo7.Distinct().Count())
            {
                Console.WriteLine("no");
                return;
            }
            if (RowNo8.Length != RowNo8.Distinct().Count())
            {
                Console.WriteLine("no");
                return;
            }
            if (RowNo9.Length != RowNo9.Distinct().Count())
            {
                Console.WriteLine("no");
                return;
            }
            //Condition no.4
            if (sqLT_Nums.Length != sqLT_Nums.Distinct().Count())
            {
                Console.WriteLine("no");
                return;
            }
            if (sqMT_Nums.Length != sqMT_Nums.Distinct().Count())
            {
                Console.WriteLine("no");
                return;
            }
            if (sqRT_Nums.Length != sqRT_Nums.Distinct().Count())
            {
                Console.WriteLine("no");
                return;
            }
            if (sqLM_Nums.Length != sqLM_Nums.Distinct().Count())
            {
                Console.WriteLine("no");
                return;
            }
            if (sqMM_Nums.Length != sqMM_Nums.Distinct().Count())
            {
                Console.WriteLine("no");
                return;
            }
            if (sqRM_Nums.Length != sqRM_Nums.Distinct().Count())
            {
                Console.WriteLine("no");
                return;
            }
            if (sqLD_Nums.Length != sqLD_Nums.Distinct().Count())
            {
                Console.WriteLine("no");
                return;
            }
            if (sqMD_Nums.Length != sqMD_Nums.Distinct().Count())
            {
                Console.WriteLine("no");
                return;
            }
            if (sqRD_Nums.Length != sqRD_Nums.Distinct().Count())
            {
                Console.WriteLine("no");
                return;
            }

            Console.WriteLine("yes");
        }


        // Checker
        static bool IsValidSudoku(int[,] puzzle)
        {
            // Checking rows duplicates
            for (int i = 0; i < 9; i++)
            {
                bool[] seen = new bool[9];
                for (int j = 0; j < 9; j++)
                {
                    if (puzzle[i, j] < 1 || puzzle[i, j] > 9 || seen[puzzle[i, j] - 1])
                    {
                        return false;
                    }
                    seen[puzzle[i, j] - 1] = true;
                }
            }

            // Checking cols duplicates
            for (int j = 0; j < 9; j++)
            {
                bool[] seen = new bool[9];
                for (int i = 0; i < 9; i++)
                {
                    if (puzzle[i, j] < 1 || puzzle[i, j] > 9 || seen[puzzle[i, j] - 1])
                    {
                        return false;
                    }
                    seen[puzzle[i, j] - 1] = true;
                }
            }

            // Checking 3x3 blocks
            for (int blockNum = 0; blockNum < 9; blockNum++)
            {
                bool[] blockCheck = new bool[9];
                for (int i = blockNum / 3 * 3; i < blockNum / 3 * 3 + 3; i++)
                {
                    for (int j = blockNum % 3 * 3; j < blockNum % 3 * 3 + 3; j++)
                    {
                        int num = puzzle[i, j];
                        if (blockCheck[num - 1])
                        {
                            return false;
                        }
                        blockCheck[num - 1] = true;
                    }
                }
            }

            // If puzzle is valid
            return true;
        }

        static void Main(string[] args)
        {
            // Creating array
            int[,] inputArray = new int[9, 9];

            // Input
            for (int i = 0; i < 9; i++)
            {
                string line = Console.ReadLine();
                string[] digits = line.Split(' ');

                for (int j = 0; j < 9; j++)
                {
                    inputArray[i, j] = int.Parse(digits[j]);
                }
            }

            // Output
            if (IsValidSudoku(inputArray))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}