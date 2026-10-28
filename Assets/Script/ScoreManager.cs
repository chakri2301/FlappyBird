using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    int Score = 0;
    public Text ScoreText;
    void Start()
    {
        Instance = this;
    }
    public void AddScore()
    {
        Score += 1;
        Debug.Log("Score:" + Score);
        ScoreText.text = "Score: " + Score;
    }
}
