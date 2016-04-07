namespace PC_Calculator_CSharp
{
    partial class frmCalculator
    {

        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculator));
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdSign = new System.Windows.Forms.Button();
            this.cmdInverse = new System.Windows.Forms.Button();
            this.cmdSqrRoot = new System.Windows.Forms.Button();
            this.cmdPowerOf = new System.Windows.Forms.Button();
            this.cmdEqual = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdDecimal = new System.Windows.Forms.Button();
            this.cmdSubtract = new System.Windows.Forms.Button();
            this.cmd8 = new System.Windows.Forms.Button();
            this.cmd9 = new System.Windows.Forms.Button();
            this.cmd4 = new System.Windows.Forms.Button();
            this.cmd5 = new System.Windows.Forms.Button();
            this.cmd6 = new System.Windows.Forms.Button();
            this.cmd1 = new System.Windows.Forms.Button();
            this.cmd2 = new System.Windows.Forms.Button();
            this.cmd3 = new System.Windows.Forms.Button();
            this.cmd0 = new System.Windows.Forms.Button();
            this.cmdMultiply = new System.Windows.Forms.Button();
            this.cmdDivide = new System.Windows.Forms.Button();
            this.cmd7 = new System.Windows.Forms.Button();
            this.cmdClearAll = new System.Windows.Forms.Button();
            this.cmdClearEntry = new System.Windows.Forms.Button();
            this.cmdBackspace = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.cmdSign);
            this.GroupBox2.Controls.Add(this.cmdInverse);
            this.GroupBox2.Controls.Add(this.cmdSqrRoot);
            this.GroupBox2.Controls.Add(this.cmdPowerOf);
            this.GroupBox2.Controls.Add(this.cmdEqual);
            this.GroupBox2.Controls.Add(this.cmdAdd);
            this.GroupBox2.Controls.Add(this.cmdDecimal);
            this.GroupBox2.Controls.Add(this.cmdSubtract);
            this.GroupBox2.Controls.Add(this.cmd8);
            this.GroupBox2.Controls.Add(this.cmd9);
            this.GroupBox2.Controls.Add(this.cmd4);
            this.GroupBox2.Controls.Add(this.cmd5);
            this.GroupBox2.Controls.Add(this.cmd6);
            this.GroupBox2.Controls.Add(this.cmd1);
            this.GroupBox2.Controls.Add(this.cmd2);
            this.GroupBox2.Controls.Add(this.cmd3);
            this.GroupBox2.Controls.Add(this.cmd0);
            this.GroupBox2.Controls.Add(this.cmdMultiply);
            this.GroupBox2.Controls.Add(this.cmdDivide);
            this.GroupBox2.Controls.Add(this.cmd7);
            this.GroupBox2.Controls.Add(this.cmdClearAll);
            this.GroupBox2.Controls.Add(this.cmdClearEntry);
            this.GroupBox2.Controls.Add(this.cmdBackspace);
            this.GroupBox2.Location = new System.Drawing.Point(12, 63);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(235, 187);
            this.GroupBox2.TabIndex = 7;
            this.GroupBox2.TabStop = false;
            // 
            // cmdSign
            // 
            this.cmdSign.Location = new System.Drawing.Point(61, 151);
            this.cmdSign.Name = "cmdSign";
            this.cmdSign.Size = new System.Drawing.Size(40, 30);
            this.cmdSign.TabIndex = 26;
            this.cmdSign.Text = "+/-";
            this.cmdSign.UseVisualStyleBackColor = true;
            this.cmdSign.Click += new System.EventHandler(this.cmdSign_Click);
            // 
            // cmdInverse
            // 
            this.cmdInverse.Location = new System.Drawing.Point(184, 122);
            this.cmdInverse.Name = "cmdInverse";
            this.cmdInverse.Size = new System.Drawing.Size(40, 30);
            this.cmdInverse.TabIndex = 25;
            this.cmdInverse.Text = "1/x";
            this.cmdInverse.UseVisualStyleBackColor = true;
            this.cmdInverse.Click += new System.EventHandler(this.cmdInverse_Click);
            // 
            // cmdSqrRoot
            // 
            this.cmdSqrRoot.Location = new System.Drawing.Point(184, 93);
            this.cmdSqrRoot.Name = "cmdSqrRoot";
            this.cmdSqrRoot.Size = new System.Drawing.Size(40, 30);
            this.cmdSqrRoot.TabIndex = 24;
            this.cmdSqrRoot.Text = "sqrt";
            this.cmdSqrRoot.UseVisualStyleBackColor = true;
            this.cmdSqrRoot.Click += new System.EventHandler(this.cmdSqrRoot_Click);
            // 
            // cmdPowerOf
            // 
            this.cmdPowerOf.Location = new System.Drawing.Point(184, 64);
            this.cmdPowerOf.Name = "cmdPowerOf";
            this.cmdPowerOf.Size = new System.Drawing.Size(40, 30);
            this.cmdPowerOf.TabIndex = 23;
            this.cmdPowerOf.Text = "x^";
            this.cmdPowerOf.UseVisualStyleBackColor = true;
            this.cmdPowerOf.Click += new System.EventHandler(this.cmdPowerOf_Click);
            // 
            // cmdEqual
            // 
            this.cmdEqual.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmdEqual.Location = new System.Drawing.Point(184, 151);
            this.cmdEqual.Name = "cmdEqual";
            this.cmdEqual.Size = new System.Drawing.Size(40, 30);
            this.cmdEqual.TabIndex = 22;
            this.cmdEqual.Text = "=";
            this.cmdEqual.UseVisualStyleBackColor = false;
            this.cmdEqual.Click += new System.EventHandler(this.cmdEqual_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(143, 151);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(40, 30);
            this.cmdAdd.TabIndex = 21;
            this.cmdAdd.Text = "+";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdDecimal
            // 
            this.cmdDecimal.Location = new System.Drawing.Point(102, 151);
            this.cmdDecimal.Name = "cmdDecimal";
            this.cmdDecimal.Size = new System.Drawing.Size(40, 30);
            this.cmdDecimal.TabIndex = 20;
            this.cmdDecimal.Text = ".";
            this.cmdDecimal.UseVisualStyleBackColor = true;
            this.cmdDecimal.Click += new System.EventHandler(this.cmdDecimal_Click);
            // 
            // cmdSubtract
            // 
            this.cmdSubtract.Location = new System.Drawing.Point(143, 122);
            this.cmdSubtract.Name = "cmdSubtract";
            this.cmdSubtract.Size = new System.Drawing.Size(40, 30);
            this.cmdSubtract.TabIndex = 19;
            this.cmdSubtract.Text = "-";
            this.cmdSubtract.UseVisualStyleBackColor = true;
            this.cmdSubtract.Click += new System.EventHandler(this.cmdSubtract_Click);
            // 
            // cmd8
            // 
            this.cmd8.Location = new System.Drawing.Point(61, 64);
            this.cmd8.Name = "cmd8";
            this.cmd8.Size = new System.Drawing.Size(40, 30);
            this.cmd8.TabIndex = 18;
            this.cmd8.Text = "8";
            this.cmd8.UseVisualStyleBackColor = true;
            this.cmd8.Click += new System.EventHandler(this.cmd8_Click);
            // 
            // cmd9
            // 
            this.cmd9.Location = new System.Drawing.Point(102, 64);
            this.cmd9.Name = "cmd9";
            this.cmd9.Size = new System.Drawing.Size(40, 30);
            this.cmd9.TabIndex = 17;
            this.cmd9.Text = "9";
            this.cmd9.UseVisualStyleBackColor = true;
            this.cmd9.Click += new System.EventHandler(this.cmd9_Click);
            // 
            // cmd4
            // 
            this.cmd4.Location = new System.Drawing.Point(20, 93);
            this.cmd4.Name = "cmd4";
            this.cmd4.Size = new System.Drawing.Size(40, 30);
            this.cmd4.TabIndex = 16;
            this.cmd4.Text = "4";
            this.cmd4.UseVisualStyleBackColor = true;
            this.cmd4.Click += new System.EventHandler(this.cmd4_Click);
            // 
            // cmd5
            // 
            this.cmd5.Location = new System.Drawing.Point(61, 93);
            this.cmd5.Name = "cmd5";
            this.cmd5.Size = new System.Drawing.Size(40, 30);
            this.cmd5.TabIndex = 15;
            this.cmd5.Text = "5";
            this.cmd5.UseVisualStyleBackColor = true;
            this.cmd5.Click += new System.EventHandler(this.cmd5_Click);
            // 
            // cmd6
            // 
            this.cmd6.Location = new System.Drawing.Point(102, 93);
            this.cmd6.Name = "cmd6";
            this.cmd6.Size = new System.Drawing.Size(40, 30);
            this.cmd6.TabIndex = 14;
            this.cmd6.Text = "6";
            this.cmd6.UseVisualStyleBackColor = true;
            this.cmd6.Click += new System.EventHandler(this.cmd6_Click);
            // 
            // cmd1
            // 
            this.cmd1.Location = new System.Drawing.Point(20, 122);
            this.cmd1.Name = "cmd1";
            this.cmd1.Size = new System.Drawing.Size(40, 30);
            this.cmd1.TabIndex = 13;
            this.cmd1.Text = "1";
            this.cmd1.UseVisualStyleBackColor = true;
            this.cmd1.Click += new System.EventHandler(this.cmd1_Click);
            // 
            // cmd2
            // 
            this.cmd2.Location = new System.Drawing.Point(61, 122);
            this.cmd2.Name = "cmd2";
            this.cmd2.Size = new System.Drawing.Size(40, 30);
            this.cmd2.TabIndex = 12;
            this.cmd2.Text = "2";
            this.cmd2.UseVisualStyleBackColor = true;
            this.cmd2.Click += new System.EventHandler(this.cmd2_Click);
            // 
            // cmd3
            // 
            this.cmd3.Location = new System.Drawing.Point(102, 122);
            this.cmd3.Name = "cmd3";
            this.cmd3.Size = new System.Drawing.Size(40, 30);
            this.cmd3.TabIndex = 11;
            this.cmd3.Text = "3";
            this.cmd3.UseVisualStyleBackColor = true;
            this.cmd3.Click += new System.EventHandler(this.cmd3_Click);
            // 
            // cmd0
            // 
            this.cmd0.Location = new System.Drawing.Point(20, 151);
            this.cmd0.Name = "cmd0";
            this.cmd0.Size = new System.Drawing.Size(40, 30);
            this.cmd0.TabIndex = 10;
            this.cmd0.Text = "0";
            this.cmd0.UseVisualStyleBackColor = true;
            this.cmd0.Click += new System.EventHandler(this.cmd0_Click);
            // 
            // cmdMultiply
            // 
            this.cmdMultiply.Location = new System.Drawing.Point(143, 93);
            this.cmdMultiply.Name = "cmdMultiply";
            this.cmdMultiply.Size = new System.Drawing.Size(40, 30);
            this.cmdMultiply.TabIndex = 9;
            this.cmdMultiply.Text = "*";
            this.cmdMultiply.UseVisualStyleBackColor = true;
            this.cmdMultiply.Click += new System.EventHandler(this.cmdMultiply_Click);
            // 
            // cmdDivide
            // 
            this.cmdDivide.Location = new System.Drawing.Point(143, 64);
            this.cmdDivide.Name = "cmdDivide";
            this.cmdDivide.Size = new System.Drawing.Size(40, 30);
            this.cmdDivide.TabIndex = 8;
            this.cmdDivide.Text = "/";
            this.cmdDivide.UseVisualStyleBackColor = true;
            this.cmdDivide.Click += new System.EventHandler(this.cmdDivide_Click);
            // 
            // cmd7
            // 
            this.cmd7.Location = new System.Drawing.Point(20, 64);
            this.cmd7.Name = "cmd7";
            this.cmd7.Size = new System.Drawing.Size(40, 30);
            this.cmd7.TabIndex = 7;
            this.cmd7.Text = "7";
            this.cmd7.UseVisualStyleBackColor = true;
            this.cmd7.Click += new System.EventHandler(this.cmd7_Click);
            // 
            // cmdClearAll
            // 
            this.cmdClearAll.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmdClearAll.Location = new System.Drawing.Point(170, 19);
            this.cmdClearAll.Name = "cmdClearAll";
            this.cmdClearAll.Size = new System.Drawing.Size(54, 30);
            this.cmdClearAll.TabIndex = 6;
            this.cmdClearAll.Text = "C";
            this.cmdClearAll.UseVisualStyleBackColor = false;
            this.cmdClearAll.Click += new System.EventHandler(this.cmdClearAll_Click);
            // 
            // cmdClearEntry
            // 
            this.cmdClearEntry.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmdClearEntry.Location = new System.Drawing.Point(103, 19);
            this.cmdClearEntry.Name = "cmdClearEntry";
            this.cmdClearEntry.Size = new System.Drawing.Size(56, 30);
            this.cmdClearEntry.TabIndex = 5;
            this.cmdClearEntry.Text = "CE";
            this.cmdClearEntry.UseVisualStyleBackColor = false;
            this.cmdClearEntry.Click += new System.EventHandler(this.cmdClearEntry_Click);
            // 
            // cmdBackspace
            // 
            this.cmdBackspace.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmdBackspace.Location = new System.Drawing.Point(20, 19);
            this.cmdBackspace.Name = "cmdBackspace";
            this.cmdBackspace.Size = new System.Drawing.Size(76, 30);
            this.cmdBackspace.TabIndex = 4;
            this.cmdBackspace.Text = "Backspace";
            this.cmdBackspace.UseVisualStyleBackColor = false;
            this.cmdBackspace.Click += new System.EventHandler(this.cmdBackspace_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtInput);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(235, 45);
            this.GroupBox1.TabIndex = 6;
            this.GroupBox1.TabStop = false;
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInput.Location = new System.Drawing.Point(6, 16);
            this.txtInput.Name = "txtInput";
            this.txtInput.ReadOnly = true;
            this.txtInput.Size = new System.Drawing.Size(223, 20);
            this.txtInput.TabIndex = 0;
            this.txtInput.TabStop = false;
            this.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmCalculator
            // 
            this.ClientSize = new System.Drawing.Size(261, 262);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(277, 301);
            this.MinimumSize = new System.Drawing.Size(277, 301);
            this.Name = "frmCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button cmdSign;
        internal System.Windows.Forms.Button cmdInverse;
        internal System.Windows.Forms.Button cmdSqrRoot;
        internal System.Windows.Forms.Button cmdPowerOf;
        internal System.Windows.Forms.Button cmdEqual;
        internal System.Windows.Forms.Button cmdAdd;
        internal System.Windows.Forms.Button cmdDecimal;
        internal System.Windows.Forms.Button cmdSubtract;
        internal System.Windows.Forms.Button cmd8;
        internal System.Windows.Forms.Button cmd9;
        internal System.Windows.Forms.Button cmd4;
        internal System.Windows.Forms.Button cmd5;
        internal System.Windows.Forms.Button cmd6;
        internal System.Windows.Forms.Button cmd1;
        internal System.Windows.Forms.Button cmd2;
        internal System.Windows.Forms.Button cmd3;
        internal System.Windows.Forms.Button cmd0;
        internal System.Windows.Forms.Button cmdMultiply;
        internal System.Windows.Forms.Button cmdDivide;
        internal System.Windows.Forms.Button cmd7;
        internal System.Windows.Forms.Button cmdClearAll;
        internal System.Windows.Forms.Button cmdClearEntry;
        internal System.Windows.Forms.Button cmdBackspace;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox txtInput;


    }
}



