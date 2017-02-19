using UnityEngine;
using System.Collections;

namespace xPrefsTools
{
	

	/// <summary>
	/// Long v.
	/// </summary>
	public struct Long_v
	{
		public float m;
		// mantissa
		public int e;
		// exponenet
	}

	public static class XPrefs
	{

		#region private

		/// <summary>
		/// value used to make long
		/// less than Maxint.
		/// </summary>
		private const long devider = 1000000000000000;

		/// <summary>
		/// Convert Long_v representation to long
		/// </summary>
		/// <returns>value as long.</returns>
		/// <param name="lvalue">struct Lvalue.</param>
		private static long LvToLong (Long_v lvalue)
		{
			if (lvalue.e == 1) {
				return (long)lvalue.m * devider;
			}
			return  (long)lvalue.m;
		}

		/// <summary>
		/// convert long  to long v.
		/// </summary>
		/// <returns>The to long v.</returns>
		/// <param name="lvalue">Lvalue.</param>
		private static Long_v LongToLongV (long lvalue)
		{
			Long_v retval;

			if (lvalue > int.MaxValue || lvalue < int.MinValue) {
				retval.m = lvalue / devider;
				retval.e = 1;
			} else {
				retval.m = (float)lvalue;
				retval.e = 0;
			}

			return retval;
		}

		/// <summary>
		/// Lvs to U long.
		/// </summary>
		/// <returns>The to U long.</returns>
		/// <param name="lvalue">Lvalue.</param>
		private static ulong LvToULong (Long_v lvalue)
		{
			if (lvalue.e == 1) {
				return (ulong)lvalue.m * devider;
			}
			return  (ulong)lvalue.m;
		}

		/// <summary>
		/// Longs to long v.
		/// </summary>
		/// <returns>The to long v.</returns>
		/// <param name="lvalue">Lvalue.</param>
		private static Long_v LongToLongV (ulong lvalue)
		{
			Long_v retval;

			if (lvalue > uint.MaxValue) {
				retval.m = lvalue / devider;
				retval.e = 1;
			} else {
				retval.m = (float)lvalue;
				retval.e = 0;
			}

			return retval;
		}

		/// <summary>
		/// Saves the float array in csv like format.
		/// </summary>
		/// <param name="key">Key.</param>
		/// <param name="array">Array.</param>
		private static void SaveFloatArray (string key, float[] array)
		{
			string array_str = string.Empty;
			// try to convert array to simple csv format
			for (int i = 0; i <= array.Length; i++) {
				array_str += "," + i.ToString ();
			}

			SetString (key, array_str);
		}

		/// <summary>
		/// Getfloat array from prefs
		/// return it as float array.
		/// </summary>
		/// <returns>The array.</returns>
		/// <param name="key">Key.</param>
		private static float [] GetfloatArray (string key)
		{
			string[] array_str = GetString (key).Split (',');
			float[] ret = new float[array_str.Length];
			for (int i = 0; i <= array_str.Length; i++) {
				ret [i] = float.Parse (array_str [i]);
			}

			return ret;

		}

		/// <summary>
		/// Save int array
		/// </summary>
		/// <param name="key">Key.</param>
		/// <param name="array">Array.</param>
		private static void SaveIntArray (string key, int[] array)
		{
			string array_str = string.Empty;
			// try to convert array to simple csv format
			for (int i = 0; i <= array.Length; i++) {
				array_str += "," + i.ToString ();
			}

			SetString (key, array_str);
		}

		/// <summary>
		/// Get int array
		/// </summary>
		/// <returns>The int array.</returns>
		/// <param name="key">Key.</param>
		private static int [] GetIntArray (string key)
		{
			string[] array_str = GetString (key).Split (',');
			int[] ret = new int[array_str.Length];
			for (int i = 0; i <= array_str.Length; i++) {
				ret [i] = int.Parse (array_str [i]);

			}

			return ret;

		}

		/// <summary>
		/// Save long array
		/// </summary>
		/// <param name="key">Key.</param>
		/// <param name="array">Array.</param>
		private static void SaveLongArray (string key, long[] array)
		{
			string array_str = string.Empty;
			// try to convert array to simple csv format
			for (int i = 0; i <= array.Length; i++) {
				array_str += "," + i.ToString ();
			}

			SetString (key, array_str);
		}

		/// <summary>
		/// Get long array
		/// </summary>
		/// <returns>The array.</returns>
		/// <param name="key">Key.</param>
		private static long [] GetlongArray (string key)
		{
			string[] array_str = GetString (key).Split (',');
			long[] ret = new long[array_str.Length];
			for (int i = 0; i <= array_str.Length; i++) {
				ret [i] = long.Parse (array_str [i]);
			}

			return ret;

		}


		#endregion

		#region public methods

		/// <summary>
		/// Save int value to PlayerPrefs
		/// </summary>
		/// <param name="key">Key.</param>
		/// <param name="value">Value to save.</param>
		public static void SetInt (string key, int value)
		{
			PlayerPrefsWrapper.SetInt (key, value);
		}

		/// <summary>
		/// Get int value from PlayerPrefs
		/// </summary>
		/// <returns>The int.</returns>
		/// <param name="key">Key.</param>
		public static int GetInt (string key)
		{
			return PlayerPrefsWrapper.GetInt (key);

		}

		/// <summary>
		/// Save Float value to PlayerPrefs
		/// </summary>
		/// <param name="key">Key.</param>
		/// <param name="value">Value.</param>
		public static void SetFloat (string key, float value)
		{
			PlayerPrefsWrapper.SetFloat (key, value);
		}

		/// <summary>
		/// Get Float value from PlayerPrefs
		/// </summary>
		/// <returns>The float.</returns>
		/// <param name="key">Key.</param>
		public static float GetFloat (string key)
		{
			return PlayerPrefsWrapper.GetFloat (key);

		}

		/// <summary>
		/// Save String value To PlayerPrefs
		/// </summary>
		/// <param name="key">Key.</param>
		/// <param name="value">Value.</param>
		public static void SetString (string key, string value)
		{
			PlayerPrefsWrapper.SetString (key, value);
		}

		/// <summary>
		/// Get string Value From PlayerPrefs
		/// </summary>
		/// <returns>The string.</returns>
		/// <param name="key">Key.</param>
		public static string GetString (string key)
		{
			return PlayerPrefsWrapper.GetString (key);

		}

		/// <summary>
		/// Save Change to PlayerPrefs
		/// </summary>
		public static void SavePrefs ()
		{
			PlayerPrefsWrapper.SavePrefs ();
		}

		/// <summary>
		/// Determines if has key the specified key.
		/// </summary>
		/// <returns><c>true</c> if has key the specified key; otherwise, <c>false</c>.</returns>
		/// <param name="key">Key.</param>
		public static bool HasKey (string key)
		{
			return PlayerPrefsWrapper.HasKey (key);
		}


		/// <summary>
		/// Delete the specified key.
		/// </summary>
		/// <param name="key">Key.</param>
		public static void Delete (string key)
		{
			PlayerPrefsWrapper.Delete (key);
		}

		/// <summary>
		/// Deletes all Prefs.
		/// </summary>
		public static void DeleteAll ()
		{
			PlayerPrefsWrapper.DeletePrefs ();
		}

		/// <summary>
		/// Set Long value to prefs
		/// </summary>
		/// <param name="key">Key.</param>
		/// <param name="value">Value.</param>
		public static void SetLong (string key, long value)
		{
			Long_v lv = LongToLongV (value);
			string m_key = "__m__" + key;
			string e_key = "__e__" + key;

			SetFloat (m_key, lv.m);
			SetInt (e_key, lv.e);
		}

		/// <summary>
		/// Get Long Value From PlayerPrefs
		/// </summary>
		/// <returns>The long.</returns>
		/// <param name="key">Key.</param>
		public static long GetLong (string key)
		{
			Long_v lv;
			lv.m = GetFloat ("__m__" + key);
			lv.e = GetInt ("__e__" + key);
			return LvToLong (lv);
		}

		/// <summary>
		/// Sets the U long.
		/// </summary>
		/// <param name="key">Key.</param>
		/// <param name="value">Value.</param>
		public static void SetULong (string key, ulong value)
		{
			Long_v lv = LongToLongV (value);
			string m_key = "__m__" + key;
			string e_key = "__e__" + key;

			SetFloat (m_key, lv.m);
			SetInt (e_key, lv.e);
		}

		public static ulong GetULong (string key)
		{
			Long_v lv;
			lv.m = GetFloat ("__m__" + key);
			lv.e = GetInt ("__e__" + key);
			return LvToULong (lv);
		}

		/// <summary>
		/// Save Vector2 value to PlayerPrefs
		/// </summary>
		/// <param name="key">Key.</param>
		/// <param name="value">Value.</param>
		public static void SetVector2 (string key, Vector2 value)
		{
			SaveFloatArray (key, new float[2] { value.x, value.y });
		}

		/// <summary>
		/// Get Vector2 From PlayerPrefs
		/// </summary>
		/// <returns>The vector2.</returns>
		/// <param name="key">Key.</param>
		public static Vector2 GetVector2 (string key)
		{
			float[] vf = GetfloatArray (key);

			if (vf.Length > 2) {
				throw new UnityException ("Fatal Error occured when getting vector2 with key " + key);
			}

			return new Vector2 (vf [0], vf [1]);
		}

		/// <summary>
		/// Save Vector3 value to PlayerPrefs
		/// </summary>
		/// <param name="key">Key.</param>
		/// <param name="value">Value.</param>
		public static void SetVector3 (string key, Vector3 value)
		{
			SaveFloatArray (key, new float[3]{ value.x, value.y, value.z });
		}

		/// <summary>
		/// Gets the vector3.
		/// </summary>
		/// <returns>The vector3.</returns>
		/// <param name="key">Key.</param>
		public static Vector3 GetVector3 (string key)
		{
			float[] vf = GetfloatArray (key);

			if (vf.Length > 3) {
				throw new UnityException ("Fatal Error occured when getting vector3 with key " + key);
			}

			return new Vector3 (vf [0], vf [1], vf [2]);
		}

		/// <summary>
		/// Save Vector4 value to PlayerPrefs
		/// </summary>
		/// <param name="key">Key.</param>
		/// <param name="value">Value.</param>
		public static void SetVector4 (string key, Vector4 value)
		{
			SaveFloatArray (key, new float[4]{ value.x, value.y, value.z, value.w });
		}

		public static Vector4 GetVector4 (string key)
		{
			float[] vf = GetfloatArray (key);

			if (vf.Length > 4) {
				throw new UnityException ("Fatal Error occured when getting vector4 with key " + key);
			}

			return new Vector4 (vf [0], vf [1], vf [2], vf [3]);
		}

		/// <summary>
		/// Save Quaternion value to PlayerPrefs
		/// </summary>
		/// <param name="key">Key.</param>
		/// <param name="value">Value.</param>
		public static void SetQuaternion (string key, Quaternion value)
		{
			SaveFloatArray (key, new float[4]{ value.x, value.y, value.z, value.w });
		}

		/// <summary>
		/// Gets the quaternion.
		/// </summary>
		/// <returns>The quaternion.</returns>
		/// <param name="key">Key.</param>
		public static Quaternion GetQuaternion (string key)
		{
			float[] vf = GetfloatArray (key);

			if (vf.Length > 4) {
				throw new UnityException ("Fatal Error occured when getting vector4 with key " + key);
			}

			return new Quaternion (vf [0], vf [1], vf [2], vf [3]);
		}

		/// <summary>
		/// Save bool value to playerPrefs
		/// </summary>
		/// <param name="key">Key.</param>
		/// <param name="value">If set to <c>true</c> value.</param>
		private static void SetBool (string key, bool value)
		{
			SetInt (key, value ? 0 : 1);
		}

		/// <summary>
		/// Get bool value from PlayerPrefs
		/// </summary>
		/// <returns><c>true</c>, if bool was gotten, <c>false</c> otherwise.</returns>
		/// <param name="key">Key.</param>
		private static bool GetBool (string key)
		{
			return (GetInt (key) != 0);
		}

		#endregion
	}
}