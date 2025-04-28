using UnityEngine;
using UnityEngine.SceneManagement;  // ƒV[ƒ“‘JˆÚ‚Ég‚¤

public class MenuManager : MonoBehaviour
{
    // Continueƒ{ƒ^ƒ“‚ª‰Ÿ‚³‚ê‚½‚ÉGameScene‚É‘JˆÚ
    public void ContinueGame()
    {
        SceneManager.LoadScene("GameScene");  // GameScene‚É‘JˆÚ
    }

    // Back to Titleƒ{ƒ^ƒ“‚ª‰Ÿ‚³‚ê‚½‚ÉStartScene‚É‘JˆÚ
    public void BackToTitle()
    {
        SceneManager.LoadScene("StartScene");  // StartScene‚É‘JˆÚ
    }
}
