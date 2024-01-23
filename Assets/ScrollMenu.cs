using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ScrollMenu : MonoBehaviour, IPointerClickHandler
{
    public Animation ani;

    public void OnPointerClick(PointerEventData eventData)
    {
        ani.Play();
    }

    public void AnimationStop()
    {
        ani.Stop();
    }

    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animation>();
    }

   
}
