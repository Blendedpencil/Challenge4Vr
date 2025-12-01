using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource myAudioSource;
    public AudioClip summonRocksRoar;
    public AudioClip attackRoar;
    public AudioClip fireAttackRoar;
    public AudioClip hitSound;
    public AudioClip blockSound;
    public AudioClip teleportSound;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void summonRocksRoarFunc()
    {
        myAudioSource.Stop();
        myAudioSource = GetComponent<AudioSource>();
        myAudioSource.playOnAwake = false;
        myAudioSource.volume = 0.5f;
        myAudioSource.PlayOneShot(summonRocksRoar, 0.3f);
    }
    public void attackRoarFunc()
    {
        myAudioSource.Stop();
        myAudioSource = GetComponent<AudioSource>();
        myAudioSource.playOnAwake = false;
        myAudioSource.volume = 0.5f;
        myAudioSource.PlayOneShot(attackRoar, 0.3f);
    }
    public void fireAttackRoarFunc()
    {
        myAudioSource.Stop();
        myAudioSource = GetComponent<AudioSource>();
        myAudioSource.playOnAwake = false;
        myAudioSource.volume = 0.5f;
        myAudioSource.PlayOneShot(fireAttackRoar, 0.3f);
    }

    public void attackBlocked()
    {
        myAudioSource.Stop();
        myAudioSource = GetComponent<AudioSource>();
        myAudioSource.playOnAwake = false;
        myAudioSource.volume = 0.5f;
        myAudioSource.PlayOneShot(blockSound, 0.4f);
    }

    public void attackHit()
    {
        myAudioSource.Stop();
        myAudioSource = GetComponent<AudioSource>();
        myAudioSource.playOnAwake = false;
        myAudioSource.volume = 0.5f;
        myAudioSource.PlayOneShot(hitSound, 0.4f);
    }

    public void teleportAudio()
    {
        myAudioSource.Stop();
        myAudioSource = GetComponent<AudioSource>();
        myAudioSource.playOnAwake = false;
        myAudioSource.volume = 0.5f;
        myAudioSource.PlayOneShot(teleportSound, 0.5f);
    }

}
