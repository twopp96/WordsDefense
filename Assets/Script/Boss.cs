using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public GameObject[] fieldDrop;
    public GameObject dropPosition;

    public void Drop()
    {
        int random = Random.Range(0, fieldDrop.Length);
        Instantiate(fieldDrop[random]);
    }
    
}
