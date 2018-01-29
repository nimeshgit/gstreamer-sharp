// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Value {

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_value_can_compare(IntPtr value1, IntPtr value2);

		public static bool CanCompare(GLib.Value value1, GLib.Value value2) {
			IntPtr native_value1 = GLib.Marshaller.StructureToPtrAlloc (value1);
			IntPtr native_value2 = GLib.Marshaller.StructureToPtrAlloc (value2);
			bool raw_ret = gst_value_can_compare(native_value1, native_value2);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_value1);
			Marshal.FreeHGlobal (native_value2);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_value_can_intersect(IntPtr value1, IntPtr value2);

		public static bool CanIntersect(GLib.Value value1, GLib.Value value2) {
			IntPtr native_value1 = GLib.Marshaller.StructureToPtrAlloc (value1);
			IntPtr native_value2 = GLib.Marshaller.StructureToPtrAlloc (value2);
			bool raw_ret = gst_value_can_intersect(native_value1, native_value2);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_value1);
			Marshal.FreeHGlobal (native_value2);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_value_can_subtract(IntPtr minuend, IntPtr subtrahend);

		public static bool CanSubtract(GLib.Value minuend, GLib.Value subtrahend) {
			IntPtr native_minuend = GLib.Marshaller.StructureToPtrAlloc (minuend);
			IntPtr native_subtrahend = GLib.Marshaller.StructureToPtrAlloc (subtrahend);
			bool raw_ret = gst_value_can_subtract(native_minuend, native_subtrahend);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_minuend);
			Marshal.FreeHGlobal (native_subtrahend);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_value_can_union(IntPtr value1, IntPtr value2);

		public static bool CanUnion(GLib.Value value1, GLib.Value value2) {
			IntPtr native_value1 = GLib.Marshaller.StructureToPtrAlloc (value1);
			IntPtr native_value2 = GLib.Marshaller.StructureToPtrAlloc (value2);
			bool raw_ret = gst_value_can_union(native_value1, native_value2);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_value1);
			Marshal.FreeHGlobal (native_value2);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_value_compare(IntPtr value1, IntPtr value2);

		public static int Compare(GLib.Value value1, GLib.Value value2) {
			IntPtr native_value1 = GLib.Marshaller.StructureToPtrAlloc (value1);
			IntPtr native_value2 = GLib.Marshaller.StructureToPtrAlloc (value2);
			int raw_ret = gst_value_compare(native_value1, native_value2);
			int ret = raw_ret;
			Marshal.FreeHGlobal (native_value1);
			Marshal.FreeHGlobal (native_value2);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_value_deserialize(IntPtr dest, IntPtr src);

		public static bool Deserialize(out GLib.Value dest, string src) {
			IntPtr native_dest = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (GLib.Value)));
			IntPtr native_src = GLib.Marshaller.StringToPtrGStrdup (src);
			bool raw_ret = gst_value_deserialize(native_dest, native_src);
			bool ret = raw_ret;
			dest = (GLib.Value) Marshal.PtrToStructure (native_dest, typeof (GLib.Value));
			Marshal.FreeHGlobal (native_dest);
			GLib.Marshaller.Free (native_src);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_value_fixate(IntPtr dest, IntPtr src);

		public static bool Fixate(GLib.Value dest, GLib.Value src) {
			IntPtr native_dest = GLib.Marshaller.StructureToPtrAlloc (dest);
			IntPtr native_src = GLib.Marshaller.StructureToPtrAlloc (src);
			bool raw_ret = gst_value_fixate(native_dest, native_src);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_dest);
			Marshal.FreeHGlobal (native_src);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_value_fraction_multiply(IntPtr product, IntPtr factor1, IntPtr factor2);

		public static bool FractionMultiply(GLib.Value product, GLib.Value factor1, GLib.Value factor2) {
			IntPtr native_product = GLib.Marshaller.StructureToPtrAlloc (product);
			IntPtr native_factor1 = GLib.Marshaller.StructureToPtrAlloc (factor1);
			IntPtr native_factor2 = GLib.Marshaller.StructureToPtrAlloc (factor2);
			bool raw_ret = gst_value_fraction_multiply(native_product, native_factor1, native_factor2);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_product);
			Marshal.FreeHGlobal (native_factor1);
			Marshal.FreeHGlobal (native_factor2);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_value_fraction_subtract(IntPtr dest, IntPtr minuend, IntPtr subtrahend);

		public static bool FractionSubtract(GLib.Value dest, GLib.Value minuend, GLib.Value subtrahend) {
			IntPtr native_dest = GLib.Marshaller.StructureToPtrAlloc (dest);
			IntPtr native_minuend = GLib.Marshaller.StructureToPtrAlloc (minuend);
			IntPtr native_subtrahend = GLib.Marshaller.StructureToPtrAlloc (subtrahend);
			bool raw_ret = gst_value_fraction_subtract(native_dest, native_minuend, native_subtrahend);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_dest);
			Marshal.FreeHGlobal (native_minuend);
			Marshal.FreeHGlobal (native_subtrahend);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern ulong gst_value_get_bitmask(IntPtr value);

		public static ulong GetBitmask(GLib.Value value) {
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			ulong raw_ret = gst_value_get_bitmask(native_value);
			ulong ret = raw_ret;
			Marshal.FreeHGlobal (native_value);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_value_get_caps(IntPtr value);

		public static Gst.Caps GetCaps(GLib.Value value) {
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			IntPtr raw_ret = gst_value_get_caps(native_value);
			Gst.Caps ret = raw_ret == IntPtr.Zero ? null : (Gst.Caps) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Caps), false);
			Marshal.FreeHGlobal (native_value);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_value_get_caps_features(IntPtr value);

		public static Gst.CapsFeatures GetCapsFeatures(GLib.Value value) {
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			IntPtr raw_ret = gst_value_get_caps_features(native_value);
			Gst.CapsFeatures ret = Gst.CapsFeatures.New (raw_ret);
			Marshal.FreeHGlobal (native_value);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern double gst_value_get_double_range_max(IntPtr value);

		public static double GetDoubleRangeMax(GLib.Value value) {
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			double raw_ret = gst_value_get_double_range_max(native_value);
			double ret = raw_ret;
			Marshal.FreeHGlobal (native_value);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern double gst_value_get_double_range_min(IntPtr value);

		public static double GetDoubleRangeMin(GLib.Value value) {
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			double raw_ret = gst_value_get_double_range_min(native_value);
			double ret = raw_ret;
			Marshal.FreeHGlobal (native_value);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint gst_value_get_flagset_flags(IntPtr value);

		public static uint GetFlagsetFlags(GLib.Value value) {
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			uint raw_ret = gst_value_get_flagset_flags(native_value);
			uint ret = raw_ret;
			Marshal.FreeHGlobal (native_value);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint gst_value_get_flagset_mask(IntPtr value);

		public static uint GetFlagsetMask(GLib.Value value) {
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			uint raw_ret = gst_value_get_flagset_mask(native_value);
			uint ret = raw_ret;
			Marshal.FreeHGlobal (native_value);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_value_get_fraction_denominator(IntPtr value);

		public static int GetFractionDenominator(GLib.Value value) {
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			int raw_ret = gst_value_get_fraction_denominator(native_value);
			int ret = raw_ret;
			Marshal.FreeHGlobal (native_value);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_value_get_fraction_numerator(IntPtr value);

		public static int GetFractionNumerator(GLib.Value value) {
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			int raw_ret = gst_value_get_fraction_numerator(native_value);
			int ret = raw_ret;
			Marshal.FreeHGlobal (native_value);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_value_get_fraction_range_max(IntPtr value);

		public static GLib.Value GetFractionRangeMax(GLib.Value value) {
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			IntPtr raw_ret = gst_value_get_fraction_range_max(native_value);
			GLib.Value ret = (GLib.Value) Marshal.PtrToStructure (raw_ret, typeof (GLib.Value));
			Marshal.FreeHGlobal (native_value);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_value_get_fraction_range_min(IntPtr value);

		public static GLib.Value GetFractionRangeMin(GLib.Value value) {
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			IntPtr raw_ret = gst_value_get_fraction_range_min(native_value);
			GLib.Value ret = (GLib.Value) Marshal.PtrToStructure (raw_ret, typeof (GLib.Value));
			Marshal.FreeHGlobal (native_value);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern long gst_value_get_int64_range_max(IntPtr value);

		public static long GetInt64RangeMax(GLib.Value value) {
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			long raw_ret = gst_value_get_int64_range_max(native_value);
			long ret = raw_ret;
			Marshal.FreeHGlobal (native_value);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern long gst_value_get_int64_range_min(IntPtr value);

		public static long GetInt64RangeMin(GLib.Value value) {
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			long raw_ret = gst_value_get_int64_range_min(native_value);
			long ret = raw_ret;
			Marshal.FreeHGlobal (native_value);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern long gst_value_get_int64_range_step(IntPtr value);

		public static long GetInt64RangeStep(GLib.Value value) {
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			long raw_ret = gst_value_get_int64_range_step(native_value);
			long ret = raw_ret;
			Marshal.FreeHGlobal (native_value);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_value_get_int_range_max(IntPtr value);

		public static int GetIntRangeMax(GLib.Value value) {
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			int raw_ret = gst_value_get_int_range_max(native_value);
			int ret = raw_ret;
			Marshal.FreeHGlobal (native_value);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_value_get_int_range_min(IntPtr value);

		public static int GetIntRangeMin(GLib.Value value) {
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			int raw_ret = gst_value_get_int_range_min(native_value);
			int ret = raw_ret;
			Marshal.FreeHGlobal (native_value);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_value_get_int_range_step(IntPtr value);

		public static int GetIntRangeStep(GLib.Value value) {
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			int raw_ret = gst_value_get_int_range_step(native_value);
			int ret = raw_ret;
			Marshal.FreeHGlobal (native_value);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_value_get_structure(IntPtr value);

		public static Gst.Structure GetStructure(GLib.Value value) {
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			IntPtr raw_ret = gst_value_get_structure(native_value);
			Gst.Structure ret = raw_ret == IntPtr.Zero ? null : (Gst.Structure) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Structure), false);
			Marshal.FreeHGlobal (native_value);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_value_init_and_copy(IntPtr dest, IntPtr src);

		public static GLib.Value InitAndCopy(GLib.Value src) {
			GLib.Value dest;
			IntPtr native_dest = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (GLib.Value)));
			IntPtr native_src = GLib.Marshaller.StructureToPtrAlloc (src);
			gst_value_init_and_copy(native_dest, native_src);
			dest = (GLib.Value) Marshal.PtrToStructure (native_dest, typeof (GLib.Value));
			Marshal.FreeHGlobal (native_dest);
			Marshal.FreeHGlobal (native_src);
			return dest;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_value_intersect(IntPtr dest, IntPtr value1, IntPtr value2);

		public static bool Intersect(out GLib.Value dest, GLib.Value value1, GLib.Value value2) {
			IntPtr native_dest = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (GLib.Value)));
			IntPtr native_value1 = GLib.Marshaller.StructureToPtrAlloc (value1);
			IntPtr native_value2 = GLib.Marshaller.StructureToPtrAlloc (value2);
			bool raw_ret = gst_value_intersect(native_dest, native_value1, native_value2);
			bool ret = raw_ret;
			dest = (GLib.Value) Marshal.PtrToStructure (native_dest, typeof (GLib.Value));
			Marshal.FreeHGlobal (native_dest);
			Marshal.FreeHGlobal (native_value1);
			Marshal.FreeHGlobal (native_value2);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_value_is_fixed(IntPtr value);

		public static bool IsFixed(GLib.Value value) {
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			bool raw_ret = gst_value_is_fixed(native_value);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_value);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_value_is_subset(IntPtr value1, IntPtr value2);

		public static bool IsSubset(GLib.Value value1, GLib.Value value2) {
			IntPtr native_value1 = GLib.Marshaller.StructureToPtrAlloc (value1);
			IntPtr native_value2 = GLib.Marshaller.StructureToPtrAlloc (value2);
			bool raw_ret = gst_value_is_subset(native_value1, native_value2);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_value1);
			Marshal.FreeHGlobal (native_value2);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_value_register(IntPtr table);

		public static void Register(Gst.ValueTable table) {
			IntPtr native_table = GLib.Marshaller.StructureToPtrAlloc (table);
			gst_value_register(native_table);
			Marshal.FreeHGlobal (native_table);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_value_serialize(IntPtr value);

		public static string Serialize(GLib.Value value) {
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			IntPtr raw_ret = gst_value_serialize(native_value);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			Marshal.FreeHGlobal (native_value);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_value_set_bitmask(IntPtr value, ulong bitmask);

		public static void SetBitmask(GLib.Value value, ulong bitmask) {
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			gst_value_set_bitmask(native_value, bitmask);
			Marshal.FreeHGlobal (native_value);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_value_set_caps(IntPtr value, IntPtr caps);

		public static void SetCaps(GLib.Value value, Gst.Caps caps) {
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			gst_value_set_caps(native_value, caps == null ? IntPtr.Zero : caps.Handle);
			Marshal.FreeHGlobal (native_value);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_value_set_caps_features(IntPtr value, IntPtr features);

		public static void SetCapsFeatures(GLib.Value value, Gst.CapsFeatures features) {
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			IntPtr native_features = GLib.Marshaller.StructureToPtrAlloc (features);
			gst_value_set_caps_features(native_value, native_features);
			Marshal.FreeHGlobal (native_value);
			Marshal.FreeHGlobal (native_features);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_value_set_double_range(IntPtr value, double start, double end);

		public static void SetDoubleRange(GLib.Value value, double start, double end) {
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			gst_value_set_double_range(native_value, start, end);
			Marshal.FreeHGlobal (native_value);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_value_set_flagset(IntPtr value, uint flags, uint mask);

		public static void SetFlagset(GLib.Value value, uint flags, uint mask) {
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			gst_value_set_flagset(native_value, flags, mask);
			Marshal.FreeHGlobal (native_value);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_value_set_fraction(IntPtr value, int numerator, int denominator);

		public static void SetFraction(GLib.Value value, int numerator, int denominator) {
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			gst_value_set_fraction(native_value, numerator, denominator);
			Marshal.FreeHGlobal (native_value);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_value_set_fraction_range(IntPtr value, IntPtr start, IntPtr end);

		public static void SetFractionRange(GLib.Value value, GLib.Value start, GLib.Value end) {
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			IntPtr native_start = GLib.Marshaller.StructureToPtrAlloc (start);
			IntPtr native_end = GLib.Marshaller.StructureToPtrAlloc (end);
			gst_value_set_fraction_range(native_value, native_start, native_end);
			Marshal.FreeHGlobal (native_value);
			Marshal.FreeHGlobal (native_start);
			Marshal.FreeHGlobal (native_end);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_value_set_fraction_range_full(IntPtr value, int numerator_start, int denominator_start, int numerator_end, int denominator_end);

		public static void SetFractionRangeFull(GLib.Value value, int numerator_start, int denominator_start, int numerator_end, int denominator_end) {
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			gst_value_set_fraction_range_full(native_value, numerator_start, denominator_start, numerator_end, denominator_end);
			Marshal.FreeHGlobal (native_value);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_value_set_int64_range(IntPtr value, long start, long end);

		public static void SetInt64Range(GLib.Value value, long start, long end) {
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			gst_value_set_int64_range(native_value, start, end);
			Marshal.FreeHGlobal (native_value);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_value_set_int64_range_step(IntPtr value, long start, long end, long step);

		public static void SetInt64RangeStep(GLib.Value value, long start, long end, long step) {
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			gst_value_set_int64_range_step(native_value, start, end, step);
			Marshal.FreeHGlobal (native_value);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_value_set_int_range(IntPtr value, int start, int end);

		public static void SetIntRange(GLib.Value value, int start, int end) {
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			gst_value_set_int_range(native_value, start, end);
			Marshal.FreeHGlobal (native_value);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_value_set_int_range_step(IntPtr value, int start, int end, int step);

		public static void SetIntRangeStep(GLib.Value value, int start, int end, int step) {
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			gst_value_set_int_range_step(native_value, start, end, step);
			Marshal.FreeHGlobal (native_value);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_value_set_structure(IntPtr value, IntPtr structure);

		public static void SetStructure(GLib.Value value, Gst.Structure structure) {
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			gst_value_set_structure(native_value, structure == null ? IntPtr.Zero : structure.Handle);
			Marshal.FreeHGlobal (native_value);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_value_subtract(IntPtr dest, IntPtr minuend, IntPtr subtrahend);

		public static bool Subtract(out GLib.Value dest, GLib.Value minuend, GLib.Value subtrahend) {
			IntPtr native_dest = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (GLib.Value)));
			IntPtr native_minuend = GLib.Marshaller.StructureToPtrAlloc (minuend);
			IntPtr native_subtrahend = GLib.Marshaller.StructureToPtrAlloc (subtrahend);
			bool raw_ret = gst_value_subtract(native_dest, native_minuend, native_subtrahend);
			bool ret = raw_ret;
			dest = (GLib.Value) Marshal.PtrToStructure (native_dest, typeof (GLib.Value));
			Marshal.FreeHGlobal (native_dest);
			Marshal.FreeHGlobal (native_minuend);
			Marshal.FreeHGlobal (native_subtrahend);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_value_union(IntPtr dest, IntPtr value1, IntPtr value2);

		public static bool Union(out GLib.Value dest, GLib.Value value1, GLib.Value value2) {
			IntPtr native_dest = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (GLib.Value)));
			IntPtr native_value1 = GLib.Marshaller.StructureToPtrAlloc (value1);
			IntPtr native_value2 = GLib.Marshaller.StructureToPtrAlloc (value2);
			bool raw_ret = gst_value_union(native_dest, native_value1, native_value2);
			bool ret = raw_ret;
			dest = (GLib.Value) Marshal.PtrToStructure (native_dest, typeof (GLib.Value));
			Marshal.FreeHGlobal (native_dest);
			Marshal.FreeHGlobal (native_value1);
			Marshal.FreeHGlobal (native_value2);
			return ret;
		}

#endregion
	}
}
