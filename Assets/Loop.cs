using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
    Animation ani;

    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animation>();
        ani.Play();

    }

    // Update is called once per frame
    void Update()
    {
        if(ani.isPlaying==false) ani.Play();
    }
}
