using System;
using System.Collections.Generic;
using System.Text;

namespace Nancy.Hosting.Event2.Interop
{
	internal interface IDynLoader
	{
		IntPtr LoadLibrary(string basePath, string dll);
		IntPtr GetProcAddress(IntPtr dll, string proc);

	}
}