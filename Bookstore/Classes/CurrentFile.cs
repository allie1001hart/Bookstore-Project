/*
 * Name: Alexandra Hart
 * Last Updated: 3/13/2018
 * File Name: CurrentFile.cs
 * File Discription: This code controls the reading of strings to files
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore.Classes
{
    public class CurrentFile
    {
        private string currentFilePath;
        private System.IO.StreamReader currentFileSR;
        private int recordReadCount;
        //opens the file
        public CurrentFile(string filePath)
        {
            recordReadCount = 0;
            currentFilePath = filePath;
            try
            {
                currentFileSR = new System.IO.StreamReader(currentFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open file " + currentFilePath + " Terminate Program.",
                                "Output File Connection Error.",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } // end Try
        } 
        //creates a spring of the next record from the file
        public string getNextRecord(ref Boolean endOfFileFlag)
        {
            string nextRecord;

            endOfFileFlag = false;
            nextRecord = currentFileSR.ReadLine();

            if (nextRecord == null)
            {
                endOfFileFlag = true;
            }
            else
            {
                recordReadCount += 1;
            } // end if

            return (nextRecord);
        } 
        //returns the number of records read
        public int getRecordsReadCount()
        {
            return recordReadCount;
        } 
        //closes the file to save any of the changes
        public void closeFile()
        {
            currentFileSR.Close();
        } 
        //sets the pointers back to the top of the file
        public void rewindFile()
        {
            recordReadCount = 0;
            currentFileSR = new System.IO.StreamReader(currentFilePath);
            currentFileSR.DiscardBufferedData();
            currentFileSR.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
        }

    }
}









