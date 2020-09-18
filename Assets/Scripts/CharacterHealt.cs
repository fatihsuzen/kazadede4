using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHealt : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Healthbar.health -= 10f;
    }
}
