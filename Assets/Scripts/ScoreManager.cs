using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; 

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public int leftScore = 0;
    public int rightScore = 0;

    public TMP_Text leftScoreText;
    public TMP_Text rightScoreText;

    private bool gameEnded = false;

    private void Awake()
    {
        Instance = this;
    }

    public void AddScore(bool isLeftGoal)
    {
        if (gameEnded) return;

        if (isLeftGoal)
            leftScore++;
        else
            rightScore++;

        UpdateUI();
        CheckGameOver();
    }

    private void UpdateUI()
    {
        leftScoreText.text = "Left Score: " + leftScore;
        rightScoreText.text = "Right Score: " + rightScore;
    }

    private void CheckGameOver()
    {
        if (leftScore >= 5)
        {
            GameOver("Left Wins!");
        }
        else if (rightScore >= 5)
        {
            GameOver("Right Wins!");
        }
    }

    private void GameOver(string message)
    {
        gameEnded = true;

        // 勝者を GameData に保存
        GameData.winnerMessage = message;

        // ボール停止
        GameObject ball = GameObject.FindGameObjectWithTag("ball");
        if (ball != null)
        {
            Rigidbody2D rb = ball.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.linearVelocity = Vector2.zero;
                rb.bodyType = RigidbodyType2D.Static;
            }
        }

        // 結果シーンへ移動
        Invoke(nameof(GoToResultScene), 0.5f);
    }

    private void GoToResultScene()
    {
        SceneManager.LoadScene("ResultScene");
    }
}
