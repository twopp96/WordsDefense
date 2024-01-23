using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using System.Linq;
using JetBrains.Annotations;

public class EnterKey : MonoBehaviour, IPointerClickHandler
{
    public static EnterKey instance;

    public GameObject[] tower;

    public Transform pos;

    public string inputWords;
    public Dictionary<string, GameObject> animals;


    public int[] saveCount;

    public void CountFeedback(int num)
    {
        saveCount[num] = SummonManager.Instance.alphaCount[num] + 1;
    }


    private void Awake()
    {
        if (instance == null)
            instance = this;
        else Destroy(gameObject);

        animals = new Dictionary<string, GameObject>();
        animals.Add("CAT", tower[0]);
        animals.Add("DOG", tower[1]);
        animals.Add("SAVANAH", tower[2]);



        saveCount = new int[14];
        for (int i = 1; i < saveCount.Length; i++)
        {
            saveCount[i] = 0;
        }
    }


    public void OnPointerClick(PointerEventData data)
    {

        if (animals.ContainsKey(inputWords))
        {
            Instantiate(animals[inputWords], pos.transform.position, Quaternion.identity);
            SaveTest.instance.FirstSummon();
      
        }
        else
        {
            for (int i = 0; i < saveCount.Length; i++)
            {
                SummonManager.Instance.alphaCount[i] = saveCount[i];
            }
        }
        inputWords = "";
        ChatLine.instance.OutputLine();
    }

}
