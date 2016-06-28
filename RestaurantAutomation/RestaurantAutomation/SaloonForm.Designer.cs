namespace RestaurantAutomation
{
    partial class SaloonForm
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
            this.txtSaloonName = new System.Windows.Forms.TextBox();
            this.txtNumberOfTable = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrefixOfTable = new System.Windows.Forms.TextBox();
            this.btnTableAdd = new System.Windows.Forms.Button();
            this.lstTables = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.txtNumberOfTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı";
            // 
            // txtSaloonName
            // 
            this.txtSaloonName.Location = new System.Drawing.Point(12, 31);
            this.txtSaloonName.Name = "txtSaloonName";
            this.txtSaloonName.Size = new System.Drawing.Size(100, 20);
            this.txtSaloonName.TabIndex = 1;
            // 
            // txtNumberOfTable
            // 
            this.txtNumberOfTable.Location = new System.Drawing.Point(134, 32);
            this.txtNumberOfTable.Name = "txtNumberOfTable";
            this.txtNumberOfTable.Size = new System.Drawing.Size(100, 20);
            this.txtNumberOfTable.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Masa Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Masa ÖnEki";
            // 
            // txtPrefixOfTable
            // 
            this.txtPrefixOfTable.Location = new System.Drawing.Point(240, 32);
            this.txtPrefixOfTable.Name = "txtPrefixOfTable";
            this.txtPrefixOfTable.Size = new System.Drawing.Size(100, 20);
            this.txtPrefixOfTable.TabIndex = 1;
            // 
            // btnTableAdd
            // 
            this.btnTableAdd.Location = new System.Drawing.Point(346, 28);
            this.btnTableAdd.Name = "btnTableAdd";
            this.btnTableAdd.Size = new System.Drawing.Size(75, 23);
            this.btnTableAdd.TabIndex = 3;
            this.btnTableAdd.Text = "Ekle";
            this.btnTableAdd.UseVisualStyleBackColor = true;
            this.btnTableAdd.Click += new System.EventHandler(this.btnTableAdd_Click);
            // 
            // lstTables
            // 
            this.lstTables.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstTables.FullRowSelect = true;
            this.lstTables.GridLines = true;
            this.lstTables.Location = new System.Drawing.Point(12, 58);
            this.lstTables.Name = "lstTables";
            this.lstTables.Size = new System.Drawing.Size(409, 277);
            this.lstTables.TabIndex = 0;
            this.lstTables.UseCompatibleStateImageBehavior = false;
            this.lstTables.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Adı";
            this.columnHeader1.Width = 121;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Masa Sayısı";
            this.columnHeader2.Width = 173;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Masa Ön Eki";
            this.columnHeader3.Width = 204;
            // 
            // SaloonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 347);
            this.Controls.Add(this.lstTables);
            this.Controls.Add(this.btnTableAdd);
            this.Controls.Add(this.txtNumberOfTable);
            this.Controls.Add(this.txtPrefixOfTable);
            this.Controls.Add(this.txtSaloonName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SaloonForm";
            this.Text = "SaloonForm";
            ((System.ComponentModel.ISupportInitialize)(this.txtNumberOfTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSaloonName;
        private System.Windows.Forms.NumericUpDown txtNumberOfTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrefixOfTable;
        private System.Windows.Forms.Button btnTableAdd;
        private System.Windows.Forms.ListView lstTables;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}