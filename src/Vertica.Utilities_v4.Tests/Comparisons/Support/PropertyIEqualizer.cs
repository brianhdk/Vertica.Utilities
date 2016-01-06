﻿using Vertica.Utilities_v4.Comparisons;

namespace Vertica.Utilities_v4.Tests.Comparisons.Support
{
	internal class PropertyIEqualizer : ChainableEqualizer<EqualitySubject>
	{
		protected override bool DoEquals(EqualitySubject x, EqualitySubject y)
		{
			return x.I.Equals(y.I);
		}

		protected override int DoGetHashCode(EqualitySubject obj)
		{
			return obj.I.GetHashCode();
		}
	}
}