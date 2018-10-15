using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

    public GameObject title;

    void Start () {
        GameManager.main = this;
	}

    public void QuitTitle()
    {
        title.SetActive(false);
    }

}
