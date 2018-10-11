using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public int speed;

    Transform destino;

    void Update() {

        DetectInput();
        Move();
    }
    void DetectInput()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.transform.tag == "PlayerPosition")
                {
                    destino = hit.transform;
                }
            }
        }
    }
    void Move()
    {
        this.transform.position = Vector3.Lerp(this.transform.position, this.destino.position, this.speed * Time.deltaTime);
    }
}
