// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct BufferPoolAcquireParams : IEquatable<BufferPoolAcquireParams> {

		public Gst.Format Format;
		public long Start;
		public long Stop;
		public Gst.BufferPoolAcquireFlags Flags;
		[MarshalAs (UnmanagedType.ByValArray, SizeConst=4)]
		private IntPtr[] _gstGstReserved;

		public static Gst.BufferPoolAcquireParams Zero = new Gst.BufferPoolAcquireParams ();

		public static Gst.BufferPoolAcquireParams New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gst.BufferPoolAcquireParams.Zero;
			return (Gst.BufferPoolAcquireParams) Marshal.PtrToStructure (raw, typeof (Gst.BufferPoolAcquireParams));
		}

		public bool Equals (BufferPoolAcquireParams other)
		{
			return true && Format.Equals (other.Format) && Start.Equals (other.Start) && Stop.Equals (other.Stop) && Flags.Equals (other.Flags);
		}

		public override bool Equals (object other)
		{
			return other is BufferPoolAcquireParams && Equals ((BufferPoolAcquireParams) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ Format.GetHashCode () ^ Start.GetHashCode () ^ Stop.GetHashCode () ^ Flags.GetHashCode ();
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}
