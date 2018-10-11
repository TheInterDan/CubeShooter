using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour {

    public GameObject cubePrefab;
    List<Cube> currentCubes = new List<Cube>();

    public void Start()
    {
        
    }

    public void SpawnCubes(List<Transform>positions)
    {
        int randIndex = Random.Range(0, positions.Count);
        for(int i = 0; i < positions.Count; i++)
        {
            if (i != randIndex)
            {
                Cube newCube = Instantiate(cubePrefab, positions[i].position, positions[i].rotation).GetComponent<Cube>();
                currentCubes.Add(newCube);
            }
        }
    }

    public bool AreStillCubes()
    {
        return currentCubes.Count != 0;
    }
}
