using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField] private bool isLeftGoal; // Inspector Ç≈ê›íËÇ∑ÇÈ

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("ball"))
        {
            ScoreManager.Instance.AddScore(isLeftGoal);
        }
    }
}
