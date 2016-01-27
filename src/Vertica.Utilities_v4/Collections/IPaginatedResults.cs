﻿namespace Vertica.Utilities_v4.Collections
{
	public interface IPaginatedResults
	{
		uint CurrentPage { get; }
		uint TotalResults { get; }
		uint TotalPages { get; }
		Range<uint> RecordNumbers { get; }
		string PageNumber { get; }
		Pagination Pagination { get; }
	}
}