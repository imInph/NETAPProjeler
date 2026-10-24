using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciBilgiSistemi
{
    internal class Methods
    {
        internal static class FormSwitching
        {
            public static void FormSwitch(Form currentForm, Form nextForm)
            {
                nextForm.StartPosition = FormStartPosition.Manual;

                nextForm.Bounds = currentForm.Bounds;

                currentForm.Hide();
                nextForm.Show();
            }
        }
        
        internal static class DbList
        {
            public static void ListDb(string dbName, DataGridView dbDataGridView)
            {
                DataTable dataTable = new DataTable();
                if (dbName == "users")
                {
                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter("Select * from Users", Variables.DbConn.UserConn);
                    dataAdapter.Fill(dataTable);
                    dbDataGridView.DataSource = dataTable;
                }
                else if (dbName == "students")
                {
                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter("Select * from Students", Variables.DbConn.StudentsConn);
                    dataAdapter.Fill(dataTable);
                    dbDataGridView.DataSource = dataTable;
                }
                else if (dbName == "subjects")
                {
                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter("Select * from Subjects", Variables.DbConn.SubjectsConn);
                    dataAdapter.Fill(dataTable);
                    dbDataGridView.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Invalid database name");
                }
            }
        }

        internal static class DbConn
        {
            public static void DbConnectionOpen(string connName)
            {
                if (connName == "users")
                {
                    if (Variables.DbConn.UserConn.State == ConnectionState.Closed)
                    {
                        Variables.DbConn.UserConn.Open();
                    }
                }
                else if (connName == "students")
                {
                    if (Variables.DbConn.StudentsConn.State == ConnectionState.Closed)
                    {
                        Variables.DbConn.StudentsConn.Open();
                    }
                }
                else if (connName == "subjects")
                {
                    if (Variables.DbConn.SubjectsConn.State == ConnectionState.Closed)
                    {
                        Variables.DbConn.SubjectsConn.Open();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid connection name");
                }
            }

            public static void DbConnectionClose(string connName)
            {
                if (connName == "users")
                {
                    if (Variables.DbConn.UserConn.State == ConnectionState.Open)
                    {
                        Variables.DbConn.UserConn.Close();
                    }
                }
                else if (connName == "students")
                {
                    if (Variables.DbConn.StudentsConn.State == ConnectionState.Open)
                    {
                        Variables.DbConn.StudentsConn.Close();
                    }
                }
                else if (connName == "subjects")
                {
                    if (Variables.DbConn.SubjectsConn.State == ConnectionState.Open)
                    {
                        Variables.DbConn.SubjectsConn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid connection name");
                }
            }
        }
    }
}