using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveComponent : MonoBehaviour
{
    int startPoint;
    public float moveSpeed = 5f;


    private void Start()
    {
        startPoint = 9;
    }

    void Update()
    {
        if (SpawnManager.instance.enemyCount > 100) return;
        transform.position = Vector2.MoveTowards(transform.position, SpawnManager.instance.pos[startPoint].transform.position, moveSpeed * Time.deltaTime);
        
       if (transform.position == SpawnManager.instance.pos[startPoint].transform.position) startPoint--;

        if (startPoint < 0) startPoint = 9;
    }
}
