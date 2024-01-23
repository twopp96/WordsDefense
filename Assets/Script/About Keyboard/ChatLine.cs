using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChatLine : MonoBehaviour
{
    public static ChatLine instance;
    public TextMeshProUGUI chat;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else Destroy(gameObject);

        chat.text = "";
    }
    public void OutputLine()
    {
        chat.text = EnterKey.instance.inputWords.ToString();
    }

    
}
