using UnityEngine;

public class Music : MonoBehaviour
{
    //private AudioSource audio;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //void Start()
    // {
    //  audio = GetComponent<AudioSource>();
    // audio.Play();
    // DontDestroyOnLoad(audio);
    //}
    public static Music Instance { get; private set; }

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}