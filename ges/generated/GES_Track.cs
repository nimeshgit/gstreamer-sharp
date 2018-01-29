// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GES {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Track : Gst.Bin, GES.IMetaContainer {

		public Track (IntPtr raw) : base(raw) {}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr ges_track_new(int type, IntPtr caps);

		public Track (GES.TrackType type, Gst.Caps caps) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Track)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("caps");
				vals.Add (new GLib.Value (caps));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			caps.Owned = false;
			Raw = ges_track_new((int) type, caps == null ? IntPtr.Zero : caps.Handle);
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr ges_track_get_caps(IntPtr raw);

		[GLib.Property ("caps")]
		public Gst.Caps Caps {
			get  {
				IntPtr raw_ret = ges_track_get_caps(Handle);
				Gst.Caps ret = raw_ret == IntPtr.Zero ? null : (Gst.Caps) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Caps), false);
				return ret;
			}
		}

		[GLib.Property ("duration")]
		public ulong Duration {
			get {
				GLib.Value val = GetProperty ("duration");
				ulong ret = (ulong) val;
				val.Dispose ();
				return ret;
			}
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_track_get_mixing(IntPtr raw);

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern void ges_track_set_mixing(IntPtr raw, bool mixing);

		[GLib.Property ("mixing")]
		public bool Mixing {
			get  {
				bool raw_ret = ges_track_get_mixing(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				ges_track_set_mixing(Handle, value);
			}
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern void ges_track_set_restriction_caps(IntPtr raw, IntPtr caps);

		[GLib.Property ("restriction-caps")]
		public Gst.Caps RestrictionCaps {
			get {
				GLib.Value val = GetProperty ("restriction-caps");
				Gst.Caps ret = (Gst.Caps) val;
				val.Dispose ();
				return ret;
			}
			set  {
				ges_track_set_restriction_caps(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[GLib.Property ("track-type")]
		public GES.TrackType TrackType {
			get {
				GLib.Value val = GetProperty ("track-type");
				GES.TrackType ret = (GES.TrackType) (Enum) val;
				val.Dispose ();
				return ret;
			}
		}

		public GES.TrackType Type {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("type"));
					return (GES.TrackType) (*raw_ptr);
				}
			}
		}

		[GLib.Signal("track-element-added")]
		public event GES.TrackElementAddedHandler TrackElementAdded {
			add {
				this.AddSignalHandler ("track-element-added", value, typeof (GES.TrackElementAddedArgs));
			}
			remove {
				this.RemoveSignalHandler ("track-element-added", value);
			}
		}

		[GLib.Signal("track-element-removed")]
		public event GES.TrackElementRemovedHandler TrackElementRemoved {
			add {
				this.AddSignalHandler ("track-element-removed", value, typeof (GES.TrackElementRemovedArgs));
			}
			remove {
				this.RemoveSignalHandler ("track-element-removed", value);
			}
		}

		[GLib.Signal("commited")]
		public event System.EventHandler Commited {
			add {
				this.AddSignalHandler ("commited", value);
			}
			remove {
				this.RemoveSignalHandler ("commited", value);
			}
		}

		static CommitedNativeDelegate Commited_cb_delegate;
		static CommitedNativeDelegate CommitedVMCallback {
			get {
				if (Commited_cb_delegate == null)
					Commited_cb_delegate = new CommitedNativeDelegate (Commited_cb);
				return Commited_cb_delegate;
			}
		}

		static void OverrideCommited (GLib.GType gtype)
		{
			OverrideCommited (gtype, CommitedVMCallback);
		}

		static void OverrideCommited (GLib.GType gtype, CommitedNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "commited", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void CommitedNativeDelegate (IntPtr inst);

		static void Commited_cb (IntPtr inst)
		{
			try {
				Track __obj = GLib.Object.GetObject (inst, false) as Track;
				__obj.OnCommited ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GES.Track), ConnectionMethod="OverrideCommited")]
		protected virtual void OnCommited ()
		{
			InternalCommited ();
		}

		private void InternalCommited ()
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (1);
			GLib.Value[] vals = new GLib.Value [1];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		static TrackElementAddedNativeDelegate TrackElementAdded_cb_delegate;
		static TrackElementAddedNativeDelegate TrackElementAddedVMCallback {
			get {
				if (TrackElementAdded_cb_delegate == null)
					TrackElementAdded_cb_delegate = new TrackElementAddedNativeDelegate (TrackElementAdded_cb);
				return TrackElementAdded_cb_delegate;
			}
		}

		static void OverrideTrackElementAdded (GLib.GType gtype)
		{
			OverrideTrackElementAdded (gtype, TrackElementAddedVMCallback);
		}

		static void OverrideTrackElementAdded (GLib.GType gtype, TrackElementAddedNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "track-element-added", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void TrackElementAddedNativeDelegate (IntPtr inst, IntPtr effect);

		static void TrackElementAdded_cb (IntPtr inst, IntPtr effect)
		{
			try {
				Track __obj = GLib.Object.GetObject (inst, false) as Track;
				__obj.OnTrackElementAdded (GLib.Object.GetObject(effect) as GES.TrackElement);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GES.Track), ConnectionMethod="OverrideTrackElementAdded")]
		protected virtual void OnTrackElementAdded (GES.TrackElement effect)
		{
			InternalTrackElementAdded (effect);
		}

		private void InternalTrackElementAdded (GES.TrackElement effect)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (effect);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		static TrackElementRemovedNativeDelegate TrackElementRemoved_cb_delegate;
		static TrackElementRemovedNativeDelegate TrackElementRemovedVMCallback {
			get {
				if (TrackElementRemoved_cb_delegate == null)
					TrackElementRemoved_cb_delegate = new TrackElementRemovedNativeDelegate (TrackElementRemoved_cb);
				return TrackElementRemoved_cb_delegate;
			}
		}

		static void OverrideTrackElementRemoved (GLib.GType gtype)
		{
			OverrideTrackElementRemoved (gtype, TrackElementRemovedVMCallback);
		}

		static void OverrideTrackElementRemoved (GLib.GType gtype, TrackElementRemovedNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "track-element-removed", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void TrackElementRemovedNativeDelegate (IntPtr inst, IntPtr effect);

		static void TrackElementRemoved_cb (IntPtr inst, IntPtr effect)
		{
			try {
				Track __obj = GLib.Object.GetObject (inst, false) as Track;
				__obj.OnTrackElementRemoved (GLib.Object.GetObject(effect) as GES.TrackElement);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GES.Track), ConnectionMethod="OverrideTrackElementRemoved")]
		protected virtual void OnTrackElementRemoved (GES.TrackElement effect)
		{
			InternalTrackElementRemoved (effect);
		}

		private void InternalTrackElementRemoved (GES.TrackElement effect)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (effect);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("get_mixing_element"
							, Gst.Bin.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // get_mixing_element
							, null
							, "_ges_reserved"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_ges_reserved"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _ges_reserved
							, "get_mixing_element"
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
		static extern IntPtr ges_track_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = ges_track_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_track_add_element(IntPtr raw, IntPtr _object);

		public bool AddElement(GES.TrackElement _object) {
			bool raw_ret = ges_track_add_element(Handle, _object == null ? IntPtr.Zero : _object.OwnedHandle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_track_commit(IntPtr raw);

		public bool Commit() {
			bool raw_ret = ges_track_commit(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr ges_track_get_elements(IntPtr raw);

		public GES.TrackElement[] Elements { 
			get {
				IntPtr raw_ret = ges_track_get_elements(Handle);
				GES.TrackElement[] ret = (GES.TrackElement[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.List), true, true, typeof(GES.TrackElement));
				return ret;
			}
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr ges_track_get_timeline(IntPtr raw);

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern void ges_track_set_timeline(IntPtr raw, IntPtr timeline);

		public GES.Timeline Timeline { 
			get {
				IntPtr raw_ret = ges_track_get_timeline(Handle);
				GES.Timeline ret = GLib.Object.GetObject(raw_ret) as GES.Timeline;
				return ret;
			}
			set {
				ges_track_set_timeline(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_track_remove_element(IntPtr raw, IntPtr _object);

		public bool RemoveElement(GES.TrackElement _object) {
			bool raw_ret = ges_track_remove_element(Handle, _object == null ? IntPtr.Zero : _object.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern void ges_track_update_restriction_caps(IntPtr raw, IntPtr caps);

		public void UpdateRestrictionCaps(Gst.Caps caps) {
			ges_track_update_restriction_caps(Handle, caps == null ? IntPtr.Zero : caps.Handle);
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_meta_container_add_metas_from_string(IntPtr raw, IntPtr str);

		public bool AddMetasFromString(string str) {
			IntPtr native_str = GLib.Marshaller.StringToPtrGStrdup (str);
			bool raw_ret = ges_meta_container_add_metas_from_string(Handle, native_str);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_str);
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_meta_container_check_meta_registered(IntPtr raw, IntPtr meta_item, int flags, IntPtr type);

		public bool CheckMetaRegistered(string meta_item, GES.MetaFlag flags, GLib.GType type) {
			IntPtr native_meta_item = GLib.Marshaller.StringToPtrGStrdup (meta_item);
			bool raw_ret = ges_meta_container_check_meta_registered(Handle, native_meta_item, (int) flags, type.Val);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_meta_item);
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern void ges_meta_container_foreach(IntPtr raw, GESSharp.MetaForeachFuncNative func, IntPtr user_data);

		public void Foreach(GES.MetaForeachFunc func) {
			GESSharp.MetaForeachFuncWrapper func_wrapper = new GESSharp.MetaForeachFuncWrapper (func);
			ges_meta_container_foreach(Handle, func_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_meta_container_get_boolean(IntPtr raw, IntPtr meta_item, out bool dest);

		public bool GetBoolean(string meta_item, out bool dest) {
			IntPtr native_meta_item = GLib.Marshaller.StringToPtrGStrdup (meta_item);
			bool raw_ret = ges_meta_container_get_boolean(Handle, native_meta_item, out dest);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_meta_item);
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_meta_container_get_date_time(IntPtr raw, IntPtr meta_item, out IntPtr dest);

		public bool GetDateTime(string meta_item, out Gst.DateTime dest) {
			IntPtr native_meta_item = GLib.Marshaller.StringToPtrGStrdup (meta_item);
			IntPtr native_dest;
			bool raw_ret = ges_meta_container_get_date_time(Handle, native_meta_item, out native_dest);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_meta_item);
			dest = native_dest == IntPtr.Zero ? null : (Gst.DateTime) GLib.Opaque.GetOpaque (native_dest, typeof (Gst.DateTime), true);
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_meta_container_get_double(IntPtr raw, IntPtr meta_item, out double dest);

		public bool GetDouble(string meta_item, out double dest) {
			IntPtr native_meta_item = GLib.Marshaller.StringToPtrGStrdup (meta_item);
			bool raw_ret = ges_meta_container_get_double(Handle, native_meta_item, out dest);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_meta_item);
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_meta_container_get_float(IntPtr raw, IntPtr meta_item, out float dest);

		public bool GetFloat(string meta_item, out float dest) {
			IntPtr native_meta_item = GLib.Marshaller.StringToPtrGStrdup (meta_item);
			bool raw_ret = ges_meta_container_get_float(Handle, native_meta_item, out dest);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_meta_item);
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_meta_container_get_int(IntPtr raw, IntPtr meta_item, out int dest);

		public bool GetInt(string meta_item, out int dest) {
			IntPtr native_meta_item = GLib.Marshaller.StringToPtrGStrdup (meta_item);
			bool raw_ret = ges_meta_container_get_int(Handle, native_meta_item, out dest);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_meta_item);
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_meta_container_get_int64(IntPtr raw, IntPtr meta_item, out long dest);

		public bool GetInt64(string meta_item, out long dest) {
			IntPtr native_meta_item = GLib.Marshaller.StringToPtrGStrdup (meta_item);
			bool raw_ret = ges_meta_container_get_int64(Handle, native_meta_item, out dest);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_meta_item);
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr ges_meta_container_get_meta(IntPtr raw, IntPtr key);

		public GLib.Value GetMeta(string key) {
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			IntPtr raw_ret = ges_meta_container_get_meta(Handle, native_key);
			GLib.Value ret = (GLib.Value) Marshal.PtrToStructure (raw_ret, typeof (GLib.Value));
			GLib.Marshaller.Free (native_key);
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr ges_meta_container_get_string(IntPtr raw, IntPtr meta_item);

		public string GetString(string meta_item) {
			IntPtr native_meta_item = GLib.Marshaller.StringToPtrGStrdup (meta_item);
			IntPtr raw_ret = ges_meta_container_get_string(Handle, native_meta_item);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			GLib.Marshaller.Free (native_meta_item);
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_meta_container_get_uint(IntPtr raw, IntPtr meta_item, out uint dest);

		public bool GetUint(string meta_item, out uint dest) {
			IntPtr native_meta_item = GLib.Marshaller.StringToPtrGStrdup (meta_item);
			bool raw_ret = ges_meta_container_get_uint(Handle, native_meta_item, out dest);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_meta_item);
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_meta_container_get_uint64(IntPtr raw, IntPtr meta_item, out ulong dest);

		public bool GetUint64(string meta_item, out ulong dest) {
			IntPtr native_meta_item = GLib.Marshaller.StringToPtrGStrdup (meta_item);
			bool raw_ret = ges_meta_container_get_uint64(Handle, native_meta_item, out dest);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_meta_item);
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr ges_meta_container_metas_to_string(IntPtr raw);

		public string MetasToString() {
			IntPtr raw_ret = ges_meta_container_metas_to_string(Handle);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_meta_container_register_meta(IntPtr raw, int flags, IntPtr meta_item, IntPtr value);

		public bool RegisterMeta(GES.MetaFlag flags, string meta_item, GLib.Value value) {
			IntPtr native_meta_item = GLib.Marshaller.StringToPtrGStrdup (meta_item);
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			bool raw_ret = ges_meta_container_register_meta(Handle, (int) flags, native_meta_item, native_value);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_meta_item);
			Marshal.FreeHGlobal (native_value);
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_meta_container_register_meta_boolean(IntPtr raw, int flags, IntPtr meta_item, bool value);

		public bool RegisterMetaBoolean(GES.MetaFlag flags, string meta_item, bool value) {
			IntPtr native_meta_item = GLib.Marshaller.StringToPtrGStrdup (meta_item);
			bool raw_ret = ges_meta_container_register_meta_boolean(Handle, (int) flags, native_meta_item, value);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_meta_item);
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_meta_container_register_meta_date_time(IntPtr raw, int flags, IntPtr meta_item, IntPtr value);

		public bool RegisterMetaDateTime(GES.MetaFlag flags, string meta_item, Gst.DateTime value) {
			IntPtr native_meta_item = GLib.Marshaller.StringToPtrGStrdup (meta_item);
			bool raw_ret = ges_meta_container_register_meta_date_time(Handle, (int) flags, native_meta_item, value == null ? IntPtr.Zero : value.Handle);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_meta_item);
			return ret;
		}

		public bool RegisterMetaDateTime(GES.MetaFlag flags, string meta_item) {
			return RegisterMetaDateTime (flags, meta_item, null);
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_meta_container_register_meta_double(IntPtr raw, int flags, IntPtr meta_item, double value);

		public bool RegisterMetaDouble(GES.MetaFlag flags, string meta_item, double value) {
			IntPtr native_meta_item = GLib.Marshaller.StringToPtrGStrdup (meta_item);
			bool raw_ret = ges_meta_container_register_meta_double(Handle, (int) flags, native_meta_item, value);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_meta_item);
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_meta_container_register_meta_float(IntPtr raw, int flags, IntPtr meta_item, float value);

		public bool RegisterMetaFloat(GES.MetaFlag flags, string meta_item, float value) {
			IntPtr native_meta_item = GLib.Marshaller.StringToPtrGStrdup (meta_item);
			bool raw_ret = ges_meta_container_register_meta_float(Handle, (int) flags, native_meta_item, value);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_meta_item);
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_meta_container_register_meta_int(IntPtr raw, int flags, IntPtr meta_item, int value);

		public bool RegisterMetaInt(GES.MetaFlag flags, string meta_item, int value) {
			IntPtr native_meta_item = GLib.Marshaller.StringToPtrGStrdup (meta_item);
			bool raw_ret = ges_meta_container_register_meta_int(Handle, (int) flags, native_meta_item, value);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_meta_item);
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_meta_container_register_meta_int64(IntPtr raw, int flags, IntPtr meta_item, long value);

		public bool RegisterMetaInt64(GES.MetaFlag flags, string meta_item, long value) {
			IntPtr native_meta_item = GLib.Marshaller.StringToPtrGStrdup (meta_item);
			bool raw_ret = ges_meta_container_register_meta_int64(Handle, (int) flags, native_meta_item, value);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_meta_item);
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_meta_container_register_meta_string(IntPtr raw, int flags, IntPtr meta_item, IntPtr value);

		public bool RegisterMetaString(GES.MetaFlag flags, string meta_item, string value) {
			IntPtr native_meta_item = GLib.Marshaller.StringToPtrGStrdup (meta_item);
			IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
			bool raw_ret = ges_meta_container_register_meta_string(Handle, (int) flags, native_meta_item, native_value);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_meta_item);
			GLib.Marshaller.Free (native_value);
			return ret;
		}

		public bool RegisterMetaString(GES.MetaFlag flags, string meta_item) {
			return RegisterMetaString (flags, meta_item, null);
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_meta_container_register_meta_uint(IntPtr raw, int flags, IntPtr meta_item, uint value);

		public bool RegisterMetaUint(GES.MetaFlag flags, string meta_item, uint value) {
			IntPtr native_meta_item = GLib.Marshaller.StringToPtrGStrdup (meta_item);
			bool raw_ret = ges_meta_container_register_meta_uint(Handle, (int) flags, native_meta_item, value);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_meta_item);
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_meta_container_register_meta_uint64(IntPtr raw, int flags, IntPtr meta_item, ulong value);

		public bool RegisterMetaUint64(GES.MetaFlag flags, string meta_item, ulong value) {
			IntPtr native_meta_item = GLib.Marshaller.StringToPtrGStrdup (meta_item);
			bool raw_ret = ges_meta_container_register_meta_uint64(Handle, (int) flags, native_meta_item, value);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_meta_item);
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_meta_container_set_boolean(IntPtr raw, IntPtr meta_item, bool value);

		public bool SetBoolean(string meta_item, bool value) {
			IntPtr native_meta_item = GLib.Marshaller.StringToPtrGStrdup (meta_item);
			bool raw_ret = ges_meta_container_set_boolean(Handle, native_meta_item, value);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_meta_item);
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_meta_container_set_date_time(IntPtr raw, IntPtr meta_item, IntPtr value);

		public bool SetDateTime(string meta_item, Gst.DateTime value) {
			IntPtr native_meta_item = GLib.Marshaller.StringToPtrGStrdup (meta_item);
			bool raw_ret = ges_meta_container_set_date_time(Handle, native_meta_item, value == null ? IntPtr.Zero : value.Handle);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_meta_item);
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_meta_container_set_double(IntPtr raw, IntPtr meta_item, double value);

		public bool SetDouble(string meta_item, double value) {
			IntPtr native_meta_item = GLib.Marshaller.StringToPtrGStrdup (meta_item);
			bool raw_ret = ges_meta_container_set_double(Handle, native_meta_item, value);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_meta_item);
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_meta_container_set_float(IntPtr raw, IntPtr meta_item, float value);

		public bool SetFloat(string meta_item, float value) {
			IntPtr native_meta_item = GLib.Marshaller.StringToPtrGStrdup (meta_item);
			bool raw_ret = ges_meta_container_set_float(Handle, native_meta_item, value);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_meta_item);
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_meta_container_set_int(IntPtr raw, IntPtr meta_item, int value);

		public bool SetInt(string meta_item, int value) {
			IntPtr native_meta_item = GLib.Marshaller.StringToPtrGStrdup (meta_item);
			bool raw_ret = ges_meta_container_set_int(Handle, native_meta_item, value);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_meta_item);
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_meta_container_set_int64(IntPtr raw, IntPtr meta_item, long value);

		public bool SetInt64(string meta_item, long value) {
			IntPtr native_meta_item = GLib.Marshaller.StringToPtrGStrdup (meta_item);
			bool raw_ret = ges_meta_container_set_int64(Handle, native_meta_item, value);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_meta_item);
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_meta_container_set_meta(IntPtr raw, IntPtr meta_item, IntPtr value);

		public bool SetMeta(string meta_item, GLib.Value value) {
			IntPtr native_meta_item = GLib.Marshaller.StringToPtrGStrdup (meta_item);
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			bool raw_ret = ges_meta_container_set_meta(Handle, native_meta_item, native_value);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_meta_item);
			Marshal.FreeHGlobal (native_value);
			return ret;
		}

		public bool SetMeta(string meta_item) {
			return SetMeta (meta_item, GLib.Value.Empty);
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_meta_container_set_string(IntPtr raw, IntPtr meta_item, IntPtr value);

		public bool SetString(string meta_item, string value) {
			IntPtr native_meta_item = GLib.Marshaller.StringToPtrGStrdup (meta_item);
			IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
			bool raw_ret = ges_meta_container_set_string(Handle, native_meta_item, native_value);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_meta_item);
			GLib.Marshaller.Free (native_value);
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_meta_container_set_uint(IntPtr raw, IntPtr meta_item, uint value);

		public bool SetUint(string meta_item, uint value) {
			IntPtr native_meta_item = GLib.Marshaller.StringToPtrGStrdup (meta_item);
			bool raw_ret = ges_meta_container_set_uint(Handle, native_meta_item, value);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_meta_item);
			return ret;
		}

		[DllImport("ges-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_meta_container_set_uint64(IntPtr raw, IntPtr meta_item, ulong value);

		public bool SetUint64(string meta_item, ulong value) {
			IntPtr native_meta_item = GLib.Marshaller.StringToPtrGStrdup (meta_item);
			bool raw_ret = ges_meta_container_set_uint64(Handle, native_meta_item, value);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_meta_item);
			return ret;
		}

		[GLib.Signal("notify-meta")]
		public event GES.NotifyMetaHandler NotifyMeta {
			add {
				this.AddSignalHandler ("notify-meta", value, typeof (GES.NotifyMetaArgs));
			}
			remove {
				this.RemoveSignalHandler ("notify-meta", value);
			}
		}

		static NotifyMetaNativeDelegate NotifyMeta_cb_delegate;
		static NotifyMetaNativeDelegate NotifyMetaVMCallback {
			get {
				if (NotifyMeta_cb_delegate == null)
					NotifyMeta_cb_delegate = new NotifyMetaNativeDelegate (NotifyMeta_cb);
				return NotifyMeta_cb_delegate;
			}
		}

		static void OverrideNotifyMeta (GLib.GType gtype)
		{
			OverrideNotifyMeta (gtype, NotifyMetaVMCallback);
		}

		static void OverrideNotifyMeta (GLib.GType gtype, NotifyMetaNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "notify-meta", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void NotifyMetaNativeDelegate (IntPtr inst, IntPtr _object, IntPtr p0);

		static void NotifyMeta_cb (IntPtr inst, IntPtr _object, IntPtr p0)
		{
			try {
				GES.Track __obj = GLib.Object.GetObject (inst, false) as GES.Track;
				__obj.OnNotifyMeta (GLib.Marshaller.Utf8PtrToString (_object), (GLib.Value) Marshal.PtrToStructure (p0, typeof (GLib.Value)));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GES.Track), ConnectionMethod="OverrideNotifyMeta")]
		protected virtual void OnNotifyMeta (string _object, GLib.Value p0)
		{
			InternalNotifyMeta (_object, p0);
		}

		private void InternalNotifyMeta (string _object, GLib.Value p0)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (3);
			GLib.Value[] vals = new GLib.Value [3];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (_object);
			inst_and_params.Append (vals [1]);
			vals [2] = new GLib.Value (p0);
			inst_and_params.Append (vals [2]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}


		static Track ()
		{
			GtkSharp.GstEditingServices.ObjectManager.Initialize ();
		}

		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("type"
							, Gst.Bin.abi_info.Fields
							, (uint) Marshal.SizeOf(System.Enum.GetUnderlyingType(typeof(GES.TrackType))) // type
							, null
							, "priv"
							, (long) Marshal.OffsetOf(typeof(GESTrack_typeAlign), "type")
							, 0
							),
						new GLib.AbiField("priv"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
							, "type"
							, "_ges_reserved"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_ges_reserved"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _ges_reserved
							, "priv"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _abi_info;
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GESTrack_typeAlign
		{
			sbyte f1;
			private GES.TrackType type;
		}


		// End of the ABI representation.

#endregion
	}
}
