using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour {

    public Transform instantiator;

    void Start () {
        GameManager.playerPositions.Add(this);
    }
}