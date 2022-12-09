using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W10
{
    public class DatabaseHelper
    {
        public delegate void DbOperationHandler(object sender, EventArgs e);
        public event DbOperationHandler ConnectEvent;
        public event DbOperationHandler InsertEvent;
        public event DbOperationHandler UpdateEvent;
        public event DbOperationHandler DeleteEvent;
        public event DbOperationHandler BackupDatabaseEvent;

        public bool Connect()
        {
            Console.WriteLine("Connection is Success");
            if (ConnectEvent!=null)
            {
                ConnectEvent(this,EventArgs.Empty);
            }
            
            return true;
        }
        public void Insert()
        {

            Console.WriteLine("Insert new record Completed");
            if (InsertEvent != null)
            {
                InsertEvent(this, EventArgs.Empty);
            }
        }

        public void Update()
        {

            Console.WriteLine("Update record Completed");
            if (UpdateEvent != null)
            {
                UpdateEvent(this, EventArgs.Empty);
            }
        }

        public void Delete()
        {

            Console.WriteLine("Delete record Completed");
            if (UpdateEvent != null)
            {
                DeleteEvent(this, EventArgs.Empty);
            }

        }

        public bool BackupDatabase()
        {
            Console.WriteLine("Database baked up...");
            if (BackupDatabaseEvent != null)
            {
                DeleteEvent(this, EventArgs.Empty);
            }
            return true;
        }
    }
}
