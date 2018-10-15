using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFunctions : MonoBehaviour
{
    public void AutoPlay()
    {
        GameManager.StartGame(true);
    }

    public void StartGame()
    {
        GameManager.StartGame();
    }

    public void Restart()
    {
        GameManager.Restart();
    }
}
