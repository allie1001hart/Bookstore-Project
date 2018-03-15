/*
 * Name: Alexandra Hart
 * Last Updated: 3/9/2018
 * File Name: TransactionForm.cs
 * File Discription: This file contains the code behind the transaction form. 
 *      It allows a user to add, update, or delete a book from one file to another.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bookstore.Classes;

namespace Bookstore
{
    public partial class frmTransaction : Form
    {
        public frmTransaction()
        {
            InitializeComponent();
        }
        string ISBN;
        bool matched;
        string currentAction = "";
        DateTime thisDay = DateTime.Today;
        //validate that the ISBN, makes the option buttons visable, and checks if the ISBN is used
        private void btnISBNOK_Click(object sender, EventArgs e)
        {
            try
            {
                int ISBN1 = Convert.ToInt32(txtISBN1.Text);
                int ISBN2 = Convert.ToInt32(txtISBN2.Text);
                if (ISBN1 < 0 || ISBN2 < 0)
                {
                    MessageBox.Show("Enter only positive numbers");
                    txtISBN1.Text = "";
                    txtISBN2.Text = "";
                    txtISBN1.Focus();
                }
                else
                {
                    ISBN = txtISBN1.Text + "-" + txtISBN2.Text;
                    lblSelect.Visible = true;
                    btnAdd.Visible = true;
                    btnUpdate.Visible = true;
                    btnDelete.Visible = true;
                    txtISBN1.ReadOnly = true;
                    txtISBN2.ReadOnly = true;
                    Height = 325;
                }
            }
            catch
            {
                MessageBox.Show("Enter only numbers");
                txtISBN1.Text = "";
                txtISBN2.Text = "";
                txtISBN1.Focus();
            }
            matched = Global.BookStore.checkForDuplicateRecord(ISBN);
            Global.BookStore.rewindFiles();
        }
        //configures form for adding if ISBN matches
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (matched)
            {
                MessageBox.Show("Cannot Add new book. Book ISBN already in use");
                pnlTransaction.Visible = false;
                btnDelete.Enabled = true;
                btnAdd.Enabled = true;
                btnUpdate.Enabled = true;
                txtTitle.ReadOnly = false;
                txtAuthor.ReadOnly = false;
                txtPrice.ReadOnly = false;
                txtOnHand.ReadOnly = false;
                txtTitle.Text = "";
                txtAuthor.Text = "";
                txtPrice.Text = "";
                txtOnHand.Text = "";
                lblSelect.Visible = false;
                btnAdd.Visible = false;
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
                txtISBN1.Text = "";
                txtISBN2.Text = "";
                txtISBN1.ReadOnly = false;
                txtISBN2.ReadOnly = false;
                ISBN = "";
                Height = 200;
                txtISBN1.Focus();
            }
            else
            {
                matched = Global.BookStore.checkForDuplicateRecord(ISBN); //to get to the end of the file
                btnDelete.Enabled = false;
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                currentAction = "add";
                pnlTransaction.Visible = true;
                btnDone.Visible = true;
                Height = 550;
                txtISBN.Text = ISBN;
                txtDate.Text = thisDay.ToString("d");
                lblEnterData.Text = "Do you want to delete this book?";
                btnSave.Text = "Yes";
                btnGoBack.Text = "No";
                lblEnterData.Text = "Hit Save when you are finished adding\nnew book information";
                btnSave.Text = "Save";
                btnGoBack.Text = "Go Back";

            }
        }
        //configures form for updating if ISBN does not match
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (matched)
            {
                Global.BookStore.findAndSaveBook(ISBN);
                txtAuthor.Text = Global.BookStore.Book.getAuthor();
                txtTitle.Text = Global.BookStore.Book.getTitle();
                txtOnHand.Text = Convert.ToString(Global.BookStore.Book.getNumOnHand());
                txtPrice.Text = Convert.ToString(Global.BookStore.Book.getPrice());
                txtDate.Text = Convert.ToString(Global.BookStore.Book.getDateTransact());
                btnDelete.Enabled = false;
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                currentAction = "update";
                pnlTransaction.Visible = true;
                btnDone.Visible = true;
                Height = 550;
                txtISBN.Text = ISBN;
                txtDate.Text = thisDay.ToString("d");
                lblEnterData.Text = "Hit Save when you are finished updating\nbook info";
                btnSave.Text = "Save";
                btnGoBack.Text = "Go Back";
            }
            else
            {
                MessageBox.Show("Cannot update book. Book ISBN not in use.");
                pnlTransaction.Visible = false;
                btnDelete.Enabled = true;
                btnAdd.Enabled = true;
                btnUpdate.Enabled = true;
                txtTitle.ReadOnly = false;
                txtAuthor.ReadOnly = false;
                txtPrice.ReadOnly = false;
                txtOnHand.ReadOnly = false;
                txtTitle.Text = "";
                txtAuthor.Text = "";
                txtPrice.Text = "";
                txtOnHand.Text = "";
                lblSelect.Visible = false;
                btnAdd.Visible = false;
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
                txtISBN1.Text = "";
                txtISBN2.Text = "";
                txtISBN1.ReadOnly = false;
                txtISBN2.ReadOnly = false;
                ISBN = "";
                Height = 200;
                txtISBN1.Focus();
            }
        }
        //configures form for deleting if ISBN does not match
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (matched)
            {
                Global.BookStore.findAndSaveBook(ISBN);
                txtAuthor.Text = Global.BookStore.Book.getAuthor();
                txtTitle.Text = Global.BookStore.Book.getTitle();
                txtOnHand.Text = Convert.ToString(Global.BookStore.Book.getNumOnHand());
                txtPrice.Text = Convert.ToString(Global.BookStore.Book.getPrice());
                txtDate.Text = Convert.ToString(Global.BookStore.Book.getDateTransact());
                btnDelete.Enabled = false;
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                currentAction = "delete";
                pnlTransaction.Visible = true;
                btnDone.Visible = true;
                Height = 550;
                txtISBN.Text = ISBN;
                txtDate.Text = thisDay.ToString("d");
                txtTitle.ReadOnly = true;
                txtAuthor.ReadOnly = true;
                txtPrice.ReadOnly = true;
                txtOnHand.ReadOnly = true;
                lblEnterData.Text = "Do you want to delete this book?";
                btnSave.Text = "Yes";
                btnGoBack.Text = "No";
            }
            else
            {
                MessageBox.Show("Cannot delete book. Book ISBN not in use.");
                pnlTransaction.Visible = false;
                btnDelete.Enabled = true;
                btnAdd.Enabled = true;
                btnUpdate.Enabled = true;
                txtTitle.ReadOnly = false;
                txtAuthor.ReadOnly = false;
                txtPrice.ReadOnly = false;
                txtOnHand.ReadOnly = false;
                txtTitle.Text = "";
                txtAuthor.Text = "";
                txtPrice.Text = "";
                txtOnHand.Text = "";
                lblSelect.Visible = false;
                btnAdd.Visible = false;
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
                txtISBN1.Text = "";
                txtISBN2.Text = "";
                txtISBN1.ReadOnly = false;
                txtISBN2.ReadOnly = false;
                ISBN = "";
                Height = 200;
                txtISBN1.Focus();
            }

        }
        //executes the function that the user choose
        private void btnYes_Click(object sender, EventArgs e)
        {

            if (currentAction == "delete")
            {
                Global.BookStore.copyRemainingRecords();
                Global.BookStore.closeFiles();
                MessageBox.Show("Deleting Book. Closing Program");
                this.Close();
            }
            if (currentAction == "update")
            {
                try
                {
                    txtAuthor.Text.Trim();
                    txtTitle.Text.Trim();
                    txtPrice.Text.Trim();
                    txtOnHand.Text.Trim();
                    if (!(txtAuthor.Text == "" || txtTitle.Text == "" || txtPrice.Text == "" || txtOnHand.Text == ""))
                    {
                        decimal price = Convert.ToDecimal(txtPrice.Text);
                        int onHand = Convert.ToInt32(txtOnHand.Text);
                        string stringToAdd = ISBN + " * " + txtTitle.Text + " * " + txtAuthor.Text + " * $" + txtPrice.Text + " * " + txtOnHand.Text + " * " + txtDate.Text;
                        Global.BookStore.writeOneRecord(stringToAdd);
                        Global.BookStore.copyRemainingRecords();
                        Global.BookStore.closeFiles();
                        MessageBox.Show("Updating Book. Closeing Program.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Entries cannot be blank");
                    }
                }
                catch
                {
                    MessageBox.Show("Invalid Book entry");
                }

            }
            if (currentAction == "add")
            {
                try
                {
                    txtAuthor.Text.Trim();
                    txtTitle.Text.Trim();
                    txtPrice.Text.Trim();
                    txtOnHand.Text.Trim();
                    if (!(txtAuthor.Text == "" || txtTitle.Text == "" || txtPrice.Text == "" || txtOnHand.Text == ""))
                    {
                        decimal price = Convert.ToDecimal(txtPrice.Text);
                        int onHand = Convert.ToInt32(txtOnHand.Text);
                        string stringToAdd = ISBN + " * " + txtTitle.Text + " * " + txtAuthor.Text + " * $" + txtPrice.Text + " * " + txtOnHand.Text + " * " + txtDate.Text;

                        Global.BookStore.writeOneRecord(stringToAdd);
                        Global.BookStore.closeFiles();
                        MessageBox.Show("Added new book to file. Closeing Program.");
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Entries cannot be blank");
                    }

                }
                catch
                {
                    MessageBox.Show("Invalid Book entry");
                }
            }
        }
        //reverts back to the option section of the form 
        private void btnNo_Click(object sender, EventArgs e)
        {
            pnlTransaction.Visible = false;
            btnDelete.Enabled = true;
            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            txtTitle.ReadOnly = false;
            txtAuthor.ReadOnly = false;
            txtPrice.ReadOnly = false;
            txtOnHand.ReadOnly = false;
            txtTitle.Text = "";
            txtAuthor.Text = "";
            txtPrice.Text = "";
            txtOnHand.Text = "";
            lblSelect.Visible = false;
            btnAdd.Visible = false;
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            txtISBN1.Text = "";
            txtISBN2.Text = "";
            txtISBN1.ReadOnly = false;
            txtISBN2.ReadOnly = false;
            ISBN = "";
            Height = 200;
            txtISBN1.Focus();
            BookStore.currentBookFile.rewindFile();
            BookStore.updatedBookFile.rewindFile();
        }
        //closes the form
        private void btnDone_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        //sets some of the forms properties
        private void frmTransaction_Load(object sender, EventArgs e)
        {
            txtISBN1.MaxLength = 3;
            txtISBN2.MaxLength = 3;
            pnlTransaction.Visible = false;
            lblSelect.Visible = false;
            btnAdd.Visible = false;
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            btnDone.Visible = false;
            Height = 200;
        }
        //allows a fluid entering of the isbn
        private void txtISBN1_TextChanged(object sender, EventArgs e)
        {
            if (txtISBN1.Text.Length == 3)
            {
                txtISBN2.Focus();
            }
        }
        //allows a fluid entering of the isbn
        private void txtISBN2_TextChanged(object sender, EventArgs e)
        {
            if (txtISBN2.Text.Length == 3)
            {
                btnISBNOK.Focus();
            }
        }
    }
}
