using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip[] levelMusicArray;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = PlayerPrefsManager.GetMusicVolume();
        audioSource.clip = levelMusicArray[0];
        audioSource.loop = true;
        audioSource.Play();
        
    }

    
    
}
