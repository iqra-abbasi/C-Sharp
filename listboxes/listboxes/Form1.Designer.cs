namespace listboxes
{
    partial class Form1
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
            this.btnpopulate = new System.Windows.Forms.Button();
            this.btnright = new System.Windows.Forms.Button();
            this.btnrightall = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.lstleft = new System.Windows.Forms.ListBox();
            this.lstright = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnpopulate
            // 
            this.btnpopulate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnpopulate.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpopulate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnpopulate.Location = new System.Drawing.Point(313, 36);
            this.btnpopulate.Name = "btnpopulate";
            this.btnpopulate.Size = new System.Drawing.Size(111, 41);
            this.btnpopulate.TabIndex = 0;
            this.btnpopulate.Text = "Populate";
            this.btnpopulate.UseVisualStyleBackColor = false;
            this.btnpopulate.Click += new System.EventHandler(this.btnpopulate_Click);
            // 
            // btnright
            // 
            this.btnright.BackColor = System.Drawing.Color.DarkBlue;
            this.btnright.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnright.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnright.Location = new System.Drawing.Point(313, 83);
            this.btnright.Name = "btnright";
            this.btnright.Size = new System.Drawing.Size(111, 40);
            this.btnright.TabIndex = 1;
            this.btnright.Text = "Right";
            this.btnright.UseVisualStyleBackColor = false;
            this.btnright.Click += new System.EventHandler(this.btnright_Click);
            // 
            // btnrightall
            // 
            this.btnrightall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnrightall.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrightall.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnrightall.Location = new System.Drawing.Point(313, 141);
            this.btnrightall.Name = "btnrightall";
            this.btnrightall.Size = new System.Drawing.Size(111, 39);
            this.btnrightall.TabIndex = 2;
            this.btnrightall.Text = "RightAll";
            this.btnrightall.UseVisualStyleBackColor = false;
            this.btnrightall.Click += new System.EventHandler(this.btnrightall_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Red;
            this.btnclear.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnclear.Location = new System.Drawing.Point(313, 197);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(111, 41);
            this.btnclear.TabIndex = 3;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // lstleft
            // 
            this.lstleft.FormattingEnabled = true;
            this.lstleft.Items.AddRange(new object[] {
            "c",
            "c++",
            "java",
            "c#",
            "DAA",
            "Perl",
            "PHP"});
            this.lstleft.Location = new System.Drawing.Point(146, 39);
            this.lstleft.Name = "lstleft";
            this.lstleft.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstleft.Size = new System.Drawing.Size(141, 199);
            this.lstleft.TabIndex = 4;
            // 
            // lstright
            // 
            this.lstright.FormattingEnabled = true;
            this.lstright.Location = new System.Drawing.Point(456, 36);
            this.lstright.Name = "lstright";
            this.lstright.Size = new System.Drawing.Size(149, 199);
            this.lstright.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstright);
            this.Controls.Add(this.lstleft);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnrightall);
            this.Controls.Add(this.btnright);
            this.Controls.Add(this.btnpopulate);
            this.Name = "Form1";
            this.Text = "ListBoxes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnpopulate;
        private System.Windows.Forms.Button btnright;
        private System.Windows.Forms.Button btnrightall;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.ListBox lstleft;
        private System.Windows.Forms.ListBox lstright;
    }
}

