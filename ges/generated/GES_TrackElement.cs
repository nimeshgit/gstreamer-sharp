// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GES {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class TrackElement : GES.TimelineElement {

		protected TrackElement (IntPtr raw) : base(raw) {}

		protected TrackElement() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[GLib.Property ("active")]
		public bool Active {
			get {
				GLib.Value val = GetProperty ("active");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("active", val);
				val.Dispose ();
			}
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr ges_track_element_get_track(IntPtr raw);

		[GLib.Property ("track")]
		public GES.Track Track {
			get  {
				IntPtr raw_ret = ges_track_element_get_track(Handle);
				GES.Track ret = GLib.Object.GetObject(raw_ret) as GES.Track;
				return ret;
			}
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern int ges_track_element_get_track_type(IntPtr raw);

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern void ges_track_element_set_track_type(IntPtr raw, int type);

		[GLib.Property ("track-type")]
		public GES.TrackType TrackType {
			get  {
				int raw_ret = ges_track_element_get_track_type(Handle);
				GES.TrackType ret = (GES.TrackType) raw_ret;
				return ret;
			}
			set  {
				ges_track_element_set_track_type(Handle, (int) value);
			}
		}

		[GLib.Signal("control-binding-removed")]
		public event GES.ControlBindingRemovedHandler ControlBindingRemoved {
			add {
				this.AddSignalHandler ("control-binding-removed", value, typeof (GES.ControlBindingRemovedArgs));
			}
			remove {
				this.RemoveSignalHandler ("control-binding-removed", value);
			}
		}

		[GLib.Signal("control-binding-added")]
		public event GES.ControlBindingAddedHandler ControlBindingAdded {
			add {
				this.AddSignalHandler ("control-binding-added", value, typeof (GES.ControlBindingAddedArgs));
			}
			remove {
				this.RemoveSignalHandler ("control-binding-added", value);
			}
		}

		static ControlBindingAddedNativeDelegate ControlBindingAdded_cb_delegate;
		static ControlBindingAddedNativeDelegate ControlBindingAddedVMCallback {
			get {
				if (ControlBindingAdded_cb_delegate == null)
					ControlBindingAdded_cb_delegate = new ControlBindingAddedNativeDelegate (ControlBindingAdded_cb);
				return ControlBindingAdded_cb_delegate;
			}
		}

		static void OverrideControlBindingAdded (GLib.GType gtype)
		{
			OverrideControlBindingAdded (gtype, ControlBindingAddedVMCallback);
		}

		static void OverrideControlBindingAdded (GLib.GType gtype, ControlBindingAddedNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "control-binding-added", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ControlBindingAddedNativeDelegate (IntPtr inst, IntPtr control_binding);

		static void ControlBindingAdded_cb (IntPtr inst, IntPtr control_binding)
		{
			try {
				TrackElement __obj = GLib.Object.GetObject (inst, false) as TrackElement;
				__obj.OnControlBindingAdded (GLib.Object.GetObject(control_binding) as Gst.ControlBinding);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GES.TrackElement), ConnectionMethod="OverrideControlBindingAdded")]
		protected virtual void OnControlBindingAdded (Gst.ControlBinding control_binding)
		{
			InternalControlBindingAdded (control_binding);
		}

		private void InternalControlBindingAdded (Gst.ControlBinding control_binding)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (control_binding);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		static ControlBindingRemovedNativeDelegate ControlBindingRemoved_cb_delegate;
		static ControlBindingRemovedNativeDelegate ControlBindingRemovedVMCallback {
			get {
				if (ControlBindingRemoved_cb_delegate == null)
					ControlBindingRemoved_cb_delegate = new ControlBindingRemovedNativeDelegate (ControlBindingRemoved_cb);
				return ControlBindingRemoved_cb_delegate;
			}
		}

		static void OverrideControlBindingRemoved (GLib.GType gtype)
		{
			OverrideControlBindingRemoved (gtype, ControlBindingRemovedVMCallback);
		}

		static void OverrideControlBindingRemoved (GLib.GType gtype, ControlBindingRemovedNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "control-binding-removed", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ControlBindingRemovedNativeDelegate (IntPtr inst, IntPtr control_binding);

		static void ControlBindingRemoved_cb (IntPtr inst, IntPtr control_binding)
		{
			try {
				TrackElement __obj = GLib.Object.GetObject (inst, false) as TrackElement;
				__obj.OnControlBindingRemoved (GLib.Object.GetObject(control_binding) as Gst.ControlBinding);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GES.TrackElement), ConnectionMethod="OverrideControlBindingRemoved")]
		protected virtual void OnControlBindingRemoved (Gst.ControlBinding control_binding)
		{
			InternalControlBindingRemoved (control_binding);
		}

		private void InternalControlBindingRemoved (Gst.ControlBinding control_binding)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (control_binding);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		static ActiveChangedNativeDelegate ActiveChanged_cb_delegate;
		static ActiveChangedNativeDelegate ActiveChangedVMCallback {
			get {
				if (ActiveChanged_cb_delegate == null)
					ActiveChanged_cb_delegate = new ActiveChangedNativeDelegate (ActiveChanged_cb);
				return ActiveChanged_cb_delegate;
			}
		}

		static void OverrideActiveChanged (GLib.GType gtype)
		{
			OverrideActiveChanged (gtype, ActiveChangedVMCallback);
		}

		static void OverrideActiveChanged (GLib.GType gtype, ActiveChangedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("active_changed"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ActiveChangedNativeDelegate (IntPtr inst, bool active);

		static void ActiveChanged_cb (IntPtr inst, bool active)
		{
			try {
				TrackElement __obj = GLib.Object.GetObject (inst, false) as TrackElement;
				__obj.OnActiveChanged (active);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GES.TrackElement), ConnectionMethod="OverrideActiveChanged")]
		protected virtual void OnActiveChanged (bool active)
		{
			InternalActiveChanged (active);
		}

		private void InternalActiveChanged (bool active)
		{
			ActiveChangedNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("active_changed"));
				unmanaged = (ActiveChangedNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(ActiveChangedNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle, active);
		}

		static ChangedNativeDelegate Changed_cb_delegate;
		static ChangedNativeDelegate ChangedVMCallback {
			get {
				if (Changed_cb_delegate == null)
					Changed_cb_delegate = new ChangedNativeDelegate (Changed_cb);
				return Changed_cb_delegate;
			}
		}

		static void OverrideChanged (GLib.GType gtype)
		{
			OverrideChanged (gtype, ChangedVMCallback);
		}

		static void OverrideChanged (GLib.GType gtype, ChangedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("changed"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ChangedNativeDelegate (IntPtr inst);

		static void Changed_cb (IntPtr inst)
		{
			try {
				TrackElement __obj = GLib.Object.GetObject (inst, false) as TrackElement;
				__obj.OnChanged ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GES.TrackElement), ConnectionMethod="OverrideChanged")]
		protected virtual void OnChanged ()
		{
			InternalChanged ();
		}

		private void InternalChanged ()
		{
			ChangedNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("changed"));
				unmanaged = (ChangedNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(ChangedNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static LookupChildNativeDelegate LookupChild_cb_delegate;
		static LookupChildNativeDelegate LookupChildVMCallback {
			get {
				if (LookupChild_cb_delegate == null)
					LookupChild_cb_delegate = new LookupChildNativeDelegate (LookupChild_cb);
				return LookupChild_cb_delegate;
			}
		}

		static void OverrideLookupChild (GLib.GType gtype)
		{
			OverrideLookupChild (gtype, LookupChildVMCallback);
		}

		static void OverrideLookupChild (GLib.GType gtype, LookupChildNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("lookup_child"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool LookupChildNativeDelegate (IntPtr inst, IntPtr prop_name, out IntPtr element, out IntPtr pspec);

		static bool LookupChild_cb (IntPtr inst, IntPtr prop_name, out IntPtr element, out IntPtr pspec)
		{
			try {
				TrackElement __obj = GLib.Object.GetObject (inst, false) as TrackElement;
				bool __result;
				Gst.Element myelement;
				__result = __obj.OnLookupChild (GLib.Marshaller.Utf8PtrToString (prop_name), out myelement, out pspec);
				element = myelement == null ? IntPtr.Zero : myelement.Handle;
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GES.TrackElement), ConnectionMethod="OverrideLookupChild")]
		protected virtual bool OnLookupChild (string prop_name, out Gst.Element element, out IntPtr pspec)
		{
			return InternalLookupChild (prop_name, out element, out pspec);
		}

		private bool InternalLookupChild (string prop_name, out Gst.Element element, out IntPtr pspec)
		{
			LookupChildNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("lookup_child"));
				unmanaged = (LookupChildNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(LookupChildNativeDelegate));
			}
			if (unmanaged == null) throw new InvalidOperationException ("No base method to invoke");

			IntPtr native_prop_name = GLib.Marshaller.StringToPtrGStrdup (prop_name);
			IntPtr native_element;
			bool __result = unmanaged (this.Handle, native_prop_name, out native_element, out pspec);
			GLib.Marshaller.Free (native_prop_name);
			element = GLib.Object.GetObject(native_element, true) as Gst.Element;
			return __result;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("nleobject_factorytype"
							, GES.TimelineElement.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // nleobject_factorytype
							, null
							, "create_gnl_object"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("create_gnl_object"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // create_gnl_object
							, "nleobject_factorytype"
							, "create_element"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("create_element"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // create_element
							, "create_gnl_object"
							, "active_changed"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("active_changed"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // active_changed
							, "create_element"
							, "changed"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("changed"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // changed
							, "active_changed"
							, "list_children_properties"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("list_children_properties"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // list_children_properties
							, "changed"
							, "lookup_child"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("lookup_child"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // lookup_child
							, "list_children_properties"
							, "_ges_reserved"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_ges_reserved"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 20 // _ges_reserved
							, "lookup_child"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr ges_track_element_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = ges_track_element_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern void ges_track_element_add_children_props(IntPtr raw, IntPtr element, IntPtr[] wanted_categories, IntPtr[] blacklist, IntPtr[] whitelist);

		public void AddChildrenProps(Gst.Element element, string[] wanted_categories, string[] blacklist, string[] whitelist) {
			int cnt_wanted_categories = wanted_categories == null ? 0 : wanted_categories.Length;
			IntPtr[] native_wanted_categories = new IntPtr [cnt_wanted_categories + 1];
			for (int i = 0; i < cnt_wanted_categories; i++)
				native_wanted_categories [i] = GLib.Marshaller.StringToPtrGStrdup (wanted_categories[i]);
			native_wanted_categories [cnt_wanted_categories] = IntPtr.Zero;
			int cnt_blacklist = blacklist == null ? 0 : blacklist.Length;
			IntPtr[] native_blacklist = new IntPtr [cnt_blacklist + 1];
			for (int i = 0; i < cnt_blacklist; i++)
				native_blacklist [i] = GLib.Marshaller.StringToPtrGStrdup (blacklist[i]);
			native_blacklist [cnt_blacklist] = IntPtr.Zero;
			int cnt_whitelist = whitelist == null ? 0 : whitelist.Length;
			IntPtr[] native_whitelist = new IntPtr [cnt_whitelist + 1];
			for (int i = 0; i < cnt_whitelist; i++)
				native_whitelist [i] = GLib.Marshaller.StringToPtrGStrdup (whitelist[i]);
			native_whitelist [cnt_whitelist] = IntPtr.Zero;
			ges_track_element_add_children_props(Handle, element == null ? IntPtr.Zero : element.Handle, native_wanted_categories, native_blacklist, native_whitelist);
			for (int i = 0; i < native_wanted_categories.Length - 1; i++) {
				wanted_categories [i] = GLib.Marshaller.Utf8PtrToString (native_wanted_categories[i]);
				GLib.Marshaller.Free (native_wanted_categories[i]);
			}
			for (int i = 0; i < native_blacklist.Length - 1; i++) {
				blacklist [i] = GLib.Marshaller.Utf8PtrToString (native_blacklist[i]);
				GLib.Marshaller.Free (native_blacklist[i]);
			}
			for (int i = 0; i < native_whitelist.Length - 1; i++) {
				whitelist [i] = GLib.Marshaller.Utf8PtrToString (native_whitelist[i]);
				GLib.Marshaller.Free (native_whitelist[i]);
			}
		}

		public void AddChildrenProps(Gst.Element element) {
			AddChildrenProps (element, null, null, null);
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_track_element_edit(IntPtr raw, IntPtr layers, int mode, int edge, ulong position);

		public bool Edit(GLib.List layers, GES.EditMode mode, GES.Edge edge, ulong position) {
			bool raw_ret = ges_track_element_edit(Handle, layers == null ? IntPtr.Zero : layers.Handle, (int) mode, (int) edge, position);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern System.IntPtr ges_track_element_get_all_control_bindings(IntPtr raw);

		public string[] AllControlBindings { 
			get {
				System.IntPtr raw_ret = ges_track_element_get_all_control_bindings(Handle);
				string[] ret = (string[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(System.IntPtr), false, false, typeof(string));
				return ret;
			}
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr ges_track_element_get_control_binding(IntPtr raw, IntPtr property_name);

		public Gst.ControlBinding GetControlBinding(string property_name) {
			IntPtr native_property_name = GLib.Marshaller.StringToPtrGStrdup (property_name);
			IntPtr raw_ret = ges_track_element_get_control_binding(Handle, native_property_name);
			Gst.ControlBinding ret = GLib.Object.GetObject(raw_ret) as Gst.ControlBinding;
			GLib.Marshaller.Free (native_property_name);
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr ges_track_element_get_element(IntPtr raw);

		public Gst.Element Element { 
			get {
				IntPtr raw_ret = ges_track_element_get_element(Handle);
				Gst.Element ret = GLib.Object.GetObject(raw_ret) as Gst.Element;
				return ret;
			}
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr ges_track_element_get_gnlobject(IntPtr raw);

		[Obsolete]
		public Gst.Element Gnlobject { 
			get {
				IntPtr raw_ret = ges_track_element_get_gnlobject(Handle);
				Gst.Element ret = GLib.Object.GetObject(raw_ret) as Gst.Element;
				return ret;
			}
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr ges_track_element_get_nleobject(IntPtr raw);

		public Gst.Element Nleobject { 
			get {
				IntPtr raw_ret = ges_track_element_get_nleobject(Handle);
				Gst.Element ret = GLib.Object.GetObject(raw_ret) as Gst.Element;
				return ret;
			}
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_track_element_is_active(IntPtr raw);

		public bool IsActive { 
			get {
				bool raw_ret = ges_track_element_is_active(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_track_element_lookup_child(IntPtr raw, IntPtr prop_name, out IntPtr element, out IntPtr pspec);

		[Obsolete]
		public bool LookupChild(string prop_name, out Gst.Element element, out IntPtr pspec) {
			IntPtr native_prop_name = GLib.Marshaller.StringToPtrGStrdup (prop_name);
			IntPtr native_element;
			bool raw_ret = ges_track_element_lookup_child(Handle, native_prop_name, out native_element, out pspec);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_prop_name);
			element = GLib.Object.GetObject(native_element, true) as Gst.Element;
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_track_element_remove_control_binding(IntPtr raw, IntPtr property_name);

		public bool RemoveControlBinding(string property_name) {
			IntPtr native_property_name = GLib.Marshaller.StringToPtrGStrdup (property_name);
			bool raw_ret = ges_track_element_remove_control_binding(Handle, native_property_name);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_property_name);
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_track_element_set_active(IntPtr raw, bool active);

		public bool SetActive(bool active) {
			bool raw_ret = ges_track_element_set_active(Handle, active);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_track_element_set_control_source(IntPtr raw, IntPtr source, IntPtr property_name, IntPtr binding_type);

		public bool SetControlSource(Gst.ControlSource source, string property_name, string binding_type) {
			IntPtr native_property_name = GLib.Marshaller.StringToPtrGStrdup (property_name);
			IntPtr native_binding_type = GLib.Marshaller.StringToPtrGStrdup (binding_type);
			bool raw_ret = ges_track_element_set_control_source(Handle, source == null ? IntPtr.Zero : source.Handle, native_property_name, native_binding_type);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_property_name);
			GLib.Marshaller.Free (native_binding_type);
			return ret;
		}


		static TrackElement ()
		{
			GtkSharp.GstEditingServices.ObjectManager.Initialize ();
		}

		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("active"
							, GES.TimelineElement.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(bool)) // active
							, null
							, "priv"
							, (long) Marshal.OffsetOf(typeof(GESTrackElement_activeAlign), "active")
							, 0
							),
						new GLib.AbiField("priv"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
							, "active"
							, "asset"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("asset"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // asset
							, "priv"
							, "_ges_reserved"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_ges_reserved"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 20 // _ges_reserved
							, "asset"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _abi_info;
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GESTrackElement_activeAlign
		{
			sbyte f1;
			private bool active;
		}


		// End of the ABI representation.

#endregion
	}
}
