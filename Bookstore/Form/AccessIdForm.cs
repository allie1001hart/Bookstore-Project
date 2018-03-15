/*
 * Name: Alexandra Hart
 * Last Updated: 3/9/2018
 * File Name: AccessFormForm.cs
 * File Discription: This file contains the code behind the access id form. 
 *      Allows users to enter access id to enter the pin form. User must enter the id before the 3rd wrong attempt.
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
    public partial class FrmAccessID : Form
    {
        int errorCount = 0;

        public FrmAccessID()
        {
            InitializeComponent();
        }
        //validates the access id and shows form 2
        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtAccessID.Text == "")
                {
                    MessageBox.Show("ID cannot be blank");
                    errorCount++;
                }
                else
                {
                    int id = Convert.ToInt32(txtAccessID.Text);
                    bool found;
                    Global.BookStore.findEmployee(id, out found);
                    if (found)
                    {
                        this.Hide();
                        var form2 = new FrmPin();
                        form2.Closed += (s, args) => this.Close();
                        form2.Show();
                    }
                    else
                    {
                        MessageBox.Show("Access ID cannot be found");
                        txtAccessID.Text = "";
                        errorCount++;
                        txtAccessID.Focus();
                    }

                }
            }
            catch
            {
                MessageBox.Show("Error: Cannot process AccessID");
                txtAccessID.Text = "";
                txtAccessID.Focus();
                errorCount++;
            }
            if (errorCount >= 3)
            {
                MessageBox.Show("Too Many Wrong Attemps. Terminating the Program.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }
        //calls initializeEntireList on load
        public void Form1_Load(object sender, EventArgs e)
        {
            BookStore.EmployeeList.initializeEntireList();
        }

    }
}
