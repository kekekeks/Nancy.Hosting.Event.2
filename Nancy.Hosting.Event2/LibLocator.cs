using System;
using System.Collections.Generic;
using System.Text;
using Nancy.Hosting.Event2.Interop;

namespace Nancy.Hosting.Event2
{
    public static class LibLocator
    {
		public static void Init(string basePath = null)
		{
			Event.Init(basePath);
		}
    }
}
