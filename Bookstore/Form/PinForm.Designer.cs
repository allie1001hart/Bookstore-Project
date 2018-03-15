namespace Bookstore
{
    partial class FrmPin
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblEnterPin = new System.Windows.Forms.Label();
            this.lblRules = new System.Windows.Forms.Label();
            this.btnPin = new System.Windows.Forms.Button();
            this.txtPin = new System.Windows.Forms.TextBox();
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
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Location = new System.Drawing.Point(124, 72);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(113, 20);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Pin Entry Form";
            // 
            // lblEnterPin
            // 
            this.lblEnterPin.AutoSize = true;
            this.lblEnterPin.Location = new System.Drawing.Point(93, 118);
            this.lblEnterPin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterPin.Name = "lblEnterPin";
            this.lblEnterPin.Size = new System.Drawing.Size(175, 20);
            this.lblEnterPin.TabIndex = 2;
            this.lblEnterPin.Text = "Enter Pin and Press OK";
            // 
            // lblRules
            // 
            this.lblRules.AutoSize = true;
            this.lblRules.Location = new System.Drawing.Point(98, 175);
            this.lblRules.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(163, 20);
            this.lblRules.TabIndex = 3;
            this.lblRules.Text = "Pin (a 4 Digit Number)";
            // 
            // btnPin
            // 
            this.btnPin.Location = new System.Drawing.Point(120, 255);
            this.btnPin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPin.Name = "btnPin";
            this.btnPin.Size = new System.Drawing.Size(112, 35);
            this.btnPin.TabIndex = 4;
            this.btnPin.Text = "OK";
            this.btnPin.UseVisualStyleBackColor = true;
            this.btnPin.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(105, 215);
            this.txtPin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(148, 26);
            this.txtPin.TabIndex = 5;
            // 
            // FrmPin
            // 
            this.AcceptButton = this.btnPin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 325);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.btnPin);
            this.Controls.Add(this.lblRules);
            this.Controls.Add(this.lblEnterPin);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPin";
            this.Text = "Enter Pin";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblEnterPin;
        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.Button btnPin;
        private System.Windows.Forms.TextBox txtPin;
    }
}