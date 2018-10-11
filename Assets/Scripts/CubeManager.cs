using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour {

    public GameObject cubePrefab;
    List<Cube> currentCubes = new List<Cube>();

    public void Start()
    {
        GameManager.cubeManager = this;
    }

    public void SpawnCubes(List<Transform> positions)
    {
        for (int i = 0; i < positions.Count; i++)
        {
            Cube newCube = Instantiate(cubePrefab, positions[i].position, positions[i].rotation).GetComponent<Cube>();
            currentCubes.Add(newCube);
        }
    }

    public void DestroyCube(GameObject cube)
    {
        currentCubes.Remove(cube.GetComponent<Cube>());
        Destroy(cube.gameObject);
    }

    public bool AreStillCubes()
    {
        return currentCubes.Count != 0;
    }
}
