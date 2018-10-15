﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public int speed;

    Transform destino;

    GameObject initialText;

    private void Start()
    {
        destino = transform;
        GameManager.player = this;
    }

    void Update() {
        DetectInput();
        Move();
    }

    void DetectInput()
    {
        if (!GameManager.auto && Input.GetButtonDown("Fire1"))
        {
            if (GameManager.gameStarted)
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
            else
            {
                GameManager.StartGame();
                Destroy(initialText);
            }
        }
    }

    public void NewTarget(Transform newTarget)
    {
        destino = newTarget;
    }

    void Move()
    {
        this.transform.position = Vector3.Lerp(transform.position, destino.position, speed * Time.deltaTime);
    }
}
