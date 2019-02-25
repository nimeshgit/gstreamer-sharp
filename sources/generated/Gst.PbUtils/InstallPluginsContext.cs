// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.PbUtils {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct InstallPluginsContext : IEquatable<InstallPluginsContext> {


		public static Gst.PbUtils.InstallPluginsContext Zero = new Gst.PbUtils.InstallPluginsContext ();

		public static Gst.PbUtils.InstallPluginsContext New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gst.PbUtils.InstallPluginsContext.Zero;
			return (Gst.PbUtils.InstallPluginsContext) Marshal.PtrToStructure (raw, typeof (Gst.PbUtils.InstallPluginsContext));
		}

		[DllImport("libgstpbutils-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_install_plugins_context_new();

		public static InstallPluginsContext New()
		{
			InstallPluginsContext result = InstallPluginsContext.New (gst_install_plugins_context_new());
			return result;
		}

		[DllImport("libgstpbutils-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_install_plugins_context_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_install_plugins_context_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgstpbutils-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_install_plugins_context_set_confirm_search(IntPtr raw, bool confirm_search);

		public bool ConfirmSearch { 
			set {
				IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
				System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
				gst_install_plugins_context_set_confirm_search(this_as_native, value);
				ReadNative (this_as_native, ref this);
				System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			}
		}

		[DllImport("libgstpbutils-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_install_plugins_context_set_desktop_id(IntPtr raw, IntPtr desktop_id);

		public string DesktopId { 
			set {
				IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
				System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gst_install_plugins_context_set_desktop_id(this_as_native, native_value);
				ReadNative (this_as_native, ref this);
				System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgstpbutils-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_install_plugins_context_set_startup_notification_id(IntPtr raw, IntPtr startup_id);

		public string StartupNotificationId { 
			set {
				IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
				System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gst_install_plugins_context_set_startup_notification_id(this_as_native, native_value);
				ReadNative (this_as_native, ref this);
				System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgstpbutils-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_install_plugins_context_set_xid(IntPtr raw, uint xid);

		public uint Xid { 
			set {
				IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
				System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
				gst_install_plugins_context_set_xid(this_as_native, value);
				ReadNative (this_as_native, ref this);
				System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			}
		}

		static void ReadNative (IntPtr native, ref Gst.PbUtils.InstallPluginsContext target)
		{
			target = New (native);
		}

		public bool Equals (InstallPluginsContext other)
		{
			return true;
		}

		public override bool Equals (object other)
		{
			return other is InstallPluginsContext && Equals ((InstallPluginsContext) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode ();
		}

		public static explicit operator GLib.Value (Gst.PbUtils.InstallPluginsContext boxed)
		{
			GLib.Value val = GLib.Value.Empty;
			val.Init (Gst.PbUtils.InstallPluginsContext.GType);
			val.Val = boxed;
			return val;
		}

		public static explicit operator Gst.PbUtils.InstallPluginsContext (GLib.Value val)
		{
			return (Gst.PbUtils.InstallPluginsContext) val.Val;
		}
#endregion
	}
}