namespace Express_Inventory.Configurations
{
    class DatabaseServicer
    {
        // Connection Properties (Todo: Increase Security)
        public static string ConnectionString { get; set; } 

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
