using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragComponent : MonoBehaviour
{
    public GameObject button;
    Vector3 adjustPoint;

    Vector3 GetMousePos()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        return mousePos;
    }

    private void OnMouseDown()
    {
        adjustPoint = transform.position-GetMousePos();
    }

    private void OnMouseDrag()
    {
        transform.position = GetMousePos()+adjustPoint;
    }
}
