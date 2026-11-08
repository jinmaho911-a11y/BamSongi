using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int totalScore;
    public Text scoreText;

    public void UpdateUI()
    {
        scoreText.text = totalScore.ToString();
    }
}
