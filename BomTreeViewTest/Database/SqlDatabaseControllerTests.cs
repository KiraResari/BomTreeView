using Microsoft.VisualStudio.TestTools.UnitTesting;
using BomTreeView.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomTreeView.Database.Tests
{
    [TestClass()]
    public class SqlDatabaseControllerTests
    {
        [TestMethod()]
        public void CheckIfBomTableExistsShouldNotThrowAnError()
        {
            SqlDatabaseController sqlDatabaseController = new SqlDatabaseController();
            sqlDatabaseController.CheckIfBomTableExists();
        }
    }
}