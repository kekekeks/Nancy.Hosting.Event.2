using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Nancy.Hosting.Event2.Interop
{
	class EvHttp : SafeHandle
	{
		public EvHttp()
			: base(IntPtr.Zero, true)
		{

		}

		protected override bool ReleaseHandle()
		{
			Event.EvHttpFree(handle);
			return true;
		}

		public override bool IsInvalid
		{
			get { return IntPtr.Zero == handle; }
		}
	}
}
