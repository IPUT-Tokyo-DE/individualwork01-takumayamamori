using UnityEngine;
using TMPro;

public class ResultDisplay : MonoBehaviour
{
    public TMP_Text resultText;

    void Start()
    {
        resultText.text = GameData.winnerMessage; // GameData からメッセージを受け取る
    }
}
