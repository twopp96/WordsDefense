using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    AudioClipAdaptor adaptor;

    // Start is called before the first frame update
    void Start()
    {
        adaptor = GetComponent<AudioClipAdaptor>();
        SoundManager.instance.Play(adaptor.clip[0]);
    }

}
