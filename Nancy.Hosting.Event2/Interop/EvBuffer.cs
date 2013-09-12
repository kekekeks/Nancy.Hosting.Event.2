using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Nancy.Hosting.Event2.Interop
{
	class EvBuffer  : SafeHandle
	{
		public EvBuffer()
			: base(IntPtr.Zero, true)
		{
			
		}

		public EvBuffer(IntPtr h, bool owned) : base(IntPtr.Zero, owned)
		{
			handle = h;
		}

		protected override bool ReleaseHandle()
		{
			Event.EvBufferFree(handle);
			return true;
		}

		public override bool IsInvalid
		{
			get { return handle == IntPtr.Zero; }
		}
	}
}
