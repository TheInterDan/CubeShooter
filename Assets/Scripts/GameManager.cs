using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class GameManager {

    public static Puntuacion puntuacion;
    static int score;

    public static CubeManager cubeManager;
    public static List<PlayerPosition> playerPositions = new List<PlayerPosition>();

    public static bool gameStarted = false;

    public static int Score
    {
        get
        {
            return score;
        }

        set
        {
           
        }
    }

    public static int AddScore(int add = 1)
    {
        score += add;
        if (puntuacion) puntuacion.UpdateScore(score);
        return score;
    }

    /*static int id = 0;

    public static int GetID()
    {
        return id++;
    }*/

    public static void DestroyCube(GameObject cube)
    {
        cubeManager.DestroyCube(cube);
        CubeDestroyed();
    }

    public static void CubeDestroyed()
    {
        if (!cubeManager.AreStillCubes())
        {
            if(gameStarted) AddScore();

            List<Transform> positions = new List<Transform>();

            int randIndex = Random.Range(0, playerPositions.Count);
            for (int i = 0; i < playerPositions.Count; i++)
            {
                if (i != randIndex)
                {
                    positions.Add(playerPositions[i].instantiator);
                }
            }
                  
            cubeManager.SpawnCubes(positions);
        }
    }

    public static void StartGame()
    {
        CubeDestroyed();
        gameStarted = true;
    }

    public static void EndGame()
    {
        gameStarted = false;
        score = 0;
        SceneManager.LoadScene(0);
    }
}
