using System;
using System.Collections.Generic;
using System.Text;
using NpgsqlTypes;
using SmartSql.TypeHandlers;

namespace SmartSql.TypeHandler.PostgreSql
{
    public class LineSegmentTypeHandler : AbstractNullableTypeHandler<NpgsqlLSeg, NpgsqlLSeg>
    {
    }
}
