using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomTreeView.Database
{
    class BomDatabaseContext: DbContext
    {

        private const string DATABASE_CONNECTION_STRING
            = @"Server=localhost,1433;Database=master;User=sa;Password=PizzaIsMagic=^,^=;";

        public DbSet<BomDbEntry> BomDbEntrySet { get; set; }

        public BomDatabaseContext(): base(DATABASE_CONNECTION_STRING)
        {

        }
    }
}
