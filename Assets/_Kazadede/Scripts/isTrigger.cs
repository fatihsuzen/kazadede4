using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isTrigger : MonoBehaviour
{
    public Spawner spawner;
    public AntennaSpawner antennaLeftSpawner;
    public AntennaSpawner antennaRightSpawner;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Apartment")
        {
            spawner.SpawnNewBuildingBlock();
            antennaLeftSpawner.SpawnNewAntenna();
            antennaRightSpawner.SpawnNewAntenna();
        }
    }
}