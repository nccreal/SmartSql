using SmartSql.DbSession;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartSql.Diagnostics
{
    public class DbSessionOpenAfterEventData : DbSessionEventData
    {
        public DbSessionOpenAfterEventData(Guid operationId, string operation) : base(operationId, operation)
        {

        }
    }
}
