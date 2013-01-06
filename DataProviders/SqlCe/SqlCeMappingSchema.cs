﻿using System;
using System.Data.SqlTypes;
using System.IO;
using System.Text;
using System.Xml;

namespace LinqToDB.DataProvider
{
	using Common;
	using Mapping;

	class SqlCeMappingSchema : MappingSchema
	{
		public SqlCeMappingSchema() : base(ProviderName.SqlCe)
		{
			SetConvertExpression<SqlXml,XmlReader>(
				s => s.IsNull ? DefaultValue<XmlReader>.Value : s.CreateReader(),
				s => s.CreateReader());

			SetConvertExpression<string,SqlXml>(s => new SqlXml(new MemoryStream(Encoding.UTF8.GetBytes(s))));

			SetDefaultValue(SqlBinary.  Null);
			SetDefaultValue(SqlBoolean. Null);
			SetDefaultValue(SqlByte.    Null);
			SetDefaultValue(SqlDateTime.Null);
			SetDefaultValue(SqlDecimal. Null);
			SetDefaultValue(SqlDouble.  Null);
			SetDefaultValue(SqlGuid.    Null);
			SetDefaultValue(SqlInt16.   Null);
			SetDefaultValue(SqlInt32.   Null);
			SetDefaultValue(SqlInt64.   Null);
			SetDefaultValue(SqlMoney.   Null);
			SetDefaultValue(SqlSingle.  Null);
			SetDefaultValue(SqlString.  Null);
			SetDefaultValue(SqlXml.     Null);

			SetScalarType(typeof(SqlBinary));
			SetScalarType(typeof(SqlBoolean));
			SetScalarType(typeof(SqlByte));
			SetScalarType(typeof(SqlDateTime));
			SetScalarType(typeof(SqlDecimal));
			SetScalarType(typeof(SqlDouble));
			SetScalarType(typeof(SqlGuid));
			SetScalarType(typeof(SqlInt16));
			SetScalarType(typeof(SqlInt32));
			SetScalarType(typeof(SqlInt64));
			SetScalarType(typeof(SqlMoney));
			SetScalarType(typeof(SqlSingle));
			SetScalarType(typeof(SqlString));
			SetScalarType(typeof(SqlXml));
		}
	}
}