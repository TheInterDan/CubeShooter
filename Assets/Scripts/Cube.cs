using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

<<<<<<< HEAD

    public Vector3 direction = Vector3.back;
    public float speed = 1;

    void Update () {
        this.transform.Translate(Vector3.back * this.speed * Time.deltaTime);


    }
}
