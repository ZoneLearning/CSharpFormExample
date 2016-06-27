namespace Event_Delegate_Example
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
            this.lbAllStudent = new System.Windows.Forms.ListBox();
            this.lbPassedStudent = new System.Windows.Forms.ListBox();
            this.lbFailedStudent = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbMidterm = new System.Windows.Forms.TextBox();
            this.txbFinal = new System.Windows.Forms.TextBox();
            this.txbSurname = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAllStudent
            // 
            this.lbAllStudent.FormattingEnabled = true;
            this.lbAllStudent.Location = new System.Drawing.Point(12, 75);
            this.lbAllStudent.Name = "lbAllStudent";
            this.lbAllStudent.Size = new System.Drawing.Size(120, 290);
            this.lbAllStudent.TabIndex = 0;
            this.lbAllStudent.SelectedIndexChanged += new System.EventHandler(this.lbAllStudent_SelectedIndexChanged);
            // 
            // lbPassedStudent
            // 
            this.lbPassedStudent.FormattingEnabled = true;
            this.lbPassedStudent.Location = new System.Drawing.Point(162, 75);
            this.lbPassedStudent.Name = "lbPassedStudent";
            this.lbPassedStudent.Size = new System.Drawing.Size(120, 290);
            this.lbPassedStudent.TabIndex = 0;
            // 
            // lbFailedStudent
            // 
            this.lbFailedStudent.FormattingEnabled = true;
            this.lbFailedStudent.Location = new System.Drawing.Point(299, 75);
            this.lbFailedStudent.Name = "lbFailedStudent";
            this.lbFailedStudent.Size = new System.Drawing.Size(120, 290);
            this.lbFailedStudent.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Vize";
            // 
            // txbMidterm
            // 
            this.txbMidterm.Location = new System.Drawing.Point(224, 30);
            this.txbMidterm.Name = "txbMidterm";
            this.txbMidterm.Size = new System.Drawing.Size(46, 20);
            this.txbMidterm.TabIndex = 2;
            // 
            // txbFinal
            // 
            this.txbFinal.Location = new System.Drawing.Point(276, 30);
            this.txbFinal.Name = "txbFinal";
            this.txbFinal.Size = new System.Drawing.Size(46, 20);
            this.txbFinal.TabIndex = 2;
            // 
            // txbSurname
            // 
            this.txbSurname.Location = new System.Drawing.Point(118, 30);
            this.txbSurname.Name = "txbSurname";
            this.txbSurname.Size = new System.Drawing.Size(100, 20);
            this.txbSurname.TabIndex = 2;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(12, 30);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(100, 20);
            this.txbName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyadı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Final";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 20);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(333, 38);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 377);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbFinal);
            this.Controls.Add(this.txbMidterm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbSurname);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbFailedStudent);
            this.Controls.Add(this.lbPassedStudent);
            this.Controls.Add(this.lbAllStudent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAllStudent;
        private System.Windows.Forms.ListBox lbPassedStudent;
        private System.Windows.Forms.ListBox lbFailedStudent;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbMidterm;
        private System.Windows.Forms.TextBox txbFinal;
        private System.Windows.Forms.TextBox txbSurname;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUpdate;
    }
}

