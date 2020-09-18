using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHealt : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Healthbar.health -= 10f;
    }
}