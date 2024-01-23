using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animals
{
    public GameObject[] rev;
    
    public Animals(int cost, string nameRairity)
    {
        Cost=cost;
        NameRairity=nameRairity;
        //Species=species;
    }

    int cost;
    public int Cost
    {
        get { return cost; }
        set { cost = value; }
    }
    string nameRairity;  //  ex] ¿Ã∏ß(Rare)
    public string NameRairity
    {
        get { return nameRairity; }
        set { nameRairity = value; }
    }
    string species;
    public string Species
    {
        get { return species; }
        set { species = value; }
    }
}
