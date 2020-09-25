using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<GameObject> GameObjects = new List<GameObject>();
    public static bool isTrigger;
    public static float time = 1.4f;
    public float x1 = -30f;
    public float x2 = 30f;
    public float y1 = -79;
    public float y2 = -69;


    void Start()
    {
        isTrigger = true;
    }
    void Update()
    {
        if (isTrigger)
        {
         

            Instantiate(GameObjects[0], new Vector2(x1,y1), Quaternion.identity);
            Instantiate(GameObjects[1], new Vector2(x2,y2), Quaternion.identity);

            isTrigger = false;


        }

    }
    
    
}
