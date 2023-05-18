using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonBarrel : MonoBehaviour
{
    private int watterCounter = 100;
    private SingletonBarrel instance;
    public MusicFacade music;

    private SingletonBarrel() { }

    public SingletonBarrel getInstance()
    {
        return instance ??= new SingletonBarrel();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("SourceOfWatter"))
        {
            if(watterCounter == 0)
            {
                Debug.Log("You have no water!");
                return;
            }
            watterCounter -= 5;
            Debug.Log($"Water in sources:  {watterCounter}");
            //music.Awake();
            music.watterCollectAudio();
        }
    }
}