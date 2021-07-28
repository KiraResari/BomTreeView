using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomTreeView.Database
{
    public class SqlDatabaseController
    {
        private const string DATABASE_CONNECTION_STRING
            = @"Server=localhost,1433;Database=master;User=sa;Password=PizzaIsMagic=^,^=;";
        private const string BOM_DATA_TABLE_NAME = "BomData";
        private const string SELECT_BOM_DATA_TABLE_COMMAND
            = "Select * from " + BOM_DATA_TABLE_NAME;
        private const string CREATE_BOM_DATA_TABLE_QUERY
            = @"CREATE TABLE dbo." + BOM_DATA_TABLE_NAME +
                "(" +
                    "ComponentName nvarchar(255) IDENTITY(1,1) NOT NULL," +
                    "ParentName nvarchar(255) NULL" +
                    "Quantity int NULL" +
                    "Type nvarchar(255) NULL" +
                    "Item nvarchar(255) NULL" +
                    "PartNumber nvarchar(255) NULL" +
                    "Title nvarchar(255) NULL" +
                    "Material nvarchar(255) NULL" +
                ");";

        private SqlDataAdapter Adapter { get; set; }
        private SqlConnection Connection { get; set; }

        public SqlDatabaseController()
        {
            Connection = new SqlConnection(DATABASE_CONNECTION_STRING);
            Adapter = new SqlDataAdapter(
                SELECT_BOM_DATA_TABLE_COMMAND,
                Connection
            );
        }

        public bool CheckIfBomTableExists()
        {
            Connection.Open();
            DataTable tableResult = Connection.GetSchema(
                "TABLES",
                new string[] { null, null, BOM_DATA_TABLE_NAME }
            );

            return tableResult.Rows.Count < 0;
        }

        public void CreateBomDataTable()
        {
            SqlCommand createDataTableCommand
                = new SqlCommand(CREATE_BOM_DATA_TABLE_QUERY, Connection);
            try
            {
                Connection.Open();
                createDataTableCommand.ExecuteNonQuery();
                Console.WriteLine("Table Created Successfully");
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error Generated. Details: " + e.ToString());
            }
            finally
            {
                Connection.Close();
                Console.ReadKey();
            }
        }

        public void WriteDataTableToBomDatabase(DataTable table)
        {
            throw new NotImplementedException();
        }

        public DataTable ReadDataTableFromBomDatabase()
        {
            DataTable dataTable = new DataTable();
            Adapter.Fill(dataTable);
            return dataTable;
        }
    }
}
