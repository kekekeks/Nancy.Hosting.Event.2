using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nancy.Hosting.Event2.Interop
{
	[Flags]
	enum EvLoopFlags
	{
		Once = 1,
		NonBlock = 2
	}
}
