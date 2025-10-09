using UnityEngine;
using UnityEngine.UI;

public class GameSystem : MonoBehaviour
{
    public static bool IsGameOver = false;
    public Text scoreText;
    public GameObject gameOverPanel;
    private float survivalTime = 0f;

    void Update()
    {
        if (!IsGameOver)
        {
            // **ここに処理を書く**
            // ヒント1: survivalTime += Time.deltaTime;
            // ヒント2: scoreText.text = "Score: " + Mathf.FloorToInt(survivalTime);
        }
        else
        {
            // ゲームオーバーパネルを表示
            // **ここに処理を書く**
            // ヒント: gameOverPanel.SetActive(true);
        }
    }

    public void ResetTimeCount()
    {
        survivalTime = 0f;
    }
}