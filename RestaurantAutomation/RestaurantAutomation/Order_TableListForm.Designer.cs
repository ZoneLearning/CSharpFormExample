namespace RestaurantAutomation
{
    partial class Order_TableListForm
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
            this.flTable = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSaloonName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flTable
            // 
            this.flTable.Location = new System.Drawing.Point(12, 39);
            this.flTable.Name = "flTable";
            this.flTable.Size = new System.Drawing.Size(345, 310);
            this.flTable.TabIndex = 0;
            // 
            // lblSaloonName
            // 
            this.lblSaloonName.AutoSize = true;
            this.lblSaloonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaloonName.Location = new System.Drawing.Point(8, 9);
            this.lblSaloonName.Name = "lblSaloonName";
            this.lblSaloonName.Size = new System.Drawing.Size(77, 20);
            this.lblSaloonName.TabIndex = 1;
            this.lblSaloonName.Text = "Salon Adı";
            // 
            // Order_TableListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 361);
            this.Controls.Add(this.lblSaloonName);
            this.Controls.Add(this.flTable);
            this.Name = "Order_TableListForm";
            this.Text = "Order_TableListForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Order_TableListForm_FormClosing);
            this.Load += new System.EventHandler(this.Order_TableListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flTable;
        private System.Windows.Forms.Label lblSaloonName;
    }
}