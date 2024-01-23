using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class UpgradeList
{
    public string name;
    public int cost;
    public Sprite sprite;
}

public class RrinforceType : MonoBehaviour
{
    public Image[] images;
    
    public Sprite[] sprites;
    public GameObject[] field;

    public List<UpgradeList> list;

    public Dictionary<Sprite, GameObject> temp;
    void Start()
    {
        foreach (var upgrade in list)
        {
            for(int i = 0; i<images.Length; i++)
            {

            }
        }
        temp = new Dictionary<Sprite, GameObject>();
    }
}
