// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Sdp {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct SDPOrigin : IEquatable<SDPOrigin> {

		public string Username;
		public string SessId;
		public string SessVersion;
		public string Nettype;
		public string Addrtype;
		public string Addr;

		public static Gst.Sdp.SDPOrigin Zero = new Gst.Sdp.SDPOrigin ();

		public static Gst.Sdp.SDPOrigin New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gst.Sdp.SDPOrigin.Zero;
			return (Gst.Sdp.SDPOrigin) Marshal.PtrToStructure (raw, typeof (Gst.Sdp.SDPOrigin));
		}

		public bool Equals (SDPOrigin other)
		{
			return true && Username.Equals (other.Username) && SessId.Equals (other.SessId) && SessVersion.Equals (other.SessVersion) && Nettype.Equals (other.Nettype) && Addrtype.Equals (other.Addrtype) && Addr.Equals (other.Addr);
		}

		public override bool Equals (object other)
		{
			return other is SDPOrigin && Equals ((SDPOrigin) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ Username.GetHashCode () ^ SessId.GetHashCode () ^ SessVersion.GetHashCode () ^ Nettype.GetHashCode () ^ Addrtype.GetHashCode () ^ Addr.GetHashCode ();
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}
