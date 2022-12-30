using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score;
    public Text scoreDisplay;

    public void Update()
    {
        scoreDisplay.text = score.ToString();
    }

    public void Kill()
    {
        score++;
    }
}
