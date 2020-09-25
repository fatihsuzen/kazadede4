using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI score;
    public static float scoref;
  
    void Update()
    {
        scoref += Time.timeScale;
        score.text = scoref.ToString();
    }
}
