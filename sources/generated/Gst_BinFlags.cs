// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (Gst.BinFlagsGType))]
	public enum BinFlags {

		NoResync = 16384,
		StreamsAware = 32768,
		Last = 524288,
	}

	internal class BinFlagsGType {
		[DllImport ("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_bin_flags_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_bin_flags_get_type ());
			}
		}
	}
#endregion
}
