/* Title:           Tool Category Class
 * Date:            12-28-17
 * Author:          Terry Holmes
 * 
 * Description:     This class is used for Tool Category */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;

namespace ToolCategoryDLL
{
    public class ToolCategoryClass
    {
        EventLogClass TheEventLogClass = new EventLogClass();

        ToolCategoryDataSet aToolCategoryDataSet;
        ToolCategoryDataSetTableAdapters.toolcategoryTableAdapter aToolCategoryTableAdapter;

        InsertToolCategoryEntryTableAdapters.QueriesTableAdapter aInsertToolCategoryTableAdapter;

        FindSortedToolCategoryDataSet aFindSortedToolCategoryDataSet;
        FindSortedToolCategoryDataSetTableAdapters.FindSortedToolCategoryTableAdapter aFindSortedToolCategoryTableAdapter;

        FindToolCategoryByCategoryIDDataSet aFindToolCategoryByCategoryIDDataSet;
        FindToolCategoryByCategoryIDDataSetTableAdapters.FindToolCategoryByCategoryIDTableAdapter aFindToolCategoryByCategoryIDTableAdapter;

        FindToolCategoryByCategoryDataSet aFindToolCategoryByCategoryDataSet;
        FindToolCategoryByCategoryDataSetTableAdapters.FindToolCategoryByCategoryTableAdapter aFindToolCategoryByCategoryTableAdapter;

        FindToolCategoryByKeyWordDataSet aFindToolCategoryByKeyWordDataSet;
        FindToolCategoryByKeyWordDataSetTableAdapters.FindToolCategoryByKeyWordTableAdapter aFindToolCategoryByKeyWordTableAdapter;

        public FindToolCategoryByKeyWordDataSet FindToolCategoryByKeyWord(string strToolCategory)
        {
            try
            {
                aFindToolCategoryByKeyWordDataSet = new FindToolCategoryByKeyWordDataSet();
                aFindToolCategoryByKeyWordTableAdapter = new FindToolCategoryByKeyWordDataSetTableAdapters.FindToolCategoryByKeyWordTableAdapter();
                aFindToolCategoryByKeyWordTableAdapter.Fill(aFindToolCategoryByKeyWordDataSet.FindToolCategoryByKeyWord, strToolCategory);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tool Category Class // Find Tool Category By KeyWord  " + Ex.Message);
            }

            return aFindToolCategoryByKeyWordDataSet;
        }
        public FindToolCategoryByCategoryDataSet FindToolCategoryByCategory(string strToolCategory)
        {
            try
            {
                aFindToolCategoryByCategoryDataSet = new FindToolCategoryByCategoryDataSet();
                aFindToolCategoryByCategoryTableAdapter = new FindToolCategoryByCategoryDataSetTableAdapters.FindToolCategoryByCategoryTableAdapter();
                aFindToolCategoryByCategoryTableAdapter.Fill(aFindToolCategoryByCategoryDataSet.FindToolCategoryByCategory, strToolCategory);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tool Category Class // Find Tool Category By Category  " + Ex.Message);
            }

            return aFindToolCategoryByCategoryDataSet;
        }

        public FindToolCategoryByCategoryIDDataSet FindToolCategoryByCategoryID(int intCategoryID)
        {
            try
            {
                aFindToolCategoryByCategoryIDDataSet = new FindToolCategoryByCategoryIDDataSet();
                aFindToolCategoryByCategoryIDTableAdapter = new FindToolCategoryByCategoryIDDataSetTableAdapters.FindToolCategoryByCategoryIDTableAdapter();
                aFindToolCategoryByCategoryIDTableAdapter.Fill(aFindToolCategoryByCategoryIDDataSet.FindToolCategoryByCategoryID, intCategoryID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tool Category Class // Find Tool Category By Category ID " + Ex.Message);
            }

            return aFindToolCategoryByCategoryIDDataSet;
        }
        public FindSortedToolCategoryDataSet FindSortedToolCategory()
        {
            try
            {
                aFindSortedToolCategoryDataSet = new FindSortedToolCategoryDataSet();
                aFindSortedToolCategoryTableAdapter = new FindSortedToolCategoryDataSetTableAdapters.FindSortedToolCategoryTableAdapter();
                aFindSortedToolCategoryTableAdapter.Fill(aFindSortedToolCategoryDataSet.FindSortedToolCategory);
            }
            catch(Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tool Category Class // Find Sorted Tool Category " + Ex.Message);
            }

            return aFindSortedToolCategoryDataSet;
        }
        public bool InsertToolCategory(string strToolCategory)
        {
            bool blnFatalError = false;

            try
            {
                aInsertToolCategoryTableAdapter = new InsertToolCategoryEntryTableAdapters.QueriesTableAdapter();
                aInsertToolCategoryTableAdapter.InsertToolCategory(strToolCategory);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tool Category Class // Insert Tool Category " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public ToolCategoryDataSet GetToolCategoryInfo()
        {
            try
            {
                aToolCategoryDataSet = new ToolCategoryDataSet();
                aToolCategoryTableAdapter = new ToolCategoryDataSetTableAdapters.toolcategoryTableAdapter();
                aToolCategoryTableAdapter.Fill(aToolCategoryDataSet.toolcategory);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tool Category Class // Get Tool Category Info " + Ex.Message);
            }

            return aToolCategoryDataSet;
        }
        public void UpdateToolCategoryDB(ToolCategoryDataSet aToolCategoryDataSet)
        {
            try
            {
                aToolCategoryTableAdapter = new ToolCategoryDataSetTableAdapters.toolcategoryTableAdapter();
                aToolCategoryTableAdapter.Update(aToolCategoryDataSet.toolcategory);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Tool Category Class // Update Tool Category DB " + Ex.Message);
            }
        }
    }
}
