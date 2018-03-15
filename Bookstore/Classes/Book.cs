/*
 * Name: Alexandra Hart
 * Last Updated: 3/13/2018
 * File Name: Book.cs
 * File Discription: This code contains the information of a book and the 
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
    public class Book
    {
        string ISBN;
        string title;
        string author;
        decimal price;
        int numberOnHand;
        DateTime dateOfLastTranaction;
        //takes a string and defines all of the attributes of the book class with that 
        public bool createBookObject(string nextRecord)
        {
            Book thisBook = this;
            string[] bookString = nextRecord.Split('*');
            int i;
            //int employeeStringSize = bookString.GetLength(0);

            //Parsing for ISBN
            bookString[0] = bookString[0].Trim();
            ISBN = bookString[0];
            if (ISBN == " " || ISBN == "")
            {
                MessageBox.Show(ISBN
                    + ": Invalid ISBN",
                      "Invalid ISBN",
                      MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            //Parsing for Title
            title = bookString[1];
            if (title == " " || title == "")
            {
                MessageBox.Show(title
                    + ": Name string is empty or Blank. Employee File Corrupt. Execution Terminated.",
                      "Name in Employee File Invalid",
                      MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            // Parsing for Author
            author = bookString[2];
            if (author == " " || author == "")
            {
                MessageBox.Show(author
                    + ": Pin string is not exactly 4 characters. Employee File Corrupt. Execution Terminated.",
                      "Pin in Employee File Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            // Parsing for Price
            try
            {
                price = Convert.ToDecimal(bookString[3].Replace(",",
                    "").Replace("$", ""));
            }
            catch
            {
                MessageBox.Show(bookString[3]
                    + ": Annual Pay string is not a valid decimal. Employee File Corrupt. Execution Terminated.",
                      "Annual pay in Employee File Invalid",
                      MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            // Parsing for numberOnHand
            bookString[4] = bookString[4].Trim();
            try
            {
                numberOnHand = Convert.ToInt32(bookString[4]);
            }
            catch
            {
                MessageBox.Show(bookString[2]
                    + ": Pin string is empty or Blank. Employee File Corrupt.  Execution Terminated.",
                      "Pin in Employee File Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            // Parsing for date
            try
            {
                dateOfLastTranaction = DateTime.Parse(bookString[5]);
            }
            catch
            {
                MessageBox.Show(bookString[5]
                    + ": Date of Last Access string is not a valid date. Employee File Corrupt.  Execution Terminated.",
                      "Date of last access in Employee File Invalid",
                      MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            // All data valid
            return true; 
        }
        //checks to see if ISBN matches the one that was passed
        public bool bookMatch(string checkISBN)
        {
            return checkISBN == ISBN;
        }
        //creates a string of the book info and prints out that info
        public void displayBookRecord()
        {
            string bookString = "ISBN: " + ISBN + "\nTitle: " + title + "\nAuthor: " + author + "\nPrice: $" + Convert.ToString(price) + "\nNumber on Hand: " + Convert.ToString(numberOnHand) + "\nDate of Last Transaction: " + Convert.ToString(dateOfLastTranaction) + "\n";
            MessageBox.Show(bookString, "Current Read File", MessageBoxButtons.OK);
        }
        //modifies the book record to be saved in file
        public void modifyBookRecord()
        {

        }
        //returns ISBN
        public string getISBN()
        {
            return ISBN;
        }
        //returns book title
        public string getTitle()
        {
            return title;
        }
        //returns book author
        public string getAuthor()
        {
            return author;
        }
        //returns the book price
        public decimal getPrice()
        {
            return price;
        }
        //return the number on hand
        public int getNumOnHand()
        {
            return numberOnHand;
        }
        //returns transaction date
        public DateTime getDateTransact()
        {
            return dateOfLastTranaction;
        }
    }
}
