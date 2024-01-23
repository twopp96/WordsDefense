using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Monster : MonoBehaviour
{
    [SerializeField] private float hp;
    public float maxHP = 100;
    public Image hpBar;

    Boss bossAdaptor;
    public MoveComponent moveComponent;


    public float HP
    {
        get { return hp; }
        set
        {
            hp = value;
            hpBar.fillAmount = hp / maxHP;
            if (hp <= 0)
            {
                hp = 0;
                hpBar.fillAmount = 0;
                SummonManager.Instance.Gold += 3;
                SpawnManager.instance.enemyCount--;
                SpawnManager.instance.countText.text = SpawnManager.instance.enemyCount.ToString() + "/80";
                if (bossAdaptor != null)
                {
                    bossAdaptor.Drop();
                }
                Destroy(gameObject);
            }
        }
    }
    private void Start()
    {
        moveComponent = GetComponent<MoveComponent>();
        HP = maxHP;
        if (TryGetComponent(out Boss adaptor))
        {
            bossAdaptor = adaptor;
        }
    }

}





