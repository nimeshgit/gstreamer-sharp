// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GES {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (GES.MetaFlagGType))]
	public enum MetaFlag {

		Readable = 1,
		Writable = 2,
		Readwrite = 3,
	}

	internal class MetaFlagGType {
		[DllImport ("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr ges_meta_flag_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (ges_meta_flag_get_type ());
			}
		}
	}
#endregion
}
