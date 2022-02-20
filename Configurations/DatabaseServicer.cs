namespace Express_Inventory.Configurations
{
    class DatabaseServicer
    {
        // Connection Properties (Todo: Increase Security)
        public static string ConnectionString { get; set; } = "server=expressinventory.c5m8cxzwgkhr.eu-west-2.rds.amazonaws.com;Port=6066;user=InventoryManager;password=2a15$BtRpCq.O90vfFNLOaU4u.M5Be9XSGgm;database=sys;Connection Timeout=60";

        // Setup Connection
        public static string ExecuteScalar(string Query, string Database = "sys")
        {
            string Result = string.Empty;
            try
            {
                // Open & Dispose
                using (MySqlConnection Connection = new(ConnectionString))
                {
                    Connection.Open();
                    using (MySqlCommand CMD = new(Query, Connection))
                    {
                        // Grab Values
                        Result = CMD.ExecuteScalar().ToString();
                    }
                    Connection.Close();
                }

                // Check Nulls
                if (Result == "" || Result is null)
                {
                    return "[!] Value Retrieval Failed [Query: " + Query + "] [Reason: Result Is Null or Empty]";
                }

                // Return Value
                return Result;
            }
            catch
            {
                // Return Errors
                return "[!] Value Retrieval Failed [Query: " + Query + "] [Reason: Connection To The Database Failed]";
            }
        }
    }
}
