using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FormChange : MonoBehaviour
{
    public GameObject[] obj = new GameObject[2];

    public void Change(int num)
    {
        if(num == 0)
        {
            obj[0].gameObject.SetActive(true );
            obj[num+1].gameObject.SetActive(false) ;
        }
        else if(num == 1) 
        {
            obj[num-1].gameObject.SetActive(false);
            obj[1].gameObject.SetActive(true);
        }
    }

}
