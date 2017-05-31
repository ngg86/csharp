namespace ADOnet
{
    partial class ProductInvoer
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
            this.tbPNameInvoer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDiscontinued = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.cbDiscontinued = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbPNameInvoer
            // 
            this.tbPNameInvoer.Location = new System.Drawing.Point(124, 16);
            this.tbPNameInvoer.Name = "tbPNameInvoer";
            this.tbPNameInvoer.Size = new System.Drawing.Size(100, 20);
            this.tbPNameInvoer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product Name";
            // 
            // lblDiscontinued
            // 
            this.lblDiscontinued.AutoSize = true;
            this.lblDiscontinued.Location = new System.Drawing.Point(28, 52);
            this.lblDiscontinued.Name = "lblDiscontinued";
            this.lblDiscontinued.Size = new System.Drawing.Size(69, 13);
            this.lblDiscontinued.TabIndex = 3;
            this.lblDiscontinued.Text = "Discontinued";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(205, 75);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // cbDiscontinued
            // 
            this.cbDiscontinued.AutoSize = true;
            this.cbDiscontinued.Location = new System.Drawing.Point(163, 52);
            this.cbDiscontinued.Name = "cbDiscontinued";
            this.cbDiscontinued.Size = new System.Drawing.Size(15, 14);
            this.cbDiscontinued.TabIndex = 5;
            this.cbDiscontinued.UseVisualStyleBackColor = true;
            // 
            // ProductInvoer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 107);
            this.Controls.Add(this.cbDiscontinued);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.lblDiscontinued);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPNameInvoer);
            this.Name = "ProductInvoer";
            this.Text = "Product Invoegen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPNameInvoer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDiscontinued;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.CheckBox cbDiscontinued;
    }
}