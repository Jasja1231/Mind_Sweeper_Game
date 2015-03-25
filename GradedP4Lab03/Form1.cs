using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace GradedP4Lab03
{
    public partial class Form1 : Form
    {
        
        public TableLayoutPanel board = new TableLayoutPanel();
        private List<Field> cells = new List<Field>();

        int rows = 4;
        int cols = 4;
       


        public Form1()
        {
            InitializeComponent();
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
            board.SuspendLayout();
            CreateGame(Options.height, Options.width);
            board.ResumeLayout();
        }
        //Get mines index
        private List<int> GetMinesIndxes(int h  , int w , int mines){
            List<int> l  = new List<int>();
            var r = new Random();
            for (int i = 0; i < mines; i++) { 
                int rand = r.Next(0 , h*w);
                if (!l.Contains(rand))
                    l.Add(rand);
                else
                    i--;
            }
            l.Sort();  //????????????????????????????????????????????
            return l;
        }
          
        

        private void CreateGame(int rows, int cols) {
            board.Dock = DockStyle.Fill;
            List<int> list = GetMinesIndxes(rows  , cols  , Options.mines);
            //Cleaning the currebt board
            board.ColumnStyles.Clear();
            board.RowStyles.Clear();

            //set number of rows and columns +2 for menubar and tool strip
            board.RowCount = rows + 2;
            board.ColumnCount = cols;
            //set row for toolStrip menustrip=24px tall
            board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24));

            for (int i = 1; i <= rows; i++)
            {
                board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60));
            }
            for (int i = 1; i <= cols; i++)
            {
                board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60));
            }

            //set row for toolStrip toolStrip=24px tall
            board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25));
            this.Controls.Add(board);

            
            //If they exist, remove old game controls
            board.Controls.Clear();

            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j <= rows; j++)
                {
                    //Create a button
                    Field b = new Field();
                    cells.Add(b);  //adding by indexes
                    b.SetX(i); // cols
                    b.SetY(j); // rows

                    int index = b.GetIndex(j , i , Options.width);
                    try
                    {
                        if (index == list[0])
                        {
                            b.SetMine();
                            list.RemoveAt(0);
                        }
                    }
                    catch { }
                    b.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular);
                    
                    board.Controls.Add(b, j, i);

                    //make window proper size
                    this.Width = 60 * cols + 15;
                    this.Height = 24 + 25 + (60 * rows) + 35;
                }
            }
        }

        private void ChangeNeighborsMineCount(int x, int y, int width, int height) { 
            
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            Options op = new Options();
            op.ShowDialog();
        }

        private void startGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
      
    }
}

