// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Tags {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class TagMux : Gst.Element, Gst.ITagSetter {

		protected TagMux (IntPtr raw) : base(raw) {}

		protected TagMux() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		static RenderStartTagNativeDelegate RenderStartTag_cb_delegate;
		static RenderStartTagNativeDelegate RenderStartTagVMCallback {
			get {
				if (RenderStartTag_cb_delegate == null)
					RenderStartTag_cb_delegate = new RenderStartTagNativeDelegate (RenderStartTag_cb);
				return RenderStartTag_cb_delegate;
			}
		}

		static void OverrideRenderStartTag (GLib.GType gtype)
		{
			OverrideRenderStartTag (gtype, RenderStartTagVMCallback);
		}

		static void OverrideRenderStartTag (GLib.GType gtype, RenderStartTagNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("render_start_tag"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr RenderStartTagNativeDelegate (IntPtr inst, IntPtr tag_list);

		static IntPtr RenderStartTag_cb (IntPtr inst, IntPtr tag_list)
		{
			try {
				TagMux __obj = GLib.Object.GetObject (inst, false) as TagMux;
				Gst.Buffer __result;
				__result = __obj.OnRenderStartTag (tag_list == IntPtr.Zero ? null : (Gst.TagList) GLib.Opaque.GetOpaque (tag_list, typeof (Gst.TagList), false));
				return __result == null ? IntPtr.Zero : __result.OwnedCopy;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.Tags.TagMux), ConnectionMethod="OverrideRenderStartTag")]
		protected virtual Gst.Buffer OnRenderStartTag (Gst.TagList tag_list)
		{
			return InternalRenderStartTag (tag_list);
		}

		private Gst.Buffer InternalRenderStartTag (Gst.TagList tag_list)
		{
			RenderStartTagNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("render_start_tag"));
				unmanaged = (RenderStartTagNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(RenderStartTagNativeDelegate));
			}
			if (unmanaged == null) return null;

			IntPtr __result = unmanaged (this.Handle, tag_list == null ? IntPtr.Zero : tag_list.Handle);
			return __result == IntPtr.Zero ? null : (Gst.Buffer) GLib.Opaque.GetOpaque (__result, typeof (Gst.Buffer), true);
		}

		static RenderEndTagNativeDelegate RenderEndTag_cb_delegate;
		static RenderEndTagNativeDelegate RenderEndTagVMCallback {
			get {
				if (RenderEndTag_cb_delegate == null)
					RenderEndTag_cb_delegate = new RenderEndTagNativeDelegate (RenderEndTag_cb);
				return RenderEndTag_cb_delegate;
			}
		}

		static void OverrideRenderEndTag (GLib.GType gtype)
		{
			OverrideRenderEndTag (gtype, RenderEndTagVMCallback);
		}

		static void OverrideRenderEndTag (GLib.GType gtype, RenderEndTagNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("render_end_tag"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr RenderEndTagNativeDelegate (IntPtr inst, IntPtr tag_list);

		static IntPtr RenderEndTag_cb (IntPtr inst, IntPtr tag_list)
		{
			try {
				TagMux __obj = GLib.Object.GetObject (inst, false) as TagMux;
				Gst.Buffer __result;
				__result = __obj.OnRenderEndTag (tag_list == IntPtr.Zero ? null : (Gst.TagList) GLib.Opaque.GetOpaque (tag_list, typeof (Gst.TagList), false));
				return __result == null ? IntPtr.Zero : __result.OwnedCopy;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.Tags.TagMux), ConnectionMethod="OverrideRenderEndTag")]
		protected virtual Gst.Buffer OnRenderEndTag (Gst.TagList tag_list)
		{
			return InternalRenderEndTag (tag_list);
		}

		private Gst.Buffer InternalRenderEndTag (Gst.TagList tag_list)
		{
			RenderEndTagNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("render_end_tag"));
				unmanaged = (RenderEndTagNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(RenderEndTagNativeDelegate));
			}
			if (unmanaged == null) return null;

			IntPtr __result = unmanaged (this.Handle, tag_list == null ? IntPtr.Zero : tag_list.Handle);
			return __result == IntPtr.Zero ? null : (Gst.Buffer) GLib.Opaque.GetOpaque (__result, typeof (Gst.Buffer), true);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("render_start_tag"
							, Gst.Element.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // render_start_tag
							, null
							, "render_end_tag"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("render_end_tag"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // render_end_tag
							, "render_start_tag"
							, "_gst_reserved"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gst_reserved"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _gst_reserved
							, "render_end_tag"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport("libgsttag-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_tag_mux_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_tag_mux_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_tag_setter_add_tag_value(IntPtr raw, int mode, IntPtr tag, IntPtr value);

		public void AddTagValue(Gst.TagMergeMode mode, string tag, GLib.Value value) {
			IntPtr native_tag = GLib.Marshaller.StringToPtrGStrdup (tag);
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			gst_tag_setter_add_tag_value(Handle, (int) mode, native_tag, native_value);
			GLib.Marshaller.Free (native_tag);
			Marshal.FreeHGlobal (native_value);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_tag_setter_get_tag_list(IntPtr raw);

		public Gst.TagList TagList { 
			get {
				IntPtr raw_ret = gst_tag_setter_get_tag_list(Handle);
				Gst.TagList ret = raw_ret == IntPtr.Zero ? null : (Gst.TagList) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.TagList), false);
				return ret;
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_tag_setter_get_tag_merge_mode(IntPtr raw);

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_tag_setter_set_tag_merge_mode(IntPtr raw, int mode);

		public Gst.TagMergeMode TagMergeMode { 
			get {
				int raw_ret = gst_tag_setter_get_tag_merge_mode(Handle);
				Gst.TagMergeMode ret = (Gst.TagMergeMode) raw_ret;
				return ret;
			}
			set {
				gst_tag_setter_set_tag_merge_mode(Handle, (int) value);
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_tag_setter_merge_tags(IntPtr raw, IntPtr list, int mode);

		public void MergeTags(Gst.TagList list, Gst.TagMergeMode mode) {
			gst_tag_setter_merge_tags(Handle, list == null ? IntPtr.Zero : list.Handle, (int) mode);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_tag_setter_reset_tags(IntPtr raw);

		public void ResetTags() {
			gst_tag_setter_reset_tags(Handle);
		}


		static TagMux ()
		{
			GtkSharp.GstreamerSharp.ObjectManager.Initialize ();
		}

		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, Gst.Element.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
							, null
							, "_gst_reserved"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gst_reserved"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _gst_reserved
							, "priv"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
