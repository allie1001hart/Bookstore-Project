/*
 * Name: Alexandra Hart
 * Last Updated: 3/9/2018
 * File Name: UpdatedFile.cs
 * File Discription: This code controls the writing of strings to files
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore
{

    public class UpdatedFile
    {
        private string updatedFilePath;
        private System.IO.StreamWriter updatedFileSW;
        private int recordWriteCount;
        //constructor
        public UpdatedFile(string filePath)
        {
            recordWriteCount = 0;
            updatedFilePath = filePath;
            try
            {
                updatedFileSW = new System.IO.StreamWriter(updatedFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open file" + updatedFilePath + "Terminate Program.",
                                "Output File Connection Error.",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
        }  
        //writes the passed string to the file
        public void putNextRecord(string nextRecord)
        {
            try
            {
                updatedFileSW.WriteLine(nextRecord);
            }
            catch (Exception)
            {
                MessageBox.Show("IO error in file write. Terminate program.", "File Write Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            recordWriteCount += 1;
        }
        //returns the number of written records
        public int getRecordsWriteCount()
        {
            return recordWriteCount;
        }
        //close the file to save
        public void closeFile()
        {
            updatedFileSW.Close();
        }
        //sets the pointer to the top of the file
        public void rewindFile()
        {
            recordWriteCount = 0;
            closeFile();
            updatedFileSW = new System.IO.StreamWriter(updatedFilePath);
            updatedFileSW.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);

        }
    }
}