using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicFacade : MonoBehaviour
{
    [SerializeField] AudioSource chestOpenAudioSource;
    [SerializeField] AudioSource enemyAudioSource;
    [SerializeField] AudioSource watterCollectAudioSource;
    [SerializeField] AudioSource boxOpenAudioSource;

    public void chestOpenAudio()
    {
        Debug.Log("MUSIC FOR CHEST OPENING");
        chestOpenAudioSource.Play();
    }
    public void enemyAudio()
    {
        Debug.Log("MUSIC FOR POISONED");
        enemyAudioSource.Play();
    }
    public void watterCollectAudio()
    {
        Debug.Log("MUSIC FOR WATTER COLLECT");
        watterCollectAudioSource.Play();
    }
    public void boxOpenAudio(){
        Debug.Log("MUSIC FOR BOX OPENING");
        boxOpenAudioSource.Play();
    }
}
