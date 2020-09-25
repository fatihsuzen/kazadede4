using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UfoAnimController : MonoBehaviour
{
    public GameObject ufo;
    public List<GameObject> GameObjects = new List<GameObject>();
    // Start is called before the first frame update
    float timeStart;
    // Start is called before the first frame update

    // Update is called once per frame
    private void Start()
    {
        timeStart = Time.time;    

        for (int i = 0; i < GameObjects.Count; i++)
        {
            GameObjects[i].SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Time.time-timeStart  >= 3f)
        {
            for (int i = 0; i < GameObjects.Count; i++)
            {
                GameObjects[i].SetActive(true);
            }
        }
        if (Time.time - timeStart >= 4f)
        {
            ufo.SetActive(false);
        }
       
    }
}
