using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace GradedP4Lab03
{
    public partial class Form1 : Form
    {
        
        //public TableLayoutPanel board = new TableLayoutPanel();
        private List<Field> cells = new List<Field>();
        Timer time = new Timer();
        Timer second_timer = new Timer();

        public static int fields_remaining;
        public static int mines_displayed;
        public static int mines_remaining;

        public static bool won = false;
        public static bool lost = false;
        private static bool timers_added = false;

        private int game_time = 0;

       // int rows = 4;
       //int cols = 4;
       


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
            //board.SuspendLayout();
            CreateGame(Options.height, Options.width);
            //board.ResumeLayout();
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
            List<Field> mine_fields = new List<Field>();
            List<int> list = GetMinesIndxes(rows, cols, Options.mines);

            
            board.Dock = DockStyle.Fill;
           

            TimerEx();

            //Cleaning the currebt board
            cells.Clear();
            panelBase.Controls.Clear();
            board.ColumnStyles.Clear();
            board.RowStyles.Clear();
            board.Controls.Clear();

            //set number of rows and columns 
            board.RowCount = rows;
            board.ColumnCount = cols;

            for (int i = 1; i <= rows; i++)
            {
                board.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60));
            }
            for (int i = 1; i <= cols; i++)
            {
                board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60));
            }


            for (int i = 0; i < rows; i++){
                for (int j = 0; j < cols; j++){
                    
                    //Create a button
                    Field b = new Field();

                    int index = Field.GetIndex(i, j, Options.width);

                    b.SetCol(j); 
                    b.SetRow(i);
                    b.index = index;
                    b.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular);
                   
                    cells.Add(b); //adding by indexes one by one

                   try
                    {
                        if (index == list[0])
                        {
                            b.SetMine();
                            mine_fields.Add(b);
                            list.RemoveAt(0);
                        }
                    }
                    catch {}
                    board.Controls.Add(b, j/*column*/, i); // i  - rows , j - colums
                }
            }

            //make window proper size
            this.Width = 60 * cols + 15;
            this.Height = 24 + 25 + (60 * rows) + 35;

           

            panelBase.Controls.Add(board);

            //Set label counts : 
            //for every get nei list 
            foreach (Field f in mine_fields) {
                GetNei(f);
             }
           
        }


        private void GetNei(Field b) 
        {
            int col = b.GetCol();
            int row = b.GetRow();
            int idx  = 0 ; 
           //left
           if ( col - 1 >= 0) {
               idx = Field.GetIndex(row, col-1 , Options.width);
               //nei.Add(cells[idx]);
                if(cells[idx].HasMine() == false){
                        cells[idx].count += 1 ;
                    }
           }
                
            
            //right
            if(col + 1 < Options.width){
                idx = Field.GetIndex(row, col + 1, Options.width);
                //nei.Add(cells[idx]);     
                if (cells[idx].HasMine() == false)
                {
                    cells[idx].count += 1;
                }
            }

            //top
           if (row - 1 >= 0 )
            {
                idx = Field.GetIndex(row - 1, col, Options.width);
                //nei.Add(cells[idx]);
                if (cells[idx].HasMine() == false)
                {
                    cells[idx].count += 1;
                }
            }
            //top left
            if (col - 1 >= 0 && row -1>=0)
            {
                idx = Field.GetIndex(row - 1, col - 1, Options.width);
                //nei.Add(cells[idx]);
                if (cells[idx].HasMine() == false)
                {
                    cells[idx].count += 1;
                }
            }
            
            //top right
            if(col+1 < Options.width && row - 1 >= 0 )
            {
                idx = Field.GetIndex(row - 1 , col + 1, Options.width);
                //nei.Add(cells[idx]);
                if (cells[idx].HasMine() == false)
                {
                    cells[idx].count += 1;
                }
            }
            //bottom
           if(row +1 < Options.height)
            {
                idx = Field.GetIndex(row+1, col , Options.width);
                //nei.Add(cells[idx]);
                if (cells[idx].HasMine() == false)
                {
                    cells[idx].count += 1;
                }
            }
            
            //bottom left
            if(col - 1>=0 && row + 1 < Options.height){
                idx = Field.GetIndex(row+1 , col -1, Options.width);
               // nei.Add(cells[idx]);
                if (cells[idx].HasMine() == false)
                {
                    cells[idx].count += 1;
                }
            }
            
            //bottom right
            if(row + 1 < Options.width && col+1 < Options.height) {
                idx = Field.GetIndex(row + 1 , col + 1, Options.width);
                //nei.Add(cells[idx]) ; 
                if (cells[idx].HasMine() == false)
                {
                    cells[idx].count += 1 ;
                }
            }
             //return nei; 
        }


        private void ChangeNeighborsMineCount(int x, int y, int width, int height) { 
            
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            Options op = new Options();
            op.ShowDialog();
        }

       

        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            DialogResult msgresult = MessageBox.Show("Are You sure?", "Quit?", MessageBoxButtons.OKCancel);

            if (msgresult == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void highScoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HighScores h = new HighScores();
            h.ShowDialog();
        }


        //for timer event 
        private void time_Tick(object sender, EventArgs e)
        {
            if (sender == time)
            {
                MinesToolStrip.Text = "Mines left: " + mines_displayed.ToString();
                if (fields_remaining == 0)
                {
                    time.Stop();
                    second_timer.Stop();
                    MessageBox.Show(this, "You won!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Score score = new Score();
                    score.Time = game_time;
                    score.Name = Options.GetName();
                    HighScores.add_score(score);
                    foreach (Field field in cells)
                    {
                        field.button.MouseDown -= field.Field_Click;
                    }
                }
                if (lost)
                {
                    time.Stop();
                    second_timer.Stop();
                    MessageBox.Show(this, "You lost!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    foreach (Field field in cells)
                    {
                        field.button.MouseDown -= field.Field_Click;
                    }

                }
            }
            else
            {
                ++game_time;
                TimeLabel.Text = string.Format("{0:00}:{1:00}:{2:00}", game_time / 3600, (game_time / 60) % 60, game_time % 60);
            }

        }


        //For game start timer!
        private void TimerEx(){
            game_time = 0;
            if (!timers_added)
            {
                timers_added = true;
                time.Tick += time_Tick;
                second_timer.Tick += time_Tick;
            }
            second_timer.Interval = 1000;
            second_timer.Start();
            time.Start();
            mines_remaining = mines_displayed = Options.mines;
            
            won = false;
            lost = false;

            MinesToolStrip.Text = "Mines left: " + Options.GetMines().ToString();

           fields_remaining = Options.width * Options.height - mines_remaining;

           TimeLabel.Text = "00:00:00";
        }

       
        private void statusStrip1_SizeChanged(object sender, EventArgs e)
        {
           TimeLabel.Margin = new Padding((this.Width - 160), 0, 0, 0);
        }

        private void startGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}

