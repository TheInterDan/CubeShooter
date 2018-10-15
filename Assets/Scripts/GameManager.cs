using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class GameManager {

    public static Main main;

    public static Puntuacion puntuacion;
    static int score;

    public static CubeManager cubeManager;
    public static List<PlayerPosition> playerPositions = new List<PlayerPosition>();

    public static bool gameStarted = false;
    public static bool auto = false;

    public static Player player;

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
        SpawnWave();
    }

    public static void SpawnWave()
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

            if (auto) {
                player.NewTarget(playerPositions[randIndex].transform);
            }
        }
    }

    public static void StartGame(bool autoPlay = false)
    {
        if (!gameStarted)
        {
            Time.timeScale = 1;
            auto = autoPlay;
            if (!auto) player.NewTarget(playerPositions[0].transform);
            SpawnWave();
            gameStarted = true;
            main.QuitTitle();
        }
    }

    public static void EndGame()
    {
        gameStarted = false;
        Time.timeScale = 0;
        //aparece texto "game over" y "pulsa para reintentar"

        if (Input.GetButtonDown("Fire1"))
        {
        score = 0;
        SceneManager.LoadScene(0);
        auto = false;
        }
    }
}
