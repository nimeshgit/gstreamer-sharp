// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Audio {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (Gst.Audio.AudioFormatFlagsGType))]
	public enum AudioFormatFlags {

		Integer = 1,
		Float = 2,
		Signed = 4,
		Complex = 16,
		Unpack = 32,
	}

	internal class AudioFormatFlagsGType {
		[DllImport ("libgstaudio-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_audio_format_flags_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_audio_format_flags_get_type ());
			}
		}
	}
#endregion
}
