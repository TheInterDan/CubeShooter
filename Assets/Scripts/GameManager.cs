using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameManager {

    public static Puntuacion puntuacion;
    static int score;

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

    public static CubeManager cubeManager;

    public static void CubeDestroyed()
    {
        if (!cubeManager.AreStillCubes())
        {
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

    public static List<PlayerPosition> playerPositions = new List<PlayerPosition>();
}
