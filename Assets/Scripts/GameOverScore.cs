using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameOverScore : MonoBehaviour
{
    public TextMeshProUGUI score;
    // Start is called before the first frame update
    void Start()
    {
       score.text = Score.scoref.ToString();
    }

    // Update is called once per frame
  
}
