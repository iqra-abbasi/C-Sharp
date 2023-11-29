namespace signUp_Page
{
    partial class welcomepage
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
            this.radio = new System.Windows.Forms.Label();
            this.radiombtn = new System.Windows.Forms.RadioButton();
            this.radiofbtn = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btndisable = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "date of birth";
            // 
            // radio
            // 
            this.radio.AutoSize = true;
            this.radio.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio.Location = new System.Drawing.Point(71, 265);
            this.radio.Name = "radio";
            this.radio.Size = new System.Drawing.Size(0, 26);
            this.radio.TabIndex = 2;
            // 
            // radiombtn
            // 
            this.radiombtn.AutoSize = true;
            this.radiombtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiombtn.Location = new System.Drawing.Point(269, 130);
            this.radiombtn.Name = "radiombtn";
            this.radiombtn.Size = new System.Drawing.Size(77, 30);
            this.radiombtn.TabIndex = 3;
            this.radiombtn.TabStop = true;
            this.radiombtn.Text = "male";
            this.radiombtn.UseVisualStyleBackColor = true;
            // 
            // radiofbtn
            // 
            this.radiofbtn.AutoSize = true;
            this.radiofbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiofbtn.Location = new System.Drawing.Point(363, 130);
            this.radiofbtn.Name = "radiofbtn";
            this.radiofbtn.Size = new System.Drawing.Size(96, 30);
            this.radiofbtn.TabIndex = 4;
            this.radiofbtn.TabStop = true;
            this.radiofbtn.Text = "female";
            this.radiofbtn.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(301, 203);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btndisable
            // 
            this.btndisable.BackColor = System.Drawing.Color.Red;
            this.btndisable.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndisable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndisable.Location = new System.Drawing.Point(195, 297);
            this.btndisable.Name = "btndisable";
            this.btndisable.Size = new System.Drawing.Size(306, 59);
            this.btndisable.TabIndex = 6;
            this.btndisable.Text = "click button to disable date";
            this.btndisable.UseVisualStyleBackColor = false;
            this.btndisable.Click += new System.EventHandler(this.btndisable_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(182, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "email";
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(301, 251);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(200, 23);
            this.txtemail.TabIndex = 8;
            // 
            // welcomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btndisable);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.radiofbtn);
            this.Controls.Add(this.radiombtn);
            this.Controls.Add(this.radio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "welcomepage";
            this.Text = "welcomepage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label radio;
        private System.Windows.Forms.RadioButton radiombtn;
        private System.Windows.Forms.RadioButton radiofbtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btndisable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtemail;
    }
}