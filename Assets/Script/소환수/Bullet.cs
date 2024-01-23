using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Transform target;
    public int atk;
    float range = 3f;
    bool isSlow=false;
    bool isDot = false;
    float dot = 0.2f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Attack tower))
        {
            atk = tower.atk;
            if(tower.canSlow)
                isSlow = true;
            if (tower.canDot)
                isDot = true;
            else
            {
                isSlow = false;
                isDot = false;
            }
        }
       
        if (collision.TryGetComponent(out Monster hit))
        {
            hit.HP -= atk;
            if (isSlow)  hit.GetComponent<MoveComponent>().moveSpeed -= 2.5f;
            Destroy(gameObject);
            if(isDot)
            {
               while(hit.HP!=0)
                {
                    hit.HP -= dot;
                }
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, range);
    }

    public Collider2D[] tempCollider;
    void Update()
    {
        transform.Rotate(Vector3.forward * 2f);

        Collider2D[] collider = Physics2D.OverlapCircleAll(transform.position, range, 1 << LayerMask.NameToLayer("Monster"));
        tempCollider = collider;

        if (collider.Length > 0)
        {
            transform.position = Vector2.MoveTowards(transform.position, collider[0].transform.position, 7f * Time.deltaTime);
        }
    }
}
