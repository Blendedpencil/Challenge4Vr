using UnityEngine;

public class audioPlayer : MonoBehaviour
{
    
    public AudioSource myAudioSource;
    public AudioClip gameMusic;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AudioListener.pause = false;
        myAudioSource.clip = gameMusic;
        myAudioSource.loop = true;
        //myAudioSource.playOnAwake = true;
        myAudioSource.volume = 0.1f;
        myAudioSource.loop = true;
        myAudioSource.Play();   
        Debug.Log("Should be playing now");

    }

    // Update is called once per frame
    void Update()
    {
    }
}
