using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinema68.Entity;
using Cinema68.Boundary;


namespace Cinema68.Control
{
    class StartupController : Controller
    {
        
        public void Initiate()
        {
            DBConnector DBConnect = new DBConnector();
            DBConnect.CreateTable(DBConnect.CreateConnection());
        }
    }
}
