﻿using System.Collections.Generic;

namespace Vertica.Utilities.Tests.Comparisons.Support
{
	internal class Property2Comparer : IComparer<ComparisonSubject>
	{
		public int Compare(ComparisonSubject x, ComparisonSubject y)
		{
			return x.Property2.CompareTo(y.Property2);
		}
	}
}