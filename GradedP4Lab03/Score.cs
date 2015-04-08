using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradedP4Lab03
{
    public class Score
    {
        private int time;
        private string name;

        public ListViewItem create_item()
        {
            ListViewItem item = new ListViewItem(new[] { this.Name, string.Format("{0:00}:{1:00}:{2:00}", this.Time / 3600, (this.Time / 60) % 60, this.Time % 60) });
            return item;
        }
        public int Time
        {
            get
            {
                return time;
            }
            set
            {
                time = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public static int CompareTimes(Score score1, Score score2)
        {
            return score1.Time.CompareTo(score2.Time);
        }

    }
}
