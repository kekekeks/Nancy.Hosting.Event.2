using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading;
using Nancy;
using Nancy.Hosting.Event2.EventHttp;

namespace Sandbox
{
	class Program
	{
		static void Main (string[] args)
		{
			Nancy.Hosting.Event2.LibLocator.Init();
			var host = new Nancy.Hosting.Event2.NancyEvent2Host(args[0], int.Parse(args[1]), new DefaultNancyBootstrapper());
			host.Start();
		}

	}
}
