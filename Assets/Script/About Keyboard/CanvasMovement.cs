using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasMovement : MonoBehaviour
{
    public Transform start;
    public Transform end;

    private float time;

    private void Start()
    {
        gameObject.transform.position = start.position;
    }

    public  void Open()
    {
        gameObject.transform.position = Vector3.Lerp(start.position, end.position, 1f);
    }

    public void Close()
    {
        gameObject.transform.position = start.position;
    }

    private void Update()
    {
        time = Time.deltaTime;
    }
}
