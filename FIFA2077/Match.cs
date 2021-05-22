using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FIFA2077
{
    public class Match
    {
        public int Day = 0;

        private static int _p1 = 0;
        private readonly List<string> _teamMirror1 = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7" };
        private readonly List<string> _teamMirror2 = new List<string>() { "1", "2", "3", "4", "5", "6", "7" };

        private static void PlayMatch(DataGridViewRow firstTeam, DataGridViewRow secondTeam)
        {
            int firstTeamScore = Tools.GetTeamScore((double)firstTeam.Cells["AvgGoals"].Value);
            int secondTeamScore = Tools.GetTeamScore((double)secondTeam.Cells["AvgGoals"].Value);

            firstTeam.Cells["Goals"].Value = Convert.ToInt32(firstTeam.Cells["Goals"].Value) + firstTeamScore;
            secondTeam.Cells["Goals"].Value = Convert.ToInt32(secondTeam.Cells["Goals"].Value) + secondTeamScore;

            if (firstTeamScore > secondTeamScore)
            {
                firstTeam.Cells["Wins"].Value = Convert.ToInt32(firstTeam.Cells["Wins"].Value) + 1;
                firstTeam.Cells["Score"].Value = Convert.ToInt32(firstTeam.Cells["Score"].Value) + 3;
                secondTeam.Cells["Looses"].Value = Convert.ToInt32(secondTeam.Cells["Looses"].Value) + 1;
            }
            else if (firstTeamScore < secondTeamScore)

            {
                secondTeam.Cells["Wins"].Value = Convert.ToInt32(secondTeam.Cells["Wins"].Value) + 1;
                secondTeam.Cells["Score"].Value = Convert.ToInt32(secondTeam.Cells["Score"].Value) + 3;
                firstTeam.Cells["Looses"].Value = Convert.ToInt32(firstTeam.Cells["Looses"].Value) + 1;
            }
            else
            {
                firstTeam.Cells["Score"].Value = Convert.ToInt32(firstTeam.Cells["Score"].Value) + 1;
                secondTeam.Cells["Score"].Value = Convert.ToInt32(secondTeam.Cells["Score"].Value) + 1;
                firstTeam.Cells["Draws"].Value = Convert.ToInt32(firstTeam.Cells["Draws"].Value) + 1;
                secondTeam.Cells["Draws"].Value = Convert.ToInt32(secondTeam.Cells["Draws"].Value) + 1;
            }
        }

        public static string GetWinner(DataGridView standings)
        {
            int max = 0;
            List<int> indexes = new List<int>();
            for (int i = 0; i < standings.RowCount; i++)
            {
                if (max < Convert.ToInt32(standings.Rows[i].Cells["Score"].Value))
                {
                    max = Convert.ToInt32(standings.Rows[i].Cells["Score"].Value);
                }
            }

            for (int i = 0; i < standings.RowCount; i++)
            {
                if (max == Convert.ToInt32(standings.Rows[i].Cells["Score"].Value))
                {
                    indexes.Add(i);
                }
            }

            if (indexes.Count == 1)
            {
                return standings.Rows[indexes[0]].Cells["Team"].Value.ToString();
            }
            else
            {
                max = 0;
                int index = 0;
                foreach (var i in indexes.Where(i => max < Convert.ToInt32(standings.Rows[i].Cells["Goals"].Value)))
                {
                    max = Convert.ToInt32(standings.Rows[i].Cells["Goals"].Value);
                    index = i;
                }

                return standings.Rows[index].Cells["Team"].Value.ToString();
            }
        }

        public void ListMatches(DataGridView mat)
        {
            Console.WriteLine("Day {0}", (Day + 1));
            int teamIdx = Day % 7;
            PlayMatch(mat.Rows[Convert.ToInt32(_teamMirror2[teamIdx])], (mat.Rows[Convert.ToInt32(_teamMirror1[0])]));
            Console.WriteLine("{0} vs {1}", _teamMirror2[teamIdx], _teamMirror1[0]);

            for (int idx = 1; idx < 4; idx++)
            {
                int firstTeam = (Day + idx) % 7;
                int secondTeam = (Day + 7 - idx) % 7;
                Console.WriteLine("{0} vs {1}", _teamMirror2[firstTeam], _teamMirror2[secondTeam]);
                PlayMatch(mat.Rows[Convert.ToInt32(_teamMirror2[teamIdx])], (mat.Rows[Convert.ToInt32(_teamMirror1[secondTeam])]));
            }

            Day++;
        }
    }
}
