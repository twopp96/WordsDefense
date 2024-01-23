using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ConsonantToggle : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.pointerClick.transform.TryGetComponent(out ConsonantToggle temp))
        {
            if (SummonManager.Instance.isConsonant == false)
                SummonManager.Instance.isConsonant = true;
            else SummonManager.Instance.isConsonant = true;
        }

    }
}
