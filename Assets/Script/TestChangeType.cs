using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[System.Serializable]
public class AnimalIndex
{
    public string grade;
    public string[] name;
    public int cost;
    public int maxCount;



    //커먼      36    cost: 3
    //언커먼   24   cost: 5
    //레어        12  cost: 7 
    //유니크     8   cost: 10
    //에픽        6    cost: 15
    //레전더리 --- 육(코끼리), 해(고래), 공(넓적부리황새) cost:20

    //레전더리 3: 흰수염고래(Sea), 아프리카 코끼리(Savanah), 넓적부리 황새(Savanah)

    //에픽 6:  기린(savanah), 하마(savanah), 코뿔소(savanah), 북극곰(Galacier) , 검독수리(Mountain)



    //유니크 8: 수리부엉이(Mountain), 사자(Savanah), 

}

public class TestChangeType : MonoBehaviour //, IPointerClickHandler
{
    int grade;

    int maxCommon=36;
    int maxUncommon;
    int maxRare;
    int maxUnique;
    int maxEpic;
    int maxLegendary;

    public Image[] images;

    public Animals[] ani;
    public Dictionary<Sprite, Animals> animalsInterface;

    public Sprite[] animalsSprite;
    public GameObject[] tower;

    public Dictionary<Sprite, GameObject> animals;

    public TextMeshProUGUI[] textMeshProUGUI1;

    public AudioClipAdaptor audioClipAdaptor;

    public List<AnimalIndex> rairity;
    List<Animals> animalPool = new List<Animals>();
    //Dictionary<string, Animals> animalDic = new Dictionary<string, Animals>();

    public void ReRoll()
    {
        int proportion = Random.Range(0, 100);
        if (SummonManager.Instance.Gold - 3 >= 0)
        {
            SummonManager.Instance.Gold -= 3;
            SoundManager.instance.Play(audioClipAdaptor.clip[0]);

            if (grade == 0)
            {
                for (int i = 0; i < images.Length; i++)
                {
                    int random = Random.Range(0, 7);
                    images[i].sprite = animalsSprite[random];

                    foreach (KeyValuePair<Sprite, Animals> pair in animalsInterface)
                    {
                        if (images[i].sprite == pair.Key)
                        {
                            textMeshProUGUI1[i].text = "Name: " + pair.Value.NameRairity +
                            "Cost: " + pair.Value.Cost ;
                        }
                    }
                }
            }
        }
        else
        {
            SoundManager.instance.Play(audioClipAdaptor.clip[1]);
            Debug.Log("니드머니!");
        }
    }

    public void Summon_Slot(int value)
    {
        foreach (KeyValuePair<Sprite, GameObject> fortSummon in animals)
        {
            if (images[value].sprite == fortSummon.Key)
            {
                foreach (KeyValuePair<Sprite, Animals> forCost in animalsInterface)
                {
                    if (fortSummon.Key == forCost.Key && SummonManager.Instance.Gold >= forCost.Value.Cost)
                    {
                        SummonManager.Instance.Gold -= forCost.Value.Cost;
                        Instantiate(fortSummon.Value);
                    }
                }
            }
        }
    }

    void Start()
    {
        foreach (var rare in rairity)
        {
            for (int i = 0; i < rare.maxCount; i++)
            {
                animalPool.Add(new Animals(rare.cost, rare.name[i] +"("+ rare.grade+")"));
                
                /*
                //이거는 맞음
                Debug.Log(i + "번째 Cost는" + animalPool[i].Cost);
                //이거는 등급별 N개가  입력되는 동안 각각 다른 이름들이 들어가야 함
                Debug.Log(animalPool[i].NameRairity);

                //이거는 그 등급별 N개가 입력되는 동안 각각 종이 들어가야 함
                //Debug.Log(animalPool[i].Species);
                Debug.Log("=========");
                */
            }
        }

        grade = 0;
        audioClipAdaptor = GetComponent<AudioClipAdaptor>();

        animalsInterface = new Dictionary<Sprite, Animals>();
        animals = new Dictionary<Sprite, GameObject>();

        //커먼      36    cost: 3
        //언커먼   24   cost: 5
        //레어        12  cost: 7 
        //유니크     8   cost: 10
        //에픽        6    cost: 15
        //레전더리 --- 육(코끼리), 해(고래), 공(넓적부리황새) cost:20

        //동물들의 총 풀이 있음. 

        //동물들은 종류 (ex 고양이, 코끼리 고래..)
        //각 동물종류들은 등급이 있음 (커먼 언커먼...)
        //커먼은 더 많이 리스트에 들어감
        //즉, 등급이 낮을수록 풀에 더 많이들어가고, 등급이 높을수록 풀에 적게들어감

        
        ani = new Animals[animalsSprite.Length];
        ani[animalsSprite.Length - 7] = new Animals(3, "cat(Common)");
       /*
        ani[animalsSprite.Length - 69] = new Animals(3, "dog(Common)", "dog");
        ani[animalsSprite.Length - 68] = new Animals(3, "mouse(Common)", "mouse");
        ani[animalsSprite.Length - 67] = new Animals(3, "rabit(Common)", "rabit");
        ani[animalsSprite.Length - 66] = new Animals(3, "monkey(Common)", "monkey");
        ani[animalsSprite.Length - 63] = new Animals(3, "cow(Common)", "cow");
        ani[animalsSprite.Length - 64] = new Animals(3, "horse(Common)", "horse");
        ani[animalsSprite.Length - 63] = new Animals(3, "cat(Common)", "cat");
        ani[animalsSprite.Length - 62] = new Animals(3, "cat(Common)", "cat");
        ani[animalsSprite.Length - 61] = new Animals(3, "cat(Common)", "cat");
        ani[animalsSprite.Length - 60] = new Animals(3, "cat(Common)", "cat");
        ani[animalsSprite.Length - 60] = new Animals(3, "cat(Common)", "cat");
        ani[animalsSprite.Length - 39] = new Animals(3, "cat(Common)", "cat");
        ani[animalsSprite.Length - 38] = new Animals(3, "cat(Common)", "cat");
        ani[animalsSprite.Length - 37] = new Animals(3, "cat(Common)", "cat");
        ani[animalsSprite.Length - 36] = new Animals(3, "cat(Common)", "cat");
        ani[animalsSprite.Length - 33] = new Animals(3, "cat(Common)", "cat");
        ani[animalsSprite.Length - 34] = new Animals(3, "cat(Common)", "cat");
        ani[animalsSprite.Length - 33] = new Animals(3, "cat(Common)", "cat");
        ani[animalsSprite.Length - 33] = new Animals(3, "cat(Common)", "cat");
        ani[animalsSprite.Length - 32] = new Animals(3, "cat(Common)", "cat");
        ani[animalsSprite.Length - 31] = new Animals(5, "cat(Common)", "cat");
       */
        ani[animalsSprite.Length - 6] = new Animals(10, "Cheeta(Rare)");
        ani[animalsSprite.Length - 5] = new Animals(10, "Tiger(Rare)");
        ani[animalsSprite.Length - 4] = new Animals(5, "Dog(Common)");
        ani[animalsSprite.Length - 3] = new Animals(10, "Wolf(Rare)");
        ani[animalsSprite.Length - 2] = new Animals(7, "DesertFox(Uncommon)");
        ani[animalsSprite.Length - 1] = new Animals(8, "Hyena(Uncommon)");
        
        
        for (int i = 0; i < animalsSprite.Length; i++)
        {
            Debug.Log(animalPool[i].NameRairity);

            animalsInterface.Add(animalsSprite[i], ani[i]);
            animals.Add(animalsSprite[i], tower[i]);
        }
        
        for (int i = 0; i < images.Length; i++)
        {
            images[i].sprite = animalsSprite[i];

            foreach (KeyValuePair<Sprite, Animals> pair in animalsInterface)
            {
                if (images[i].sprite == pair.Key)
                {
                    textMeshProUGUI1[i].text = "Name: " + pair.Value.NameRairity +
                    "Cost: " + pair.Value.Cost;
                }
            }
        }
    }
}


