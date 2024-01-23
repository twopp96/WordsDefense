using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBuffable
{
    public void interaction() { }
}

public class Buff : MonoBehaviour
{
    protected float addAtk;
    public float AddAtk{ get=> addAtk;}
    protected float addAtkSpeed;
    public float AddAtkSpeed { get => addAtkSpeed; }
    public enum BuffSelect
    {
        DESERT,
        GLACIER,
        JUNGLE,
        MOUNTAIN,
        SAVANAH,
        SEA,
    }

    public BuffSelect Select;
    public Dictionary<BuffSelect, Buff> buffDic;

    void Awake()
    {
        buffDic = new Dictionary<BuffSelect, Buff>();
        buffDic.Add(BuffSelect.DESERT, new DesertBuff());
        buffDic.Add(BuffSelect.GLACIER, new GalcierBuff());
        buffDic.Add(BuffSelect.JUNGLE, new JungleBuff());
        buffDic.Add(BuffSelect.MOUNTAIN, new MountainBuff());
        buffDic.Add(BuffSelect.SAVANAH, new SavanahBuff());
        buffDic.Add(BuffSelect.SEA, new SeaBuff());
    }

  
}

public class SavanahBuff: Buff
{
    private void Start()
    {
        
    }
}

public class MountainBuff: Buff { }
public class SeaBuff : Buff { }
public class JungleBuff: Buff { }
public class DesertBuff: Buff { }
public class GalcierBuff: Buff { }

