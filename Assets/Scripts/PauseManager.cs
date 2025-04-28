using UnityEngine;
using UnityEngine.SceneManagement;  // シーン遷移に使う

public class PauseManager : MonoBehaviour
{
    public GameObject pauseMenu;  // ポーズメニューのパネルをここにドラッグ＆ドロップ
    private bool isPaused = false;

    void Update()
    {
        // Mキーが押されたらMenuSceneに移動
        if (Input.GetKeyDown(KeyCode.M))
        {
            GoToMenu();
        }
    }

    // MenuSceneに移動するメソッド
    public void GoToMenu()
    {
        // ゲームを停止してMenuSceneに遷移
        Time.timeScale = 1f;  // ゲームスピードを元に戻す（ポーズ中でもちゃんと遷移）
        SceneManager.LoadScene("MenuScene");  // MenuSceneに遷移
    }
}
