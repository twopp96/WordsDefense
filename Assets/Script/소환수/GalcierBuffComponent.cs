using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GalcierBuffComponent : BuffController
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Galcier component))
        {
            atkPlus.atk += 10;
            //obj.gameObject.SetActive(true);
            atkPlus.canSlow = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Galcier component))
        {
            atkPlus.atk -= 10;
            //obj.gameObject.SetActive(false);
            atkPlus.canSlow = false;
            
        }
    }
}
