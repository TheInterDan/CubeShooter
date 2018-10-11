using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntuacion : MonoBehaviour {

    public Text textoContador;

    private void Start()
    {
        GameManager.puntuacion = this;
    }

    public void UpdateScore(int points)
    {
        textoContador.text ="Puntuación: " + points.ToString();

    }

    /*void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "contador")
        {
            score =score + 1;
            textoContador.text = score.ToString();
        }
    }*/
}
