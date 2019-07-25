using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{
    public AudioClip[] levelMusicArray;
    private AudioSource audioSource;
    
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = PlayerPrefsManager.GetMusicVolume();
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode loadSceneMode)
    {
        AudioClip currentLevelMusic = levelMusicArray[scene.buildIndex];

        if (currentLevelMusic != null)
        {
            audioSource.clip = currentLevelMusic;
            audioSource.loop = true;
            audioSource.Play();
        }
    }

    public void SetVolume(float newVolume)
    {
        audioSource.volume = newVolume;
    }
}
