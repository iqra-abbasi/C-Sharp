namespace simple_calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.res = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.addbtn = new System.Windows.Forms.Button();
            this.subbtn = new System.Windows.Forms.Button();
            this.divbtn = new System.Windows.Forms.Button();
            this.div2btn = new System.Windows.Forms.Button();
            this.clrbtn = new System.Windows.Forms.Button();
            this.mulbtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "sample calculator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "number1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "number2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "result";
            // 
            // num1
            // 
            this.num1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.num1.Location = new System.Drawing.Point(156, 103);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(420, 20);
            this.num1.TabIndex = 4;
            this.num1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // num2
            // 
            this.num2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.num2.Location = new System.Drawing.Point(156, 162);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(420, 20);
            this.num2.TabIndex = 5;
            this.num2.TextChanged += new System.EventHandler(this.num2_TextChanged);
            // 
            // res
            // 
            this.res.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.res.Location = new System.Drawing.Point(156, 212);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(420, 20);
            this.res.TabIndex = 6;
            this.res.TextChanged += new System.EventHandler(this.res_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.50746F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.49254F));
            this.tableLayoutPanel1.Controls.Add(this.addbtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.subbtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.divbtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.div2btn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.clrbtn, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.mulbtn, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(135, 273);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(345, 165);
            this.tableLayoutPanel1.TabIndex = 7;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.Location = new System.Drawing.Point(3, 3);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(161, 40);
            this.addbtn.TabIndex = 0;
            this.addbtn.Text = "+";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // subbtn
            // 
            this.subbtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.subbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subbtn.Location = new System.Drawing.Point(170, 3);
            this.subbtn.Name = "subbtn";
            this.subbtn.Size = new System.Drawing.Size(165, 40);
            this.subbtn.TabIndex = 1;
            this.subbtn.Text = "-";
            this.subbtn.UseVisualStyleBackColor = false;
            this.subbtn.Click += new System.EventHandler(this.subbtn_Click);
            // 
            // divbtn
            // 
            this.divbtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.divbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divbtn.Location = new System.Drawing.Point(170, 62);
            this.divbtn.Name = "divbtn";
            this.divbtn.Size = new System.Drawing.Size(165, 40);
            this.divbtn.TabIndex = 3;
            this.divbtn.Text = "%";
            this.divbtn.UseVisualStyleBackColor = false;
            this.divbtn.Click += new System.EventHandler(this.divbtn_Click);
            // 
            // div2btn
            // 
            this.div2btn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.div2btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.div2btn.Location = new System.Drawing.Point(3, 121);
            this.div2btn.Name = "div2btn";
            this.div2btn.Size = new System.Drawing.Size(161, 41);
            this.div2btn.TabIndex = 4;
            this.div2btn.Text = "/";
            this.div2btn.UseVisualStyleBackColor = false;
            this.div2btn.Click += new System.EventHandler(this.div2btn_Click);
            // 
            // clrbtn
            // 
            this.clrbtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.clrbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clrbtn.Location = new System.Drawing.Point(170, 121);
            this.clrbtn.Name = "clrbtn";
            this.clrbtn.Size = new System.Drawing.Size(165, 41);
            this.clrbtn.TabIndex = 5;
            this.clrbtn.Text = "C";
            this.clrbtn.UseVisualStyleBackColor = false;
            this.clrbtn.Click += new System.EventHandler(this.clrbtn_Click);
            // 
            // mulbtn
            // 
            this.mulbtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.mulbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mulbtn.Location = new System.Drawing.Point(3, 62);
            this.mulbtn.Name = "mulbtn";
            this.mulbtn.Size = new System.Drawing.Size(161, 40);
            this.mulbtn.TabIndex = 2;
            this.mulbtn.Text = "*";
            this.mulbtn.UseVisualStyleBackColor = false;
            this.mulbtn.Click += new System.EventHandler(this.mulbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.res);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "sample calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.TextBox res;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button subbtn;
        private System.Windows.Forms.Button divbtn;
        private System.Windows.Forms.Button div2btn;
        private System.Windows.Forms.Button clrbtn;
        private System.Windows.Forms.Button mulbtn;
    }
}

