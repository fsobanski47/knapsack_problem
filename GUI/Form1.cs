using Knapsack;

namespace GUI
{
    public partial class Form1 : Form
    {
        int number;
        int seed;
        int capacity;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numberOfItems_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(numberOfItemsTB.Text, out number))
            {
                if (number < 1)
                {
                    numberOfItemsTB.BackColor = Color.Red;
                }
                else numberOfItemsTB.BackColor = Color.White;
            }
            else numberOfItemsTB.BackColor = Color.Red;

        }

        private void seedTB_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(seedTB.Text, out seed))
            {
                seedTB.BackColor = Color.Red;
            }
            else seedTB.BackColor = Color.White;
        }

        private void capacityTB_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(capacityTB.Text, out capacity))
            {
                if (capacity < 1)
                {
                    capacityTB.BackColor = Color.Red;
                }
                else capacityTB.BackColor = Color.White;
            }
            else capacityTB.BackColor = Color.Red;

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (number > 1 && capacity > 1 && seedTB.BackColor == Color.White)
            {
                Problem problem = new(number, seed);
                Result result = problem.Solve(capacity);
                instanceTB.Text = problem.ToString();
                resultTB.Text = result.ToString();
            }
        }

    }
}
