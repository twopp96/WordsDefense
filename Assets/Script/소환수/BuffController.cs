using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffController : MonoBehaviour
{
    public Attack atkPlus;
    public GameObject obj;
    protected void Start()
    {
        atkPlus = GetComponent<Attack>();
    }
}
