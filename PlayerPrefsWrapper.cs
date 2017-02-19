using UnityEngine;
using System.Collections;


/// <summary>
/// Player prefs wrapper.
/// Simple Wrapper to PlayerPrefs
/// Fonctionality
/// </summary>
public static  class PlayerPrefsWrapper  {

	public static void SetInt(string key , int value){
		if(PlayerPrefs.HasKey(key))
			throw new UnityException("PlayerPrefs Already Has Key with name : " + key);
	    else
			PlayerPrefs.SetInt (key, value);
	}

	public static int GetInt(string key){
		if (!PlayerPrefs.HasKey (key))
			throw new UnityException ("PlayerPrefs Do Not Has Key with name : " + key);
		else
			return PlayerPrefs.GetInt (key);

	}

	public static void SetFloat(string key , float value){
		if(PlayerPrefs.HasKey(key))
			throw new UnityException("PlayerPrefs Already Has Key with name : " + key);
		else
			PlayerPrefs.SetFloat (key, value);
	}

	public static float GetFloat(string key){
		if (!PlayerPrefs.HasKey (key))
			throw new UnityException ("PlayerPrefs Do Not Has Key with name : " + key);
		else
			return PlayerPrefs.GetFloat (key);
	
	}

	public static void SetString(string key , string value){
		if(PlayerPrefs.HasKey(key))
			throw new UnityException("PlayerPrefs Already Has Key with name : " + key);
		else
			PlayerPrefs.SetString (key, value);
	}

	public static string GetString(string key){
		if (!PlayerPrefs.HasKey (key))
			throw new UnityException ("PlayerPrefs Do Not Has Key with name : " + key);
		else
			return PlayerPrefs.GetString (key);

	}

	public static void SavePrefs(){
		PlayerPrefs.Save ();
	}

	public static bool HasKey(string key){
		return PlayerPrefs.HasKey (key);
	}

	public static void Delete( string key){
		if (!PlayerPrefs.HasKey (key))
			throw new UnityException ("PlayerPrefs Do Not Has Key with name : " + key);
		else
			PlayerPrefs.DeleteKey (key);
	}

	public static void DeletePrefs(){
		PlayerPrefs.DeleteAll ();
	}
}
