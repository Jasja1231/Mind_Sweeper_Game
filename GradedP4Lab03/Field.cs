using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GradedP4Lab03
{
    class Field : Panel {
        //class for panel
  
    public Button button =  new Button();
    public Label label = new Label();
    public int count = 0; // for label set
    public int index = -1;
    public int mine_count = 0;
    public bool flag = false; //marked mine field )) 
    public bool check = false;

    public static bool run = false;
    public static Field curr;


    private int column;
    private int row;
    private bool isMine = false;

    public Field()
        {
         this.button.MouseDown += Field_Click;

         this.button.Text = "";
         this.button.Dock = DockStyle.Fill;

         this.Dock = DockStyle.Fill;
         this.Controls.Add(button);

         this.button.MouseEnter += Button_enter;
         this.button.MouseLeave += Button_leave;
        }


    private void Button_enter(object sender, EventArgs e) {
        Form f = this.FindForm();
        f.SuspendLayout();
        if(!flag)
            this.button.BackColor = System.Drawing.SystemColors.ActiveCaption;
        else if (flag)
            this.button.BackColor = System.Drawing.Color.OrangeRed;
        else if (HasMine())
            this.button.BackColor = System.Drawing.Color.Red;
        f.ResumeLayout();

    }

         private void Button_leave(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.SuspendLayout();
             if(!flag)
                this.button.ResetBackColor();
             else if (flag)
                 this.button.BackColor = System.Drawing.Color.Red;
            f.ResumeLayout();
        }
     public void SetMine() {
         label.Dock = DockStyle.Fill;
         label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         label.Text = "MINE";
         label.BackColor = System.Drawing.Color.Red;
         isMine = true;
 }

     public int GetCol() { return column; }
     public int GetRow() { return row; }
     public void SetCol(int val) { column = val; }
     public void SetRow(int val) { row    = val; }
     public bool HasMine() { return isMine; }
    

    //Required parameters : Row , Column , Width 
    public static int GetIndex(int rowx, int co, int width){return rowx * width + co;}


    public void Field_Pressed(){
        this.Controls.Remove(this.button);
        this.Controls.Add(this.label);
        Form1.fields_remaining--;
    }

    //when button pressed
    public  void Field_Click(object sender, EventArgs e)
    {
        MouseEventArgs m = (MouseEventArgs)e;
        //with Right button click we set flag over field 
        if (m.Button == MouseButtons.Right) {
            //if flag is already there 
            if (flag) {
                //return default color 
                button.BackColor = System.Windows.Forms.Button.DefaultBackColor;
                Form1.mines_displayed++;
                if (HasMine())
                    Form1.mines_remaining++;
                flag = !flag;
            }
            //if flag is not set
            else if (!flag) {
                flag = !flag;
                    //chande cover color to red
                    button.BackColor = System.Drawing.Color.Red;
                    //set number of possibly guessed mines less by one 
                    if (HasMine())
                    {
                        Form1.mines_displayed--;
                        Form1.mines_remaining--;
                    }
                    else
                    {
                        Form1.mines_displayed--;
                    }
                }
            }
        //left mouse button pressed
        else {
            if (!flag){
                this.Controls.Clear();
                if (!isMine && !flag) {
                    if (this.count > 0) {
                        //not  a mine and has a mine neightbor
                        label.Dock = DockStyle.Fill;
                        label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        label.Text = count.ToString();
                    }
                    else if (this.count == 0) { 
                        //USE OF RECURSION FUNCTION
                        curr = this;
                        run = true;
                      }
                    Form1.fields_remaining--;
                }
                else
                    if (HasMine()){
                        Form1.lost = true;
                    }
                this.Controls.Add(label);
            }
          }
      }
    
    }
}
