namespace SudokuAppLibrary
{
	//Used to shuffle list of indices to be removed for generating a board
	public static class shuffleFunction
	{
		private static Random rng = new Random();

		public static void Shuffle<T>(this IList<T> list)
		{
			int n = list.Count;
			while (n > 1)
			{
				n--;
				int k = rng.Next(n + 1);
				T value = list[k];
				list[k] = list[n];
				list[n] = value;
			}
		}
	}

	//used to store sudoku board data
	public class BoardModel
	{
		public int[,] m_board { get; set; } = new int[9, 9];

		static int[,] copyOfBoard = new int[9, 9];      // -> used for checking solution

		public BoardModel()                             //creates unfilled board
		{
			for (int row = 0; row < 9; ++row)
			{
				for (int col = 0; col < 9; ++col)
				{
					m_board[row, col] = 0;
				}
			}
		}

		public BoardModel(int[,] array)                 //creates board based on input array
		{
			for (int row = 0; row < 9; row++)
			{
				for (int col = 0; col < 9; col++)
				{
					m_board[row, col] = array[row, col];
				}
			}
		}

		//checks if possibleNum appears in currentRow, with optional startCol parameter
		//to avoid counting a valid number in a solved board (1 appearance of possibleNum = ok)
		bool isUsedInRow(int currentRow, int possibleNum, int startCol = 0)
		{
			for (int col = startCol; col < 9; col++)
			{
				if (m_board[currentRow, col] == possibleNum)
					return true;
			}
			return false;
		}

		//checks if possibleNum appears in currentCol, with optional startRow parameter
		//to avoid counting a valid number in a solved board (1 appearance of possibleNum = ok)
		bool isUsedInCol(int currentCol, int possibleNum, int startRow = 0)
		{
			for (int row = startRow; row < 9; row++)
			{
				if (m_board[row, currentCol] == possibleNum)
					return true;
			}
			return false;
		}

		//checks if possibleNum appears in the current 3x3 square on the board
		bool isUsedInSquare(int currentRow, int currentCol, int possibleNum)
		{
			int startRow = (currentRow / 3) * 3;
			int startCol = (currentCol / 3) * 3;
			int endRow = startRow + 3;
			int endCol = startCol + 3;

			for (int row = startRow; row < endRow; row++)
			{
				for (int col = startCol; col < endCol; col++)
				{
					if (row != currentRow && col != currentCol)
					{
						//Used to ensure the current square's value does not get counted
						//b/c 1 appearance of possibleNum = ok
						if (m_board[row, col] == possibleNum)
							return true;
					}
				}
			}
			return false;
		}

		//checks if entered board is valid (no repeats in row/col/square)
		public bool isValid()
		{
			for (int row = 0; row < 9; row++)
			{
				for (int col = 0; col < 9; col++)
				{
					int val = m_board[row, col];
					if (val != 0)
					{
						if (isUsedInRow(row, val, col + 1) ||
							isUsedInCol(col, val, row + 1) ||
							isUsedInSquare(row, col, val))
							return false;
					}
				}
			}
			return true;
		}

		//Finds the next empty space (0) in the board, returning the row/col
		//using reference parameters, T/F determines whether empty space exists
		bool findNextEmptySpace(ref int refCurrentRow, ref int refCurrentCol)
		{
			for (refCurrentRow = 0; refCurrentRow < 9; refCurrentRow++)
			{
				for (refCurrentCol = 0; refCurrentCol < 9; refCurrentCol++)
				{
					if (m_board[refCurrentRow, refCurrentCol] == 0)
						return true;
				}
			}
			return false;
		}

		//Makes sure possibleNum is not used in row/col/square
		bool isValidNumber(int currentRow, int currentCol, int possibleNum)
		{
			return (!(isUsedInRow(currentRow, possibleNum)) &&              //make sure possibleNum is not in the current row
				!(isUsedInCol(currentCol, possibleNum)) &&                  //make sure possibleNum is not in the current col
				!(isUsedInSquare(currentRow, currentCol, possibleNum)));    //make sure possibleNum is not in the current square
		}

		//Solves the board -> returns true if solution can be found & updates board accordingly,
		//returns false if solution can't be found
		public bool solve()
		{
			int srow = 0;
			int scol = 0;                           //starts at row = 0, col = 0

			if (!findNextEmptySpace(ref srow, ref scol))      //returns true if board is already solved
			{
				return true;
			}

			for (int num = 1; num <= 9; num++)      //loops through possible numbers (1-9)
			{
				if (isValidNumber(srow, scol, num))   //checks if num is a valid guess at the location (row,col)
				{
					m_board[srow, scol] = num;        //if it's a valid guess -> sets the location to that number
					if (solve())                    //calls itself to see if guess works -> true means guess is correct, false means it's not
					{
						return true;
					}
					m_board[srow, scol] = 0;          //if guess does not work, resets location to 0
				}
			}
			return false;                           //returns false if no guess works -> will cause earlier function call(to solve()) to guess the next number
		}

		//Generates a random, filled board -> 1st step for generating a playable board
		public bool generateFilledBoard()
		{
			int srow = 0;
			int scol = 0;

			//If no empty spaces -> board is filled
			if (!findNextEmptySpace(ref srow, ref scol))
				return true;

			int[] possValues = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			Random rng = new Random();
			//shuffles the array of possible values -> allows random assignment
			possValues = possValues.OrderBy(x => rng.Next()).ToArray();

			//for every number 1-9 (random order), attempt to fill in board index with number
			foreach (int val in possValues)
			{
				//If it's a valid placement, place the value and test if the entire board can be
				//legally filled in using recursion
				if (isValidNumber(srow, scol, val))
				{
					m_board[srow, scol] = val;
					if (generateFilledBoard())
						return true;

					//backtracking part -> goes back an index if no number = valid
					m_board[srow, scol] = 0;
				}
			}
			//If no numbers 1-9 can be filled in at given index, return false, backtrack
			return false;
		}

		//Removes numbers from filled board to give user a random, playable board
		public void removeIndices()
		{
			//Creates list of symmetric pairs on board, shuffles the list
			List<int> pairNumbers = new List<int>();
			for (int i = 0; i <= 41; i++)
			{
				pairNumbers.Add(i);
			}
			pairNumbers.Shuffle();

			//Removes a random amount of btw 22-28 pairs from the board (44-56 numbers)
			Random r = new Random();
			int removed = r.Next(22, 28);
			for (int i = 0; i <= removed; i++)
			{
				int temp1 = m_board[pairNumbers[i] / 9, pairNumbers[i] % 9];
				int temp2 = m_board[(80 - pairNumbers[i]) / 9, (80 - pairNumbers[i]) % 9];
				m_board[pairNumbers[i] / 9, pairNumbers[i] % 9] = 0;
				m_board[(80 - pairNumbers[i]) / 9, (80 - pairNumbers[i]) % 9] = 0;
				BoardModel copy = new BoardModel(m_board);

				//If board is unsolvable -> undo the removal
				if (!copy.solve())
				{
					m_board[pairNumbers[i] / 9, pairNumbers[i] % 9] = temp1;
					m_board[(80 - pairNumbers[i]) / 9, (80 - pairNumbers[i]) % 9] = temp2;
				}
			}

			//Initializes copy of board to the generated board -> used for checking solutions
			for (int i = 0; i < 9; i++)
			{
				for (int j = 0; j < 9; j++)
				{
					copyOfBoard[i, j] = m_board[i, j];
				}
			}
		}

		//returns if user's attempt is a valid solution to generated board
		public bool checkSolution()
		{
			for (int r = 0; r < 9; r++)
			{
				for (int c = 0; c < 9; c++)
				{
					if (copyOfBoard[r, c] != 0)
					{
						//ensures user does not change given values
						if (m_board[r, c] != copyOfBoard[r, c])
							return false;
					}
					//ensures all numbers are in valid positions
					if (isUsedInRow(r, m_board[r, c], c + 1) ||
						isUsedInCol(c, m_board[r, c], r + 1) ||
						isUsedInSquare(r, c, m_board[r, c]))
						return false;
				}
			}
			return true;
		}

	}
}