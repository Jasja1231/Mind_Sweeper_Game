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

    bool mine = false;

    private int x;
    private int y;

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
         mine = true;
     }

     public int GetX() { return x; }
     public int GetY() { return y; }

     public void SetX(int x1) { x = x1;}
     public void SetY(int y1) { y = y1;}

    public int GetIndex(int x, int y, int width)
    {
        return y * width + x;
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
        
            this.Controls.Add(label);
        }
      }

    private void CheckNeighbors(TableLayoutPanel board){
    
    
    }



    }
}
