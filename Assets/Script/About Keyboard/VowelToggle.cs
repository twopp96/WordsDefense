using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class VowelToggle : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.pointerClick.transform.TryGetComponent(out VowelToggle temp))
        {
            if (SummonManager.Instance.isConsonant == true)
                SummonManager.Instance.isConsonant = false;
            else SummonManager.Instance.isConsonant = false;
        }

    }
}
