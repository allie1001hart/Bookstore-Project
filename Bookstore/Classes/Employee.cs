/*
 * Name: Alexandra Hart
 * Last Updated: 3/14/2018
 * File Name: Employee.cs
 * File Discription: This code contains the information regarding an employee and the 
 *                   methods that can access and change this information
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bookstore.Classes
{
    public class Employee
    {
        int hiddenAccessID;
        int hiddenPin;
        string hiddenName;
        decimal hiddenAnnualPay;
        DateTime hiddenLastDateOfAccess;
        DateTime thisDay = DateTime.Today;
        //takes a string and break it into an array, format the substrings, and save the substings into the class variables
        public Boolean createEmployeeObject(string s)
        {
            int validPinLength = 4;
            int validAccessIDLength = 5;
            Employee thisEmployee = this;
            string[] employeeString = s.Split('*');
            int i;
            int employeeStringSize = employeeString.GetLength(0);
            employeeString[0] = employeeString[0].Trim();
            if (employeeString[0].Length != validAccessIDLength)
            {
                MessageBox.Show(employeeString[0]
                    + ": AccessID string is not exactly 5 characters. Employee File Corrupt. Execution Terminated.",
                      "AccessID in Employee File Invalid",
                      MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            try
            {
                hiddenAccessID = Convert.ToInt32(employeeString[0]);
            }
            catch
            {
                MessageBox.Show(employeeString[0]
                    + " AccessID string is not a valid integer. Employee File Corrupt. Execution Terminated.",
                      "AccessID in Employee File Invalid",
                       MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            // Name string to string (no conversion)
            hiddenName = employeeString[1];
            if (hiddenName == " " || hiddenName == "")
            {
                MessageBox.Show(hiddenName
                    + ": Name string is empty or Blank. Employee File Corrupt. Execution Terminated.",
                      "Name in Employee File Invalid",
                      MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            // Convert Pin to an integer of required length
            employeeString[2] = employeeString[2].Trim();
            if (employeeString[2].Length != validPinLength)
            {
                MessageBox.Show(employeeString[2]
                    + ": Pin string is not exactly 4 characters. Employee File Corrupt. Execution Terminated.",
                      "Pin in Employee File Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            try
            {
                hiddenPin = Convert.ToInt32(employeeString[2]);
            }
            catch
            {
                MessageBox.Show(employeeString[2]
                    + ": Pin string is empty or Blank. Employee File Corrupt.  Execution Terminated.",
                      "Pin in Employee File Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            // Convert annualPay to a positive decimal
            try
            {
                hiddenAnnualPay = Convert.ToDecimal(employeeString[3].Replace(",",
                    "").Replace("$", ""));
            }
            catch
            {
                MessageBox.Show(employeeString[3]
                    + ": Annual Pay string is not a valid decimal. Employee File Corrupt. Execution Terminated.",
                      "Annual pay in Employee File Invalid",
                      MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            // Convert last Date of Access to a date
            try
            {
                hiddenLastDateOfAccess = DateTime.Parse(employeeString[4]);
            }
            catch
            {
                MessageBox.Show(employeeString[4]
                    + ": Date of Last Access string is not a valid date. Employee File Corrupt.  Execution Terminated.",
                      "Date of last access in Employee File Invalid",
                      MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            // All data valid
            return (true);
        }
        //checks that the passed id matches the class id
        public bool checkEmployeeID(int ID)
        {
            return ID == hiddenAccessID;
        }
        //formats a string for displaying
        public string createStringToDisplay()
        {
            return hiddenAccessID + " * " + hiddenPin + " * " + hiddenName + " * " + hiddenLastDateOfAccess.ToString("d");
        }
        //sets the date to the current date
        public void updateEmployeeTransactionDate()
        {
            hiddenLastDateOfAccess = thisDay;
        }
        //checks that the passed pin matches the class pin
        public bool verifyPin(int pin)
        {
            return pin == hiddenPin;
        }
        //returns the name
        public string getName()
        {
            return hiddenName;
        }
        //return last date
        public string getLastDate()
        {
            return hiddenLastDateOfAccess.ToString("d");
        }
        
    }
}


