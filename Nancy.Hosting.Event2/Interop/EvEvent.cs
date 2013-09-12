using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Nancy.Hosting.Event2.Interop
{
	class EvEvent : SafeHandle
	{
		public EvEvent() : base(IntPtr.Zero, true)
		{
			
		}

		protected override bool ReleaseHandle()
		{
			Event.EventFree(handle);
			return true;
		}

		public override bool IsInvalid
		{
			get { return handle == IntPtr.Zero; }
		}
	}
}
