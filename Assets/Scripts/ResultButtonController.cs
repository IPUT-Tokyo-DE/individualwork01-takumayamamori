using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultButtonController : MonoBehaviour
{
    public void OnRetryButtonClicked()
    {
        SceneManager.LoadScene("GameScene"); // �Q�[���v���C��ʂ�
    }

    public void OnBackToTitleButtonClicked()
    {
        SceneManager.LoadScene("StartScene"); // �X�^�[�g��ʂ�
    }
}
