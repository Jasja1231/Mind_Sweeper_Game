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

    private bool isMine = false;

    public bool HasMine() {
        return isMine; 
    }
    

    private int column;
    private int row;

    public int mine_count = 0;

    
     public Field()
        {
         this.button.MouseDown += Field_Click;

         this.button.Text = "";
         this.button.Dock = DockStyle.Fill;

         this.Dock = DockStyle.Fill;
         this.Controls.Add(button);

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


    //Required parameters : Row , Column , Width 
    public static int GetIndex(int rowx, int co, int width)
    {
        return rowx * width + co;
    }

    //when button pressed
    private void Field_Click(object sender, EventArgs e)
    {
        MouseEventArgs m = (MouseEventArgs)e;
        if (m.Button == MouseButtons.Right) {
                button.BackColor = System.Drawing.Color.Red;            
            }
        else { 
            this.Controls.Clear();
            if (this.count > 0 && !isMine) {
                label.Dock = DockStyle.Fill;
                label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                label.Text = count.ToString();
            }
          // else
          //  label.Text =  row.ToString() + " " + column.ToString() + " i:" + GetIndex(row, column, Options.width).ToString();
            this.Controls.Add(label);
        }
      }

    private void CheckNeighbors(TableLayoutPanel board){
    
    
    }



    }
}
