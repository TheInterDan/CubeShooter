using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

    public GameObject title;
    public GameObject gameOverTitle;

    void Start () {
        GameManager.main = this;
	}

    public void QuitTitle()
    {
        title.SetActive(false);
    }

    public void ShowGameOver()
    {
        gameOverTitle.SetActive(true);
    }
}
