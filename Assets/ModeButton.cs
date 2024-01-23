using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeButton : MonoBehaviour
{
    public GameObject[] ahieves;
    void Start()
    {
        for(int i = 0; i < ahieves.Length; i++)
        {
            ahieves[i].SetActive(false);
        }
    }

    public void Active()
    {
        for (int i = 0;i < ahieves.Length;i++)
        {
            ahieves[i] .SetActive(true);
        }
    }

}
