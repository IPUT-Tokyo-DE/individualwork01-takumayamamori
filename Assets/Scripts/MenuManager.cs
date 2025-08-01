using UnityEngine;
using UnityEngine.SceneManagement;  // シーン遷移に使う

public class MenuManager : MonoBehaviour
{
    // Continueボタンが押された時にGameSceneに遷移
    public void ContinueGame()
    {
        SceneManager.LoadScene("GameScene");  // GameSceneに遷移
    }

    // Back to Titleボタンが押された時にStartSceneに遷移
    public void BackToTitle()
    {
        SceneManager.LoadScene("StartScene");  // StartSceneに遷移
    }
}
