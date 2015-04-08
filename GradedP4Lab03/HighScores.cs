using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradedP4Lab03
{
    public partial class HighScores : Form
    {

        private void HighScores_Load(object sender, EventArgs e)
        {
            //window for scores
            this.Dock = DockStyle.Fill;
            this.FormBorderStyle = FormBorderStyle.FixedSingle; 
        }

        private static List<Score> scores = new List<Score>(10);

        public HighScores()
        {
            InitializeComponent();
            listView.Items.Clear();
            listView.View = View.Details;
            scores.Sort(Score.CompareTimes);

            foreach (Score score in scores)
            {
                ListViewItem item = score.create_item();
                listView.Items.Add(item);
            }
        }
        public static void add_score(Score score)
        {

            if (scores.Count < 10)
                scores.Add(score);

            else if (score.Time < scores.ElementAt(scores.Count - 1).Time && scores.Count == 10)
            {
                scores.Sort(Score.CompareTimes);
                scores.RemoveAt(scores.Count - 1);
                scores.Add(score);
            }

        }


 
    }
}

