using System;
using System.Collections;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource bgmAudioSource;
    public AudioSource sfxAudioSource;


    void Start()
    {
        PlayBGM();

    }

    private void PlayBGM()
    {
        bgmAudioSource.Play();
    }

    public void PlaySFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(sfxAudioSource, spawnPosition, Quaternion.identity);
    }

}
