/*
 * Name: Alexandra Hart
 * Last Updated: 3/13/2018
 * File Name: Bookstore.cs
 * File Discription: This code owns the employee list, the current book, and the file classes
 */
 
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore.Classes
{
    public class BookStore
    {
        public Book Book = new Book();
        public static EmployeeList EmployeeList = new EmployeeList();
        private static string currentBookFilePath = "currentBookFile.txt";
        private static string updatedBookFilePath = "updatedBookFile.txt";
        private static string currentEmployeeFilePath = "currentEmployeeFile.txt";
        private static string updatedEmployeeFilePath = "updatedEmployeeFile.txt";
        public static CurrentFile currentBookFile = new CurrentFile(currentBookFilePath);
        public static UpdatedFile updatedBookFile = new UpdatedFile(updatedBookFilePath);
        public static CurrentFile currentEmployeeFile = new CurrentFile(currentEmployeeFilePath);
        public static UpdatedFile updatedEmployeeFile = new UpdatedFile(updatedEmployeeFilePath);
        
        //passes id to the employeelist class
        public void findEmployee(int ID, out Boolean found)
        {
            found = EmployeeList.findEmployeeInList(ID);
        }
        //calss writeEntireList of the employeelist calss 
        public void writeEntireEmployeeList()
        {
            EmployeeList.writeEntireList();
        }
        //reads and writes one record at a time and compares the ISBN to the ISBN of the current book
        public bool checkForDuplicateRecord(string ISBN)
        {

            string nextRecord;
            Boolean isEndOfFile = true;
            Boolean success;
            int countProcessedRecords = 0;


            nextRecord = currentBookFile.getNextRecord(ref isEndOfFile);
            
            while (!isEndOfFile)
            {
                updatedBookFile.putNextRecord(nextRecord);
                countProcessedRecords++;
                Book currentBook = new Book();
                success = currentBook.createBookObject(nextRecord);
                if (success != true)
                {
                    MessageBox.Show
                       ("");
                    return false;
                }
                if (!(currentBook.bookMatch(ISBN))){
                    nextRecord = currentBookFile.getNextRecord(ref isEndOfFile);
                } 
                else
                {
                    return true;
                }
            }
            return false;
        }
        //writes the rest of the records that are not read
        public void copyRemainingRecords()
        {

            string nextRecord;
            Boolean isEndOfFile = true;
            Boolean success;
            int countProcessedRecords = 0;


            nextRecord = currentBookFile.getNextRecord(ref isEndOfFile);

            while (!isEndOfFile)
            {
  
                countProcessedRecords++;
                Book currentBook = new Book();
                success = currentBook.createBookObject(nextRecord);
                if (success != true)
                {
                    MessageBox.Show
                       ("");
                    
                }
                currentBook.displayBookRecord();
                updatedBookFile.putNextRecord(nextRecord);
                nextRecord = currentBookFile.getNextRecord(ref isEndOfFile);
            }
        }
        //reads and writes the to set the pointers of the files to the book that is needed
        public void findAndSaveBook(string ISBN)
        {
            string nextRecord;
            Boolean isEndOfFile = true;
            Boolean success;
            int countProcessedRecords = 0;


            nextRecord = currentBookFile.getNextRecord(ref isEndOfFile);

            while (!isEndOfFile)
            {
                
                countProcessedRecords++;
                Book = new Book();
                success = Book.createBookObject(nextRecord);
                if (success != true)
                {
                    MessageBox.Show
                       ("");
                }
                if (!(Book.bookMatch(ISBN)))
                {
                    updatedBookFile.putNextRecord(nextRecord);
                    //Book.displayBookRecord();
                    nextRecord = currentBookFile.getNextRecord(ref isEndOfFile);
                }
                else
                {
                    break;
                }
            }
        }
        //calls rewindFile for the current and the updated book files
        public void rewindFiles()
        {
            currentBookFile.rewindFile();
            updatedBookFile.rewindFile();
        }
        //writes a passed string to a file by calling put next record
        public void writeOneRecord(string stringToWrite)
        {
            updatedBookFile.putNextRecord(stringToWrite);
        }
        //calls closeFile for the current and the updated book files
        public void closeFiles()
        {
            updatedBookFile.closeFile();
            currentBookFile.closeFile();
        }
    }
}