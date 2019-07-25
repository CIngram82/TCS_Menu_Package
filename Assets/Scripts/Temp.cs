using UnityEngine;
using UnityEngine.UI;

public class Temp : MonoBehaviour
{
    public Slider volumeSlider;
    private MusicManager musicManager;

    // Use this for initialization
    void Start()
    {
        musicManager = FindObjectOfType<MusicManager>();
        volumeSlider.value = PlayerPrefsManager.GetMusicVolume();
    }

    // Update is called once per frame
    void Update()
    {
        musicManager.SetVolume(volumeSlider.value);
        // Sound effects manager set volume
    }

    public void SaveAndExit()
    {
        PlayerPrefsManager.SetMasterVolume(volumeSlider.value);
        PlayerPrefsManager.SetDifficulty(difficultySlider.value);
        levelManager.LoadLevelByName("MainMenu");
    }

    public void SetDefults()
    {
        volumeSlider.value = 0.5f;
        difficultySlider.value = 2.0f;
    }
}