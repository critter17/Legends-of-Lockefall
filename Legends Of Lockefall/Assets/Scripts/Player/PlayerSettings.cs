using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerSettings {
    public static int InputDevice
    {
        get {
            return PlayerPrefs.GetInt("InputDevice");
        }

        set {
            PlayerPrefs.SetInt("InputDevice", value);
        }
    }

    public static float MusicVolume
    {
        get {
            return PlayerPrefs.GetFloat("MusicVolume");
        }

        set {
            PlayerPrefs.SetFloat("MusicVolume", value);
        }
    }

    public static float SFXVolume
    {
        get {
            return PlayerPrefs.GetFloat("SFXVolume");
        }

        set {
            PlayerPrefs.SetFloat("SFXVolume", value);
        }
    }
}
