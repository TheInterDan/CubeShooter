using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour {

    private int iD = 0;
    public int ID
    {
        get
        {
            return iD;
        }

        set
        {
            //iD = value;
        }
    }

    void Start () {
        iD = GameManager.GetID();
    }
}