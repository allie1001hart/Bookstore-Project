namespace Bookstore
{
    partial class FrmAccessID
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEnterID = new System.Windows.Forms.Label();
            this.lblRules = new System.Windows.Forms.Label();
            this.txtAccessID = new System.Windows.Forms.TextBox();
            this.btnAccessID = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(93, 34);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(176, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Book Worm Book Store";
            // 
            // lblEnterID
            // 
            this.lblEnterID.AutoSize = true;
            this.lblEnterID.Location = new System.Drawing.Point(45, 118);
            this.lblEnterID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterID.Name = "lblEnterID";
            this.lblEnterID.Size = new System.Drawing.Size(261, 20);
            this.lblEnterID.TabIndex = 1;
            this.lblEnterID.Text = "Enter Access ID and Press Find Me";
            // 
            // lblRules
            // 
            this.lblRules.AutoSize = true;
            this.lblRules.Location = new System.Drawing.Point(75, 175);
            this.lblRules.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(214, 20);
            this.lblRules.TabIndex = 2;
            this.lblRules.Text = "Access ID (a 5 Digit Number)";
            // 
            // txtAccessID
            // 
            this.txtAccessID.Location = new System.Drawing.Point(105, 215);
            this.txtAccessID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAccessID.Name = "txtAccessID";
            this.txtAccessID.Size = new System.Drawing.Size(148, 26);
            this.txtAccessID.TabIndex = 4;
            // 
            // btnAccessID
            // 
            this.btnAccessID.Location = new System.Drawing.Point(120, 255);
            this.btnAccessID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAccessID.Name = "btnAccessID";
            this.btnAccessID.Size = new System.Drawing.Size(112, 35);
            this.btnAccessID.TabIndex = 5;
            this.btnAccessID.Text = "Find Me";
            this.btnAccessID.UseVisualStyleBackColor = true;
            this.btnAccessID.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Location = new System.Drawing.Point(102, 72);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(164, 20);
            this.lblHeader.TabIndex = 6;
            this.lblHeader.Text = "Access ID Entry Form";
            // 
            // FrmAccessID
            // 
            this.AcceptButton = this.btnAccessID;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 325);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnAccessID);
            this.Controls.Add(this.txtAccessID);
            this.Controls.Add(this.lblRules);
            this.Controls.Add(this.lblEnterID);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAccessID";
            this.Text = "Enter Access ID";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEnterID;
        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.TextBox txtAccessID;
        private System.Windows.Forms.Button btnAccessID;
        private System.Windows.Forms.Label lblHeader;
    }
}

