using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        ScoreManager.Instance.AddScore();
    }
}
