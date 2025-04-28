using UnityEngine;
using UnityEngine.SceneManagement;  // �V�[���J�ڂɎg��

public class MenuManager : MonoBehaviour
{
    // Continue�{�^���������ꂽ����GameScene�ɑJ��
    public void ContinueGame()
    {
        SceneManager.LoadScene("GameScene");  // GameScene�ɑJ��
    }

    // Back to Title�{�^���������ꂽ����StartScene�ɑJ��
    public void BackToTitle()
    {
        SceneManager.LoadScene("StartScene");  // StartScene�ɑJ��
    }
}
