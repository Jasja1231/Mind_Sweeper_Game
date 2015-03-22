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

        private TextBox inputBox1;
        private TextBox inputBox2;
        private TextBox inputBox3;

        private void Options_Load(object sender, EventArgs e)
        {
            this.Width = 220;
            this.Height = 150;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.Text = "Options";

            Label textLabel1 = new Label() { Left = 0, Top = 20, Text = "Height", Width = 40 };
            inputBox1 = new TextBox() { Left = 50, Top = 20, Width = 120 };

            Label textLabel2 = new Label() { Left = 0, Top = 40, Text = "Width", Width = 40 };
            inputBox2 = new TextBox() { Left = 50, Top = 40, Width = 120 };

            Label textLabel3 = new Label() { Left = 0, Top = 60, Text = "Mines", Width = 40 };
            inputBox3 = new TextBox() { Left = 50, Top = 60, Width = 120 };

            Button Confirm  = new Button() { Text = "OK", Left = 10, Width = 80, Top = 85 };
            Button  cancel = new Button() { Text = "Cancel", Left = 100, Width = 80, Top = 85 };

            cancel.Click += new EventHandler(Cancel_Click);
            Confirm.Click += new EventHandler(Confirm_Click);

            this.Controls.Add(Confirm);
            this.Controls.Add(cancel);

            this.Controls.Add(textLabel1);
            this.Controls.Add(textLabel2);
            this.Controls.Add(textLabel3);

            this.Controls.Add(inputBox1);
            this.Controls.Add(inputBox2);
            this.Controls.Add(inputBox3);

        }

        protected void Cancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        protected void Show_Error() {
            DialogResult result = MessageBox.Show("Values are wrong", "", MessageBoxButtons.OK);
        }

        protected void Confirm_Click(object sender, EventArgs e)
        {
            
            try {
                int test_height = int.Parse(inputBox1.Text);
                int test_width = int.Parse(inputBox1.Text);
                int test_mines = int.Parse(inputBox1.Text);
                
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


    }
}
