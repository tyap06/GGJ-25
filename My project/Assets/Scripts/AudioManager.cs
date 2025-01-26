using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Separate music and SFX player
    [Header("---------- Audio Source ----------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("---------- Audio Clip ----------")]
    public AudioClip bubblePop;
    public AudioClip gameOver;
    public AudioClip mouseClick2;
    public AudioClip mouseClick3;
    public AudioClip mouseHover1;
    public AudioClip mouseHover2;
    public AudioClip mouseHover3;
    public AudioClip pianoDrumBass;
    public AudioClip snoring2;
    public AudioClip throw1;
    public AudioClip throw2;
    public AudioClip throwReload1;
    public AudioClip toolSwap1;

    private void Start()
    {
        // BG music play on start
        musicSource.clip = pianoDrumBass;
        musicSource.Play();
    }

    // Created method that is accessible in other scripts
    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
