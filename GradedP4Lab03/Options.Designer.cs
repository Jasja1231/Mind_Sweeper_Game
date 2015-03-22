namespace GradedP4Lab03
{
    partial class Options
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputBox1 = new System.Windows.Forms.TextBox();
            this.inputBox2 = new System.Windows.Forms.TextBox();
            this.inputBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NonStanrdard = new System.Windows.Forms.RadioButton();
            this.Difficulty = new System.Windows.Forms.GroupBox();
            this.Beginner = new System.Windows.Forms.RadioButton();
            this.Hard = new System.Windows.Forms.RadioButton();
            this.Intermediate = new System.Windows.Forms.RadioButton();
            this.Confirm = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Difficulty.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputBox1
            // 
            this.inputBox1.Enabled = false;
            this.inputBox1.Location = new System.Drawing.Point(189, 51);
            this.inputBox1.Name = "inputBox1";
            this.inputBox1.Size = new System.Drawing.Size(100, 20);
            this.inputBox1.TabIndex = 0;
            // 
            // inputBox2
            // 
            this.inputBox2.Enabled = false;
            this.inputBox2.Location = new System.Drawing.Point(189, 77);
            this.inputBox2.Name = "inputBox2";
            this.inputBox2.Size = new System.Drawing.Size(100, 20);
            this.inputBox2.TabIndex = 1;
            // 
            // inputBox3
            // 
            this.inputBox3.Enabled = false;
            this.inputBox3.Location = new System.Drawing.Point(189, 103);
            this.inputBox3.Name = "inputBox3";
            this.inputBox3.Size = new System.Drawing.Size(100, 20);
            this.inputBox3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(148, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Height";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(148, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(148, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mines";
            // 
            // NonStanrdard
            // 
            this.NonStanrdard.AutoSize = true;
            this.NonStanrdard.Location = new System.Drawing.Point(151, 19);
            this.NonStanrdard.Name = "NonStanrdard";
            this.NonStanrdard.Size = new System.Drawing.Size(86, 17);
            this.NonStanrdard.TabIndex = 6;
            this.NonStanrdard.TabStop = true;
            this.NonStanrdard.Text = "Not standard";
            this.NonStanrdard.UseVisualStyleBackColor = true;
            this.NonStanrdard.CheckedChanged += new System.EventHandler(this.NonStanrdard_CheckedChanged);
            // 
            // Difficulty
            // 
            this.Difficulty.Controls.Add(this.Beginner);
            this.Difficulty.Controls.Add(this.Hard);
            this.Difficulty.Controls.Add(this.Intermediate);
            this.Difficulty.Controls.Add(this.inputBox1);
            this.Difficulty.Controls.Add(this.NonStanrdard);
            this.Difficulty.Controls.Add(this.inputBox2);
            this.Difficulty.Controls.Add(this.label3);
            this.Difficulty.Controls.Add(this.inputBox3);
            this.Difficulty.Controls.Add(this.label2);
            this.Difficulty.Controls.Add(this.label1);
            this.Difficulty.Location = new System.Drawing.Point(12, 12);
            this.Difficulty.Name = "Difficulty";
            this.Difficulty.Size = new System.Drawing.Size(295, 153);
            this.Difficulty.TabIndex = 7;
            this.Difficulty.TabStop = false;
            this.Difficulty.Text = "groupBox1";
            this.Difficulty.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Beginner
            // 
            this.Beginner.AutoSize = true;
            this.Beginner.Checked = true;
            this.Beginner.Location = new System.Drawing.Point(6, 31);
            this.Beginner.Name = "Beginner";
            this.Beginner.Size = new System.Drawing.Size(67, 17);
            this.Beginner.TabIndex = 7;
            this.Beginner.TabStop = true;
            this.Beginner.Text = "Beginner";
            this.Beginner.UseVisualStyleBackColor = true;
            // 
            // Hard
            // 
            this.Hard.AutoSize = true;
            this.Hard.Location = new System.Drawing.Point(6, 77);
            this.Hard.Name = "Hard";
            this.Hard.Size = new System.Drawing.Size(48, 17);
            this.Hard.TabIndex = 9;
            this.Hard.TabStop = true;
            this.Hard.Text = "Hard";
            this.Hard.UseVisualStyleBackColor = true;
            // 
            // Intermediate
            // 
            this.Intermediate.AutoSize = true;
            this.Intermediate.Location = new System.Drawing.Point(6, 54);
            this.Intermediate.Name = "Intermediate";
            this.Intermediate.Size = new System.Drawing.Size(83, 17);
            this.Intermediate.TabIndex = 8;
            this.Intermediate.TabStop = true;
            this.Intermediate.Text = "Intermediate";
            this.Intermediate.UseVisualStyleBackColor = true;
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(145, 213);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(75, 23);
            this.Confirm.TabIndex = 8;
            this.Confirm.Text = "OK";
            this.Confirm.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(226, 213);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 9;
            this.Cancel.Text = "Calcel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Name : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 175);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Anonymous";
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(319, 252);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.Difficulty);
            this.MaximumSize = new System.Drawing.Size(335, 291);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(335, 291);
            this.Name = "Options";
            this.ShowInTaskbar = false;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.Difficulty.ResumeLayout(false);
            this.Difficulty.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBox1;
        private System.Windows.Forms.TextBox inputBox2;
        private System.Windows.Forms.TextBox inputBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton NonStanrdard;
        private System.Windows.Forms.GroupBox Difficulty;
        private System.Windows.Forms.RadioButton Hard;
        private System.Windows.Forms.RadioButton Beginner;
        private System.Windows.Forms.RadioButton Intermediate;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
    }
}