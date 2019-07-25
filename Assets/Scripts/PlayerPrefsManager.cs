using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPrefsManager : MonoBehaviour
{

    const string MUSIC_VOLUME_KEY = "music_volume";
    const string SFX_VOLUME_KEY = "sfx_volume";

    public static void SetMusicVolume(float volume)
    {
        if(volume >= 0.0f && volume <= 1.0f)
        {
            PlayerPrefs.SetFloat(MUSIC_VOLUME_KEY, volume);
        }
        else
        {
            Debug.LogError("Master volume out of range ( 0 to 1). volume recived: " + volume);
        }
    }
    public static float GetMusicVolume()
    {
        return PlayerPrefs.GetFloat(MUSIC_VOLUME_KEY);
    }

}