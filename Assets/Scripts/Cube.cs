using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Cube : MonoBehaviour {

    public Vector3 direction = Vector3.back;
    public float speed = 1;

    void Update () {
        this.transform.Translate(Vector3.back * this.speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
            SceneManager.LoadScene(0);
        }
    }
}
