using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinema68.Entity;
using Cinema68.Boundary;
using System.Data.SQLite;


namespace Cinema68.Control
{
    class LogoutControl 
    {
        public void LogOut()
        {
            DBConnector DBConnect = new DBConnector();
            SQLiteConnection conn = DBConnect.CreateConnection();
            DBConnect.DropTables(conn);

            StartupController StartController = new StartupController();
            StartController.Initiate();

        }
    }
}
