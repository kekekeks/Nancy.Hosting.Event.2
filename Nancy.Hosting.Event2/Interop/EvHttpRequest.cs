using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Nancy.Hosting.Event2.Interop
{
	class EvHttpRequest : SafeHandle
	{
		public EvHttpRequest(IntPtr h) : base(IntPtr.Zero, false)
		{
			handle = h;
		}

		protected override bool ReleaseHandle()
		{
			throw new NotSupportedException();
		}

		public override bool IsInvalid
		{
			get { return handle == IntPtr.Zero; }
		}
	}
}
