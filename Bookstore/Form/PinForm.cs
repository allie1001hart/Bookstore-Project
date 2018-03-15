/*
 * Name: Alexandra Hart
 * Last Updated: 3/9/2018
 * File Name: PinForm.cs
 * File Discription: This file contains the code behind the pin form. 
 *      Allows users to enter pin to enter the tranaction form. User must enter the pin before the 3rd wrong attempt.
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
    public partial class FrmPin : Form
    {
        int errorCount = 0;
        public FrmPin()
        {
            InitializeComponent();
        }
        //validates pin and shows form 3
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtPin.Text == "")
                {
                    MessageBox.Show("Pin cannot be blank");
                    errorCount++;
                }
                else
                {
                    int pin = Convert.ToInt32(txtPin.Text);
                    if (BookStore.EmployeeList.verifyPin(pin))
                    {
                        MessageBox.Show("Welcome " + BookStore.EmployeeList.getName() + "\nLast Login: " + BookStore.EmployeeList.getLastDate());
                        BookStore.EmployeeList.updateEmployeeObject();
                        Global.BookStore.writeEntireEmployeeList();
                        this.Hide();
                        var form3 = new frmTransaction();
                        form3.Closed += (s, args) => this.Close();
                        form3.Show();
                    }
                    else
                    {
                        MessageBox.Show("Pin is incorrect");
                        errorCount++;
                        txtPin.Text = "";
                        txtPin.Focus();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error: Cannot process PIN");
                txtPin.Text = "";
                txtPin.Focus();
                errorCount++;
            }
            if (errorCount >= 3)
            {
                MessageBox.Show("Too Many Wrong Attemps. Terminating the Program.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }
        //sets focus on the pin textbox
        private void Form2_Load(object sender, EventArgs e)
        {
            txtPin.Select();
        }
    }
}

