﻿using System;

namespace LinqToDB.DataProvider
{
	using Mapping;

	class FirebirdMappingSchema : MappingSchema
	{
		public FirebirdMappingSchema() : base(ProviderName.Firebird)
		{
		}
	}
}
