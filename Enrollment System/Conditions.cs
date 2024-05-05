using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Enrollment_System
{
    internal class Conditions
    {
        /// <summary>
        /// Method to check if there are null,empty or whitespace required fields
        /// </summary>
        /// <returns> Returns true if there is no empty required fields and false if there is</returns>
        public Boolean IsNull(String[] textBoxes)
        {
            
            for (int i = 0; i < textBoxes.Length; i++)
            {
                if (String.IsNullOrWhiteSpace(textBoxes[i]))
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Method to check if there are any duplicate student ID in the database using 1 primary and 1 key
        /// </summary>
        /// <param name="studentInformationDataSet"></param>
        /// <returns>returns true if there is no duplicate and false if there is</returns>
        public Boolean IsValid(String tableName,DataSet DataSet, String primary, int key)
        {
            Boolean isValid = true;
            DataRow navigatorRow;
            int rowNavigator = 0;
            foreach (DataRow row in DataSet.Tables[tableName].Rows)
            {
                navigatorRow = DataSet.Tables[tableName].Rows[rowNavigator];
                if (navigatorRow.ItemArray.GetValue(key).ToString() == primary.Trim())
                {
                    return false;
                }
                rowNavigator++;

            }
            return isValid;
        }
        /// <summary>
        /// Method to check if there are any duplicate student ID in the database using 2 primary and 2 key
        /// </summary>
        /// <param name="studentInformationDataSet"></param>
        /// <returns>returns true if there is no duplicate and false if there is</returns>
        public Boolean IsValid(String tableName,DataSet DataSet, String primary1, String primary2, int key1,int key2)
        {
            Boolean isValid = true;
            DataRow navigatorRow;
            int rowNavigator = 0;
            foreach (DataRow row in DataSet.Tables[tableName].Rows)
            {
                navigatorRow = DataSet.Tables[tableName].Rows[rowNavigator];
                if (navigatorRow.ItemArray.GetValue(key1).ToString() == primary1.Trim())
                {
                    if(navigatorRow.ItemArray.GetValue(key2).ToString() == primary2.Trim())
                    {
                        return false;
                    }
                }
                rowNavigator++;

            }
            return isValid;
        }
        public Boolean isInteger(String text)
        {
            try
            {
                Convert.ToInt32(text);
                return true;
            }catch(Exception e)
            {
                return false; 
            }
        }
    }
}
