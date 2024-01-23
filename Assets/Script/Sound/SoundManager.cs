using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    public GameObject soundComponent;


    private void Awake()
    {
        if (instance == null)
            instance = this;
        else Destroy(gameObject);

        DontDestroyOnLoad(gameObject);

    }

    public void Play(AudioClip clip)
    {
        GameObject temp = Instantiate(soundComponent);
        temp.GetComponent<SoundComponent>().Play(clip);
    }
}
