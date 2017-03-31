using System;
using System.Reflection;

namespace TriCheer.Phoenix.ModuleAdaptor
{
	public class Options
	{
		private static BindingFlags outputMethodFlags=BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly | BindingFlags.Static;

		public static BindingFlags OutputMethodFlags
        {
			get
			{
				return outputMethodFlags;
			}
		}
	}
}
