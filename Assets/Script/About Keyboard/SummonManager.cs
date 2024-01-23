using System.Collections.Generic;
using TMPro;
using UnityEngine;

public enum Word_TypeC
{
    Q = 0, W = 1, E = 2, R = 3, T = 4,
    A = 5, S = 6, D = 7, F = 8, G = 9,
    Z = 10, X = 11, C = 12, V = 13
}

//모음 이넘
public enum Word_TypeV
{
    Y, U, I, O, P,
    H, J, K, L,
    B, N, M
}

public class SummonManager : MonoBehaviour
{
    public static SummonManager Instance;

    public bool isConsonant = true;

    public int[] alphaCount = new int[26];
    public Dictionary<int, string> alphaDic = new Dictionary<int, string>();

    [SerializeField] int gold;
    public int Gold
    {
        get { return gold; }
        set
        {
            gold = value;
            goldText.text = gold.ToString();
        }
    }
    public TextMeshProUGUI goldText;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);

        for (int i = 0; i < alphaCount.Length; i++)
        {
            alphaCount[i] = 0;
            alphaDic.Add(i, (i + 'A').ToString());
        }
        Gold = 0;
    }

    public void Summon()
    {
        if (Gold - 3 >= 0)
        {
            Gold -= 3;
            if (isConsonant)
            {
                int random = Random.Range(0, 14);
                Debug.Log("자음" + random);
                alphaCount[random]++;
            }
            else if (isConsonant == false)
            {
                int random = Random.Range(14, 27);
                Debug.Log("모음" + random);
                alphaCount[random]++;
            }
        }
    }
}
