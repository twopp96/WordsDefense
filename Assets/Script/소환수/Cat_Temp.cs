using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cat_Temp : MonoBehaviour
{
    
    //��ȯ�� ����������, ��ŸƮ �Լ��� �����߾��ٸ�, ����������
    //IndexOutOfRangeException: Index was outside the bounds of the array.
    //Cat_Temp.Start() (at Assets/Script/��ȯ��/Cat_Temp.cs:13)
    void Awake()
    {
        //Cost = 5;
        //NameRairity = "cat(Uncommon)";
        //Species = "cat";
        //rev[1].gameObject.SetActive(false);
    }

   

    private void OnTriggerStay2D(Collider2D collision)
    {

        if(collision.TryGetComponent(out RevComponent revolution))
        {
            if(Physics2D.OverlapCircle(transform.position, 1f, 1<<LayerMask.NameToLayer("Savanah")))
            {
                Destroy(revolution.gameObject);
                //rev[0].gameObject.SetActive(false);
               //rev[1].gameObject.SetActive(true);
            }
        }
    }


}
