/*
 * Name: Alexandra Hart
 * Last Updated: 3/13/2018
 * File Name: EmployeeList.cs
 * File Discription: This code contains the list of employees and can be used to 
 *                   check on the data of the employee classes
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bookstore.Classes
{
    public class EmployeeList
    {
        public List<Employee> InternalList = new List<Employee>();
        int index;
        //reads from the current employee file and adds each employee to the employee list
        public bool initializeEntireList()
        {
            string nextRecord;
            Boolean isEndOfFile = true;
            Boolean success;
            int countProcessedRecords = 0;
           

            nextRecord = BookStore.currentEmployeeFile.getNextRecord(ref isEndOfFile);
            while (!isEndOfFile)
            {
                countProcessedRecords++;
                Employee emp = new Employee();
                success = emp.createEmployeeObject(nextRecord);
                if (success != true)
                {
                    MessageBox.Show
                       ("Unable to create an Employee Object.  Employee list not created.",
                        "Employee List Creation Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
                InternalList.Add(emp);
                nextRecord = BookStore.currentEmployeeFile.getNextRecord(ref isEndOfFile);
            }

            if (countProcessedRecords > 0)
                return true;
            else
                return false;
        }
        //finds the employee object in the list that has the matching id and saves the position of that obj
        public bool findEmployeeInList(int ID)
        {
            int count = 0;
            while (count < InternalList.Count)
            {
                Employee emp = InternalList[count];
                if (emp.checkEmployeeID(ID))
                {
                    index = count;
                    return true;
                }
                count++;
            }
            return false;
        }
        //calls the updateEmployeeTransactionDate function of the employee class
        public void updateEmployeeObject()
        {
            InternalList[index].updateEmployeeTransactionDate();
        }
        //calls the verifyPin function of the employee class
        public bool verifyPin(int pin)
        {
            return InternalList[index].verifyPin(pin);
        }
        //calls createStringToDisplay and passes that to the putNextRecord
        public void writeEntireList()
        {
            for(int i = 0; i < InternalList.Count(); i++)
            {
                BookStore.updatedEmployeeFile.putNextRecord(InternalList[i].createStringToDisplay());
            }
            BookStore.updatedEmployeeFile.closeFile();
        }
        //gets the name of the current employee
        public string getName()
        {
            return InternalList[index].getName();
        }
        //gets the last date of the current employee
        public string getLastDate()
        {
            return InternalList[index].getLastDate();
        }
    }

}
