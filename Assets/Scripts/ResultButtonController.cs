using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultButtonController : MonoBehaviour
{
    public void OnRetryButtonClicked()
    {
        SceneManager.LoadScene("GameScene"); // ゲームプレイ画面へ
    }

    public void OnBackToTitleButtonClicked()
    {
        SceneManager.LoadScene("StartScene"); // スタート画面へ
    }
}
