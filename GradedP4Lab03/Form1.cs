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
    public partial class Form1 : Form
    {

        TableLayoutPanel map = new TableLayoutPanel();
        int rows = 4;
        int cols = 4;


        public Form1()
        {
            InitializeComponent();
        }

        private void startGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Close Application",MessageBoxButtons.OKCancel);
             if (result == DialogResult.OK){
              Application.Exit();
             }
            
        }

       
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
         



             map.Dock = DockStyle.Fill;
            
            map.ColumnStyles.Clear();
            map.RowStyles.Clear();
            //set number of rows and columns +2 for menubar and tool strip
            map.RowCount = rows + 2;
            map.ColumnCount = cols;
            //set row for toolStrip menustrip=24px tall
            map.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24));
           
            for (int i = 1; i <= rows; i++)
            {
                map.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60));
            }
            for (int i = 1; i <= cols; i++)
            {
                map.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60));
            }
           
            //set row for toolStrip toolStrip=24px tall
            map.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25));
            this.Controls.Add(map);
 
            //list for storing possible co-ordinates (MENUSTRIP TAKES UP 1ST ROW! & TOOLSTIP lAST ROW)
            List<Point> possible = new List<Point> { };
            for (int i = 0; i < cols; i++)
            {
                for (int j = 1; j <= rows; j++)
                {
                    possible.Add(new Point(i, j));
                }
            }
            Random rnd = new Random();
            //If they exist, remove old game controls
            map.Controls.Clear();

            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    //Create a button
                    Button b = new Button();
                    b.Name = i.ToString() + j.ToString();
                    b.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular);
                    //b.Tag = l;
                    b.Text = "";
                    b.Dock = DockStyle.Fill;
                    //b.Click += buttonClicked;
                    //Create a panel with a button overlapping a label and add to same cell
                    var panel = new Panel();

                    int used = rnd.Next(possible.Count);
                    Point xy = possible[used];
                    possible.Remove(xy);
                    map.Controls.Add(panel, xy.X, xy.Y);

                    panel.Dock = DockStyle.Fill;
                    panel.Controls.Add(b);
                    //panel.Controls.Add(l);

                    //make window proper size
                    this.Width = 60 * cols + 15;
                    this.Height = 24 + 25 + (60 * rows) + 35;
                }
            }
            /*for (int i = 0; i < 16; i++)
            {
                Button button = new Button();
                button.Dock = DockStyle.Fill;
                button.BackColor = Color.Pink;
                button.Height = 60;
                button.Width = 60; 
            }*/
        }


       

       

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            Options op = new Options();
            op.ShowDialog();
        }
      
    }
}

