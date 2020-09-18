using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntennaSpawner : MonoBehaviour
{
    public List<GameObject> GameObjects = new List<GameObject>();
    int rnd;

    void Start()
    { }
    void Update()
    {
        if (Spawner.isTrigger)
        {

            rnd = Random.Range(0, GameObjects.Count+1);

            Instantiate(GameObjects[rnd], new Vector2(transform.position.x, transform.position.y), Quaternion.identity);

        }

    }
}