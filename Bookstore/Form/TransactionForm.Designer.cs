namespace Bookstore
{
    partial class frmTransaction
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
            this.lblEnterISBN = new System.Windows.Forms.Label();
            this.txtISBN1 = new System.Windows.Forms.TextBox();
            this.txtISBN2 = new System.Windows.Forms.TextBox();
            this.lblDash = new System.Windows.Forms.Label();
            this.btnISBNOK = new System.Windows.Forms.Button();
            this.lblSelect = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlTransaction = new System.Windows.Forms.Panel();
            this.lblDataDate = new System.Windows.Forms.Label();
            this.lblDataOnHand = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtOnHand = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblDataPrice = new System.Windows.Forms.Label();
            this.lblDataAuthor = new System.Windows.Forms.Label();
            this.lblDataTitle = new System.Windows.Forms.Label();
            this.lblDataISBN = new System.Windows.Forms.Label();
            this.lblEnterData = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.pnlTransaction.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(306, 14);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(176, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Book Worm Book Store";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Location = new System.Drawing.Point(326, 58);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(133, 20);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Transaction Page";
            // 
            // lblEnterISBN
            // 
            this.lblEnterISBN.AutoSize = true;
            this.lblEnterISBN.Location = new System.Drawing.Point(45, 135);
            this.lblEnterISBN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterISBN.Name = "lblEnterISBN";
            this.lblEnterISBN.Size = new System.Drawing.Size(306, 20);
            this.lblEnterISBN.TabIndex = 2;
            this.lblEnterISBN.Text = "Enter the ISBN for Book (in form nnn-nnn)";
            // 
            // txtISBN1
            // 
            this.txtISBN1.Location = new System.Drawing.Point(410, 131);
            this.txtISBN1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtISBN1.Name = "txtISBN1";
            this.txtISBN1.Size = new System.Drawing.Size(73, 26);
            this.txtISBN1.TabIndex = 3;
            this.txtISBN1.TextChanged += new System.EventHandler(this.txtISBN1_TextChanged);
            // 
            // txtISBN2
            // 
            this.txtISBN2.Location = new System.Drawing.Point(518, 131);
            this.txtISBN2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtISBN2.Name = "txtISBN2";
            this.txtISBN2.Size = new System.Drawing.Size(73, 26);
            this.txtISBN2.TabIndex = 4;
            this.txtISBN2.TextChanged += new System.EventHandler(this.txtISBN2_TextChanged);
            // 
            // lblDash
            // 
            this.lblDash.AutoSize = true;
            this.lblDash.Location = new System.Drawing.Point(494, 131);
            this.lblDash.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDash.Name = "lblDash";
            this.lblDash.Size = new System.Drawing.Size(14, 20);
            this.lblDash.TabIndex = 5;
            this.lblDash.Text = "-";
            // 
            // btnISBNOK
            // 
            this.btnISBNOK.Location = new System.Drawing.Point(622, 131);
            this.btnISBNOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnISBNOK.Name = "btnISBNOK";
            this.btnISBNOK.Size = new System.Drawing.Size(112, 35);
            this.btnISBNOK.TabIndex = 6;
            this.btnISBNOK.Text = "OK";
            this.btnISBNOK.UseVisualStyleBackColor = true;
            this.btnISBNOK.Click += new System.EventHandler(this.btnISBNOK_Click);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(81, 192);
            this.lblSelect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(158, 20);
            this.lblSelect.TabIndex = 7;
            this.lblSelect.Text = "Select a Transaction:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(284, 226);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(237, 35);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add New Book To Inventory";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(284, 286);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(237, 35);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update A Book In Inventory";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(284, 346);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(237, 34);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete A Book From Inventory";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pnlTransaction
            // 
            this.pnlTransaction.Controls.Add(this.lblDataDate);
            this.pnlTransaction.Controls.Add(this.lblDataOnHand);
            this.pnlTransaction.Controls.Add(this.txtDate);
            this.pnlTransaction.Controls.Add(this.txtOnHand);
            this.pnlTransaction.Controls.Add(this.txtAuthor);
            this.pnlTransaction.Controls.Add(this.txtTitle);
            this.pnlTransaction.Controls.Add(this.txtISBN);
            this.pnlTransaction.Controls.Add(this.txtPrice);
            this.pnlTransaction.Controls.Add(this.btnGoBack);
            this.pnlTransaction.Controls.Add(this.btnSave);
            this.pnlTransaction.Controls.Add(this.lblDataPrice);
            this.pnlTransaction.Controls.Add(this.lblDataAuthor);
            this.pnlTransaction.Controls.Add(this.lblDataTitle);
            this.pnlTransaction.Controls.Add(this.lblDataISBN);
            this.pnlTransaction.Controls.Add(this.lblEnterData);
            this.pnlTransaction.Location = new System.Drawing.Point(86, 411);
            this.pnlTransaction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlTransaction.Name = "pnlTransaction";
            this.pnlTransaction.Size = new System.Drawing.Size(627, 283);
            this.pnlTransaction.TabIndex = 11;
            // 
            // lblDataDate
            // 
            this.lblDataDate.AutoSize = true;
            this.lblDataDate.Location = new System.Drawing.Point(290, 225);
            this.lblDataDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataDate.Name = "lblDataDate";
            this.lblDataDate.Size = new System.Drawing.Size(135, 20);
            this.lblDataDate.TabIndex = 17;
            this.lblDataDate.Text = "Transaction Date:";
            // 
            // lblDataOnHand
            // 
            this.lblDataOnHand.AutoSize = true;
            this.lblDataOnHand.Location = new System.Drawing.Point(348, 154);
            this.lblDataOnHand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataOnHand.Name = "lblDataOnHand";
            this.lblDataOnHand.Size = new System.Drawing.Size(77, 20);
            this.lblDataOnHand.TabIndex = 16;
            this.lblDataOnHand.Text = "On Hand:";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(436, 220);
            this.txtDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(148, 26);
            this.txtDate.TabIndex = 15;
            // 
            // txtOnHand
            // 
            this.txtOnHand.Location = new System.Drawing.Point(436, 149);
            this.txtOnHand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOnHand.Name = "txtOnHand";
            this.txtOnHand.Size = new System.Drawing.Size(148, 26);
            this.txtOnHand.TabIndex = 14;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(111, 220);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(148, 26);
            this.txtAuthor.TabIndex = 13;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(111, 149);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(148, 26);
            this.txtTitle.TabIndex = 12;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(111, 80);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.ReadOnly = true;
            this.txtISBN.Size = new System.Drawing.Size(148, 26);
            this.txtISBN.TabIndex = 11;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(436, 80);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(148, 26);
            this.txtPrice.TabIndex = 10;
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(474, 18);
            this.btnGoBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(112, 35);
            this.btnGoBack.TabIndex = 9;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(332, 18);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 35);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // lblDataPrice
            // 
            this.lblDataPrice.AutoSize = true;
            this.lblDataPrice.Location = new System.Drawing.Point(376, 85);
            this.lblDataPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataPrice.Name = "lblDataPrice";
            this.lblDataPrice.Size = new System.Drawing.Size(48, 20);
            this.lblDataPrice.TabIndex = 7;
            this.lblDataPrice.Text = "Price:";
            // 
            // lblDataAuthor
            // 
            this.lblDataAuthor.AutoSize = true;
            this.lblDataAuthor.Location = new System.Drawing.Point(40, 225);
            this.lblDataAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataAuthor.Name = "lblDataAuthor";
            this.lblDataAuthor.Size = new System.Drawing.Size(61, 20);
            this.lblDataAuthor.TabIndex = 3;
            this.lblDataAuthor.Text = "Author:";
            // 
            // lblDataTitle
            // 
            this.lblDataTitle.AutoSize = true;
            this.lblDataTitle.Location = new System.Drawing.Point(57, 154);
            this.lblDataTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataTitle.Name = "lblDataTitle";
            this.lblDataTitle.Size = new System.Drawing.Size(42, 20);
            this.lblDataTitle.TabIndex = 2;
            this.lblDataTitle.Text = "Title:";
            // 
            // lblDataISBN
            // 
            this.lblDataISBN.AutoSize = true;
            this.lblDataISBN.Location = new System.Drawing.Point(50, 85);
            this.lblDataISBN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataISBN.Name = "lblDataISBN";
            this.lblDataISBN.Size = new System.Drawing.Size(51, 20);
            this.lblDataISBN.TabIndex = 1;
            this.lblDataISBN.Text = "ISBN:";
            // 
            // lblEnterData
            // 
            this.lblEnterData.AutoSize = true;
            this.lblEnterData.Location = new System.Drawing.Point(24, 18);
            this.lblEnterData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterData.Name = "lblEnterData";
            this.lblEnterData.Size = new System.Drawing.Size(233, 20);
            this.lblEnterData.TabIndex = 0;
            this.lblEnterData.Text = "Enter Data for New Book Below";
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(330, 722);
            this.btnDone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(112, 35);
            this.btnDone.TabIndex = 12;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // frmTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 786);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.pnlTransaction);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.btnISBNOK);
            this.Controls.Add(this.lblDash);
            this.Controls.Add(this.txtISBN2);
            this.Controls.Add(this.txtISBN1);
            this.Controls.Add(this.lblEnterISBN);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTransaction";
            this.Text = "Transaction Form";
            this.Load += new System.EventHandler(this.frmTransaction_Load);
            this.pnlTransaction.ResumeLayout(false);
            this.pnlTransaction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblEnterISBN;
        private System.Windows.Forms.TextBox txtISBN1;
        private System.Windows.Forms.TextBox txtISBN2;
        private System.Windows.Forms.Label lblDash;
        private System.Windows.Forms.Button btnISBNOK;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlTransaction;
        private System.Windows.Forms.Label lblDataDate;
        private System.Windows.Forms.Label lblDataOnHand;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtOnHand;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblDataPrice;
        private System.Windows.Forms.Label lblDataAuthor;
        private System.Windows.Forms.Label lblDataTitle;
        private System.Windows.Forms.Label lblDataISBN;
        private System.Windows.Forms.Label lblEnterData;
        private System.Windows.Forms.Button btnDone;
    }
}