using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameOverScore : MonoBehaviour
{
    public TextMeshProUGUI score;

    void Start()
    {
        score.text = Score.scoref.ToString();
    }
}