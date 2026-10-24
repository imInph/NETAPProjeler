using System;
using System.IO;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi
{
    internal class Variables
    {

        public static class DbConn
        {
            static string basePath = AppDomain.CurrentDomain.BaseDirectory;
            static string projectPath = Directory.GetParent(basePath).Parent.Parent.Parent.FullName;

            public static OleDbConnection UserConn = new OleDbConnection(
                $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={projectPath}\\Users.mdb");
            public static OleDbConnection StudentsConn = new OleDbConnection(
                $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={projectPath}\\Students.mdb");
            public static OleDbConnection SubjectsConn = new OleDbConnection(
                $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={projectPath}\\Subjects.mdb");
        }

        public static class Session
        {
            public static string tempAccountType = "";
        }
    }
}
