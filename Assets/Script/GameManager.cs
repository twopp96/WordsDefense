using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    AudioClipAdaptor adaptor;

    private void Start()
    {
        adaptor = GetComponent<AudioClipAdaptor>();
        SoundManager.instance.Play(adaptor.clip[0]);
    }
}
