using System;
using System.Windows.Forms;

namespace FIFA2077
{
    public partial class Form1 : Form
    {
        private readonly Match match;

        public Form1()
        {
            InitializeComponent();
            match = new Match();
            dataGridView1.RowCount = 9;
            Tools.InitGrid(dataGridView1);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            PlayNextDay.Visible = false;
        }


        private void CreateBtn_Click(object sender, EventArgs e)
        {
            Tools.InitGrid(dataGridView1);
            match.Day = 0;
            bool flag = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToString(row.Cells["Team"].Value) == string.Empty)
                    flag = true;
            }

            if (flag)
                MessageBox.Show(@"Teams column is empty!");
            else
            {
                dataGridView1.ReadOnly = true;
                for (int i = 0; i < dataGridView1.ColumnCount + 1; i++)
                {
                    dataGridView1["AvgGoals", i].Value = Tools.GenerateRandomAvg();
                }

                CreateBtn.Visible = false;
                PlayNextDay.Visible = true;
            }
        }

        private void PlayNextDay_Click(object sender, EventArgs e)
        {
            if (match.Day < 7)
            {
                match.ListMatches(dataGridView1);
                dayLbl.Text = @"Day: " + match.Day;
            }
            else
            {
                PlayNextDay.Visible = false;
                CreateBtn.Visible = true;
                dataGridView1.ReadOnly = false;
                winnerLbl.Text = @"WINNER - " + Match.GetWinner(dataGridView1) + @" !";
            }
        }
    }

    public static class Tools
    {
        private static Random random = new Random();

        public static double GenerateRandomAvg()
        {
            return Math.Round(random.NextDouble() * 2, 1);
        }

        private static double GenerateDouble()
        {
            return random.NextDouble();
        }

        public static int GetTeamScore(double lambda)
        {
            int m = 0;
            double S = 0;
            while (S >= -lambda)
            {
                double alpha = GenerateDouble();
                S += Math.Log(alpha);
                m++;
            }

            return m;
        }

        public static void InitGrid(DataGridView dataGrid)
        {
            Console.WriteLine(dataGrid.RowCount);
            Console.WriteLine(dataGrid.ColumnCount);
            for (int i = 0; i < dataGrid.RowCount; i++)
            {
                for (int j = 1; j < dataGrid.ColumnCount - 1; j++)
                {
                    dataGrid[j, i].Value = .0f;
                }
            }
        }
    }
}