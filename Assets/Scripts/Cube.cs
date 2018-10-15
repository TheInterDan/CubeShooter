using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Cube : MonoBehaviour {
    
    public Vector3 direction = Vector3.back;
    public float speed = 1;
    public float speedMultiplier = 0.2f;

    private void Start()
    {
        Random.ColorHSV();
        speed = this.speed + speedMultiplier * GameManager.Score;
    }

    void Update () {
        this.transform.Translate(Vector3.back * this.speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
            GameManager.EndGame();
        }
    }
}
