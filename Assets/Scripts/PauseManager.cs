using UnityEngine;
using UnityEngine.SceneManagement;  // �V�[���J�ڂɎg��

public class PauseManager : MonoBehaviour
{
    public GameObject pauseMenu;  // �|�[�Y���j���[�̃p�l���������Ƀh���b�O���h���b�v
    private bool isPaused = false;

    void Update()
    {
        // M�L�[�������ꂽ��MenuScene�Ɉړ�
        if (Input.GetKeyDown(KeyCode.M))
        {
            GoToMenu();
        }
    }

    // MenuScene�Ɉړ����郁�\�b�h
    public void GoToMenu()
    {
        // �Q�[�����~����MenuScene�ɑJ��
        Time.timeScale = 1f;  // �Q�[���X�s�[�h�����ɖ߂��i�|�[�Y���ł������ƑJ�ځj
        SceneManager.LoadScene("MenuScene");  // MenuScene�ɑJ��
    }
}
