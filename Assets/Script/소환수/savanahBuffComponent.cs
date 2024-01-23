using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class savanahBuffComponent : BuffController
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out savanah component))
        {
            atkPlus.atk += 10;
            //obj.gameObject.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out savanah component))
        {
            atkPlus.atk -= 10;
            //obj.gameObject.SetActive(false);
        }
    }

}
