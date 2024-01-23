using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TestDisplay : MonoBehaviour, IPointerClickHandler
    { 

    public void OnPointerClick(PointerEventData eventData)
    {
        IndexControl.Instance.canvas.targetDisplay -=1;
    }

}
