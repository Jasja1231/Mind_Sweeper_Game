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
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        public static int height = 4;
        public static int width = 4;
        public static int mines = 1;


        public static int GetMines() { return mines; }
        public static string name = "Anonymous";

        public static string GetName() { return name; }

        private void Options_Load(object sender, EventArgs e)
        {
            nameBox.Text = name;
            Cancel.Click += new EventHandler(Cancel_Click);
            Confirm.Click += new EventHandler(Confirm_Click);
        }

        protected void Cancel_Click(object sender, EventArgs e) {
            this.Close();
        }


        

        protected void Show_Error() {
            DialogResult result = MessageBox.Show("Values are wrong", "", MessageBoxButtons.OK);
        }

        protected void Confirm_Click(object sender, EventArgs e)
        {
            if (NonStanrdard.Checked) { 
                try {
                    int test_height = int.Parse(inputBox1.Text);
                    int test_width = int.Parse(inputBox2.Text);
                    int test_mines = int.Parse(inputBox3.Text);
                
                    if (!Enumerable.Range(1, 15).Contains(test_height) || !Enumerable.Range(1, 15).Contains(test_width) || !Enumerable.Range(0, test_height * test_width).Contains(test_mines)) {
                        ApplicationException CustomException = new ApplicationException();  
                        throw CustomException;
                    }

                    width = test_width;
                    height = test_height;
                    mines = test_mines;
                }
                catch{
                    Show_Error();
                }
           }
            name = nameBox.Text;
            this.Close();
        }

       
        private void NonStanrdard_CheckedChanged(object sender, EventArgs e)
        {
            label1.Enabled = !label1.Enabled;
            label2.Enabled = !label2.Enabled;
            label3.Enabled = !label3.Enabled;

            inputBox1.Enabled = !inputBox1.Enabled;
            inputBox2.Enabled = !inputBox2.Enabled;
            inputBox3.Enabled = !inputBox3.Enabled;
       }

        private void Beginner_CheckedChanged(object sender, EventArgs e)
        {
            height = 4;
            width = 6;
            mines = 1;
        }

        private void Intermediate_CheckedChanged(object sender, EventArgs e)
        {
            height = 8;
            width = 8;
            mines = 12;
        }

        private void Hard_CheckedChanged(object sender, EventArgs e)
        {
            height = 10;//options
            width = 10;
            mines = 50;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
