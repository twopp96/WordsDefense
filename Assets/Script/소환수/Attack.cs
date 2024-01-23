using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;



public class Attack : MonoBehaviour
{
    public int atk;
    public float atkSpeed = 2.5f;
    public bool isSwitch;
    public bool canSlow;
    public bool canDot;
    public AudioClip popSound;

    public GameObject attackObject;

    public void Start()
    {
        isSwitch = false;
        StartCoroutine(AttackSearch());
    }
    IEnumerator AttackSearch()
    {
        while (true)
        {
            Collider2D collider = Physics2D.OverlapCircle(transform.position, 3f, 1 << LayerMask.NameToLayer("Monster"));
            if (collider == null)
            {
                isSwitch = false;
            }
            else if (collider.TryGetComponent(out Monster monster))
            {
                //GameObject temp = 
                Instantiate(attackObject, transform.position, transform.rotation);
                SoundManager.instance.Play(popSound);
                //temp.transform.position = Vector3.MoveTowards(transform.position, collider.gameObject.transform.position, 4f*Time.deltaTime);
            }
            yield return new WaitForSeconds(atkSpeed);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, 3f);
    }

}
