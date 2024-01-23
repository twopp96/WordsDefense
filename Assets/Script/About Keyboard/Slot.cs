using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour, IPointerClickHandler
{
    public Image image;
    public TextMeshProUGUI textCount;
    public int index;
    private int check = 1;

    private void Start()
    {
        image = gameObject.GetComponent<Image>();
        image.color = Color.gray;
        textCount.text = SummonManager.Instance.alphaCount[index].ToString();
    }

    public void Countdown()
    {
        if (SummonManager.Instance.alphaCount[index] > 0) image.color = Color.white;
        textCount.text = SummonManager.Instance.alphaCount[index].ToString();
    }



    public void OnPointerClick(PointerEventData eventData)
    {
     
        if (SummonManager.Instance.alphaCount[index] - check >= 0)
        {
            SummonManager.Instance.alphaCount[index]--;
            Countdown();
            EnterKey.instance.inputWords += SummonManager.Instance.alphaDic[index];
            EnterKey.instance.CountFeedback(index);
            ChatLine.instance.OutputLine();
        }

        if (SummonManager.Instance.alphaCount[index] == 0)
        {
            image.color = Color.gray;
        }
    }

}

