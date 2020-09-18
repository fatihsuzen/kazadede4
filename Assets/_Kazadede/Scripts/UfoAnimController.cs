using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UfoAnimController : MonoBehaviour
{
    public GameObject ufo;
    public List<GameObject> GameObjects = new List<GameObject>();

    private void Start()
    {
        for (int i = 0; i < GameObjects.Count; i++)
        {
            GameObjects[i].SetActive(false);
        }

        Invoke("ObjeleriGetir", 3);
        Invoke("UfoyuKapat", 4);

        // StartCoroutine(Objelerigetir(2, 5));
    }

    IEnumerator Objelerigetir(int firtDelay, int secondDelay)
    {
        for (int i = 0; i < GameObjects.Count; i++)
        {
            GameObjects[i].SetActive(true);
        }

        yield return new WaitForSeconds(firtDelay);

        ufo.SetActive(false);

        yield return new WaitForSeconds(secondDelay);
    }

    void ObjeleriGetir()
    {
        for (int i = 0; i < GameObjects.Count; i++)
        {
            GameObjects[i].SetActive(true);
        }
    }

    void UfoyuKapat()
    {
        ufo.SetActive(false);
    }
}
