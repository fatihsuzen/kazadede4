using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI score;
    public static float scoref;

    void Update()
    {
        scoref += Time.deltaTime;
        score.text = scoref.ToString();
    }
}
