using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class SaveTest : MonoBehaviour
{
    public static SaveTest instance;

    public TextMeshProUGUI[] text;

    public string locked = "해금";

    [SerializeField]bool isFirst;
    public bool IsFirst
    {
        get { return isFirst; }
        set
        {
            isFirst = value;
            if (isFirst == false)
            {
                text[realIndex].gameObject.SetActive(false);
            }
            if (isFirst == true)
            {
                text[realIndex].gameObject.SetActive(true);
                text[explaination].transform.SetParent(text[realIndex].transform, true);
                text[hidingText].gameObject.SetActive(false);
            }
        }
    }

    int hidingText = 0;
    int explaination = 1;
    int realIndex = 2;

    public void Awake()
    {
        if(instance == null)
            instance = this;
        else Destroy(gameObject);

        if (PlayerPrefs.GetInt(locked) == 1)
        {
            Debug.Log("해금");
            IsFirst = true;
        }
        else
        {
            PlayerPrefs.SetInt(locked, 0);
            Debug.Log("저장안됨");
        }

        if (IsFirst != true) IsFirst = false;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) FirstSummon();
    }

    public void FirstSummon()
    {
        IsFirst = true;
        PlayerPrefs.SetInt(locked, 1);
    }
}
