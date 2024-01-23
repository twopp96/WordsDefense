using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesertBuffComponent : BuffController
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Desert component))
        {
            atkPlus.atk += 3;
            //obj.gameObject.SetActive(true);
            atkPlus.canDot=true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Desert component))
        {
            atkPlus.atk -= 3;
            //obj.gameObject.SetActive(false);
            atkPlus.canDot = false;

        }
    }
}
