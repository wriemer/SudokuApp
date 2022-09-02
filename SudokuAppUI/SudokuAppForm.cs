using SudokuAppLibrary;

namespace SudokuAppUI
{
    public partial class SudokuAppForm : Form
    {
        public SudokuAppForm()
        {
            InitializeComponent();
        }

        //Displays the contents from input BoardModel in the form
        public void boardToForm(BoardModel b)
        {
            square00Box.Text = (b.m_board[0, 0]).ToString();
            square01Box.Text = (b.m_board[0, 1]).ToString();
            square02Box.Text = (b.m_board[0, 2]).ToString();
            square03Box.Text = (b.m_board[0, 3]).ToString();
            square04Box.Text = (b.m_board[0, 4]).ToString();
            square05Box.Text = (b.m_board[0, 5]).ToString();
            square06Box.Text = (b.m_board[0, 6]).ToString();
            square07Box.Text = (b.m_board[0, 7]).ToString();
            square08Box.Text = (b.m_board[0, 8]).ToString();
            square10Box.Text = (b.m_board[1, 0]).ToString();
            square11Box.Text = (b.m_board[1, 1]).ToString();
            square12Box.Text = (b.m_board[1, 2]).ToString();
            square13Box.Text = (b.m_board[1, 3]).ToString();
            square14Box.Text = (b.m_board[1, 4]).ToString();
            square15Box.Text = (b.m_board[1, 5]).ToString();
            square16Box.Text = (b.m_board[1, 6]).ToString();
            square17Box.Text = (b.m_board[1, 7]).ToString();
            square18Box.Text = (b.m_board[1, 8]).ToString();
            square20Box.Text = (b.m_board[2, 0]).ToString();
            square21Box.Text = (b.m_board[2, 1]).ToString();
            square22Box.Text = (b.m_board[2, 2]).ToString();
            square23Box.Text = (b.m_board[2, 3]).ToString();
            square24Box.Text = (b.m_board[2, 4]).ToString();
            square25Box.Text = (b.m_board[2, 5]).ToString();
            square26Box.Text = (b.m_board[2, 6]).ToString();
            square27Box.Text = (b.m_board[2, 7]).ToString();
            square28Box.Text = (b.m_board[2, 8]).ToString();
            square30Box.Text = (b.m_board[3, 0]).ToString();
            square31Box.Text = (b.m_board[3, 1]).ToString();
            square32Box.Text = (b.m_board[3, 2]).ToString();
            square33Box.Text = (b.m_board[3, 3]).ToString();
            square34Box.Text = (b.m_board[3, 4]).ToString();
            square35Box.Text = (b.m_board[3, 5]).ToString();
            square36Box.Text = (b.m_board[3, 6]).ToString();
            square37Box.Text = (b.m_board[3, 7]).ToString();
            square38Box.Text = (b.m_board[3, 8]).ToString();
            square40Box.Text = (b.m_board[4, 0]).ToString();
            square41Box.Text = (b.m_board[4, 1]).ToString();
            square42Box.Text = (b.m_board[4, 2]).ToString();
            square43Box.Text = (b.m_board[4, 3]).ToString();
            square44Box.Text = (b.m_board[4, 4]).ToString();
            square45Box.Text = (b.m_board[4, 5]).ToString();
            square46Box.Text = (b.m_board[4, 6]).ToString();
            square47Box.Text = (b.m_board[4, 7]).ToString();
            square48Box.Text = (b.m_board[4, 8]).ToString();
            square50Box.Text = (b.m_board[5, 0]).ToString();
            square51Box.Text = (b.m_board[5, 1]).ToString();
            square52Box.Text = (b.m_board[5, 2]).ToString();
            square53Box.Text = (b.m_board[5, 3]).ToString();
            square54Box.Text = (b.m_board[5, 4]).ToString();
            square55Box.Text = (b.m_board[5, 5]).ToString();
            square56Box.Text = (b.m_board[5, 6]).ToString();
            square57Box.Text = (b.m_board[5, 7]).ToString();
            square58Box.Text = (b.m_board[5, 8]).ToString();
            square60Box.Text = (b.m_board[6, 0]).ToString();
            square61Box.Text = (b.m_board[6, 1]).ToString();
            square62Box.Text = (b.m_board[6, 2]).ToString();
            square63Box.Text = (b.m_board[6, 3]).ToString();
            square64Box.Text = (b.m_board[6, 4]).ToString();
            square65Box.Text = (b.m_board[6, 5]).ToString();
            square66Box.Text = (b.m_board[6, 6]).ToString();
            square67Box.Text = (b.m_board[6, 7]).ToString();
            square68Box.Text = (b.m_board[6, 8]).ToString();
            square70Box.Text = (b.m_board[7, 0]).ToString();
            square71Box.Text = (b.m_board[7, 1]).ToString();
            square72Box.Text = (b.m_board[7, 2]).ToString();
            square73Box.Text = (b.m_board[7, 3]).ToString();
            square74Box.Text = (b.m_board[7, 4]).ToString();
            square75Box.Text = (b.m_board[7, 5]).ToString();
            square76Box.Text = (b.m_board[7, 6]).ToString();
            square77Box.Text = (b.m_board[7, 7]).ToString();
            square78Box.Text = (b.m_board[7, 8]).ToString();
            square80Box.Text = (b.m_board[8, 0]).ToString();
            square81Box.Text = (b.m_board[8, 1]).ToString();
            square82Box.Text = (b.m_board[8, 2]).ToString();
            square83Box.Text = (b.m_board[8, 3]).ToString();
            square84Box.Text = (b.m_board[8, 4]).ToString();
            square85Box.Text = (b.m_board[8, 5]).ToString();
            square86Box.Text = (b.m_board[8, 6]).ToString();
            square87Box.Text = (b.m_board[8, 7]).ToString();
            square88Box.Text = (b.m_board[8, 8]).ToString();
        }

        //Captures the input from the form into a BoardModel
        public void formToBoard(BoardModel b)
        {
            b.m_board[0, 0] = Int32.Parse(square00Box.Text);
            b.m_board[0, 1] = Int32.Parse(square01Box.Text);
            b.m_board[0, 2] = Int32.Parse(square02Box.Text);
            b.m_board[0, 3] = Int32.Parse(square03Box.Text);
            b.m_board[0, 4] = Int32.Parse(square04Box.Text);
            b.m_board[0, 5] = Int32.Parse(square05Box.Text);
            b.m_board[0, 6] = Int32.Parse(square06Box.Text);
            b.m_board[0, 7] = Int32.Parse(square07Box.Text);
            b.m_board[0, 8] = Int32.Parse(square08Box.Text);
            b.m_board[1, 0] = Int32.Parse(square10Box.Text);
            b.m_board[1, 1] = Int32.Parse(square11Box.Text);
            b.m_board[1, 2] = Int32.Parse(square12Box.Text);
            b.m_board[1, 3] = Int32.Parse(square13Box.Text);
            b.m_board[1, 4] = Int32.Parse(square14Box.Text);
            b.m_board[1, 5] = Int32.Parse(square15Box.Text);
            b.m_board[1, 6] = Int32.Parse(square16Box.Text);
            b.m_board[1, 7] = Int32.Parse(square17Box.Text);
            b.m_board[1, 8] = Int32.Parse(square18Box.Text);
            b.m_board[2, 0] = Int32.Parse(square20Box.Text);
            b.m_board[2, 1] = Int32.Parse(square21Box.Text);
            b.m_board[2, 2] = Int32.Parse(square22Box.Text);
            b.m_board[2, 3] = Int32.Parse(square23Box.Text);
            b.m_board[2, 4] = Int32.Parse(square24Box.Text);
            b.m_board[2, 5] = Int32.Parse(square25Box.Text);
            b.m_board[2, 6] = Int32.Parse(square26Box.Text);
            b.m_board[2, 7] = Int32.Parse(square27Box.Text);
            b.m_board[2, 8] = Int32.Parse(square28Box.Text);
            b.m_board[3, 0] = Int32.Parse(square30Box.Text);
            b.m_board[3, 1] = Int32.Parse(square31Box.Text);
            b.m_board[3, 2] = Int32.Parse(square32Box.Text);
            b.m_board[3, 3] = Int32.Parse(square33Box.Text);
            b.m_board[3, 4] = Int32.Parse(square34Box.Text);
            b.m_board[3, 5] = Int32.Parse(square35Box.Text);
            b.m_board[3, 6] = Int32.Parse(square36Box.Text);
            b.m_board[3, 7] = Int32.Parse(square37Box.Text);
            b.m_board[3, 8] = Int32.Parse(square38Box.Text);
            b.m_board[4, 0] = Int32.Parse(square40Box.Text);
            b.m_board[4, 1] = Int32.Parse(square41Box.Text);
            b.m_board[4, 2] = Int32.Parse(square42Box.Text);
            b.m_board[4, 3] = Int32.Parse(square43Box.Text);
            b.m_board[4, 4] = Int32.Parse(square44Box.Text);
            b.m_board[4, 5] = Int32.Parse(square45Box.Text);
            b.m_board[4, 6] = Int32.Parse(square46Box.Text);
            b.m_board[4, 7] = Int32.Parse(square47Box.Text);
            b.m_board[4, 8] = Int32.Parse(square48Box.Text);
            b.m_board[5, 0] = Int32.Parse(square50Box.Text);
            b.m_board[5, 1] = Int32.Parse(square51Box.Text);
            b.m_board[5, 2] = Int32.Parse(square52Box.Text);
            b.m_board[5, 3] = Int32.Parse(square53Box.Text);
            b.m_board[5, 4] = Int32.Parse(square54Box.Text);
            b.m_board[5, 5] = Int32.Parse(square55Box.Text);
            b.m_board[5, 6] = Int32.Parse(square56Box.Text);
            b.m_board[5, 7] = Int32.Parse(square57Box.Text);
            b.m_board[5, 8] = Int32.Parse(square58Box.Text);
            b.m_board[6, 0] = Int32.Parse(square60Box.Text);
            b.m_board[6, 1] = Int32.Parse(square61Box.Text);
            b.m_board[6, 2] = Int32.Parse(square62Box.Text);
            b.m_board[6, 3] = Int32.Parse(square63Box.Text);
            b.m_board[6, 4] = Int32.Parse(square64Box.Text);
            b.m_board[6, 5] = Int32.Parse(square65Box.Text);
            b.m_board[6, 6] = Int32.Parse(square66Box.Text);
            b.m_board[6, 7] = Int32.Parse(square67Box.Text);
            b.m_board[6, 8] = Int32.Parse(square68Box.Text);
            b.m_board[7, 0] = Int32.Parse(square70Box.Text);
            b.m_board[7, 1] = Int32.Parse(square71Box.Text);
            b.m_board[7, 2] = Int32.Parse(square72Box.Text);
            b.m_board[7, 3] = Int32.Parse(square73Box.Text);
            b.m_board[7, 4] = Int32.Parse(square74Box.Text);
            b.m_board[7, 5] = Int32.Parse(square75Box.Text);
            b.m_board[7, 6] = Int32.Parse(square76Box.Text);
            b.m_board[7, 7] = Int32.Parse(square77Box.Text);
            b.m_board[7, 8] = Int32.Parse(square78Box.Text);
            b.m_board[8, 0] = Int32.Parse(square80Box.Text);
            b.m_board[8, 1] = Int32.Parse(square81Box.Text);
            b.m_board[8, 2] = Int32.Parse(square82Box.Text);
            b.m_board[8, 3] = Int32.Parse(square83Box.Text);
            b.m_board[8, 4] = Int32.Parse(square84Box.Text);
            b.m_board[8, 5] = Int32.Parse(square85Box.Text);
            b.m_board[8, 6] = Int32.Parse(square86Box.Text);
            b.m_board[8, 7] = Int32.Parse(square87Box.Text);
            b.m_board[8, 8] = Int32.Parse(square88Box.Text);
        }

        //Checks if only numbers are input into the form
        private bool isBoardValid()
        {
            bool output = true;
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    if (!(int.TryParse(c.Text, out int x)) || x > 9 || x < 0)
                    {
                        output = false;
                    }
                }
            }
            return output;
        }


        //creates a random board for user to solve
        private void GenerateBoardButton_Click(object sender, EventArgs e)
        {
            BoardModel b = new BoardModel();

            //Generates a fully filled random board
            b.generateFilledBoard();

            //Removes random squares from the filled board
            b.removeIndices();

            //Displays b in the form
            boardToForm(b);
        }

        //checks if entered solution to generated board is correct
        private void CheckSolutionButton_Click(object sender, EventArgs e)
        {
            BoardModel b = new BoardModel();
            formToBoard(b);

            if (b.checkSolution())
                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Sorry, your guess was incorrect.\n" +
                    "Please make sure that you did not modify any generated numbers.");
        }

        //solves the board entered into the form using recursive backtracking solver
        private void SolveButton_Click(object sender, EventArgs e)
        {
            if (isBoardValid())
            {
                //BoardModel to capture board inputs
                BoardModel b = new BoardModel();
                formToBoard(b);

                //If b is a legal board
                if (b.isValid())
                {
                    //Solve b, if it's solvable, display the resulting solved board, otherwise
                    //display an unsolvable message
                    if (b.solve())
                    {
                        boardToForm(b);
                    }
                    else
                    {
                        MessageBox.Show("Entered puzzle is unsolvable");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid board.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid board.");
            }
        }

        //sets all numbers in board to 0
        private void ResetButton_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "0";
                }
            }
        }
    }



}