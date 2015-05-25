using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Bsdl.FreshTrade.Repositories.Basic.Utilities.Interfaces
{
    public interface IDatabaseConnectionPool
    {
        IDbConnection GetConnection(int connectionID);
        void ReleaseConnection(IDbConnection connection);
    }
}
