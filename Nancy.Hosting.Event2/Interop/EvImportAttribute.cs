using System;
using System.Collections.Generic;
using System.Text;

namespace Nancy.Hosting.Event2.Interop
{
	internal class EvImportAttribute : Attribute
	{
		public EvDll Dll { get; set; }

		public EvImportAttribute(EvDll dll = EvDll.Core)
		{
			Dll = dll;
		}
	}

	internal enum EvDll
	{
		Core,
		Extra,
		Pthread
	}
}