using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Nancy.Hosting.Event2.Interop
{
	class EvHttpBoundSocket : SafeHandle
	{
		public EvHttpBoundSocket() : base(IntPtr.Zero, false)
		{
		}

		protected override bool ReleaseHandle()
		{
			throw new InvalidOperationException("This handle can't be released from user code");
		}

		public override bool IsInvalid
		{
			get { return handle == IntPtr.Zero; }
		}
	}
}
