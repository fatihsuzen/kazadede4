using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntennaSpawner : MonoBehaviour
{
    public List<GameObject> GameObjects = new List<GameObject>();

    public void SpawnNewAntenna()
    {
        int rnd = Random.Range(0, GameObjects.Count);

        Instantiate(GameObjects[rnd], transform.position, Quaternion.identity);
    }
}