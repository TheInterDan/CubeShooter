using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameManager {

    public static Puntuacion puntuacion;
    static int score;

    public static int AddScore(int add = 1)
    {
        score += add;
        puntuacion.UpdateScore(score);
        return score;
    }

    static int id = 0;

    public static int GetID()
    {
        return id++;
    }
}
