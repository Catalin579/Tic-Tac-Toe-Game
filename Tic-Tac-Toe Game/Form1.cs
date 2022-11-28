namespace Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {
        public enum Player
        {
            X, O
        }

        Player currentPLayer;
        Random random = new Random();
        int playerWinCount = 0;
        int CPUWinCount = 0;
        List<Button> buttons;

        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void CPUMOve(object sender, EventArgs e)
        {
            if (buttons.Count > 0)
            {
                int index = random.Next(buttons.Count);
                buttons[index].Enabled = false;
                currentPLayer = Player.O;
                buttons[index].Text = currentPLayer.ToString();
                buttons[index].BackColor = Color.Crimson;
                buttons.RemoveAt(index);
                CheckGame();
                CPUTimer.Stop();
            }
        }

        private void PlayerClickButton(object sender, EventArgs e)
        {
            var button = (Button)sender;
            currentPLayer = Player.X;
            button.Text = currentPLayer.ToString();
            button.Enabled = false;
            button.BackColor = Color.Cyan;
            buttons.Remove(button);
            CheckGame();
            CPUTimer.Start();
        }

        private void RestartGame(object sender, MouseEventArgs e)
        {
            RestartGame();
        }

        private void CheckGame()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X"
                || button4.Text == "X" && button5.Text == "X" && button6.Text == "X"
                || button7.Text == "X" && button8.Text == "X" && button9.Text == "X"
                || button1.Text == "X" && button5.Text == "X" && button9.Text == "X"
                || button3.Text == "X" && button5.Text == "X" && button7.Text == "X"
                || button3.Text == "X" && button6.Text == "X" && button9.Text == "X"
                || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
                || button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                CPUTimer.Stop();
                MessageBox.Show("Player Wins");
                playerWinCount++;
                label1.Text = "Player Wins: " + playerWinCount;
                RestartGame();
            }

            else if
                  (button1.Text == "O" && button2.Text == "O" && button3.Text == "O"
                || button4.Text == "O" && button5.Text == "O" && button6.Text == "O"
                || button7.Text == "O" && button8.Text == "O" && button9.Text == "O"
                || button1.Text == "O" && button5.Text == "O" && button9.Text == "O"
                || button3.Text == "O" && button5.Text == "O" && button7.Text == "O"
                || button3.Text == "O" && button6.Text == "O" && button9.Text == "O"
                || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
                || button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                CPUTimer.Stop();
                MessageBox.Show("CPU Wins");
                CPUWinCount++;
                label2.Text = "CPU Wins: " + CPUWinCount;
                RestartGame();
            }
        }

        private void RestartGame()
        {
            buttons = new List<Button> { button1, button2, button3, button4, button5,
                button6, button7, button8, button9, };

            foreach (Button button in buttons)
            {
                button.Enabled = true;
                button.Text = "?";
                button.BackColor = DefaultBackColor;
            }
        }
    }
}