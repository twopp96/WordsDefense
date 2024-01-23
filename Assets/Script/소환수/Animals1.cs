using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEvolveable
{

}


public class EvolvePattern
{

}

public class BuffPattern
{

}

public class StateMachine
{
    public void Act()
    {
        Debug.Log("°ø°ÝÁß");
    }
}



public class Animals1 : MonoBehaviour
{
    StateMachine machine;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        machine.Act();
    }
}
