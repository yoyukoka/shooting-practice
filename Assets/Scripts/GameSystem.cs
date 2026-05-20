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
            //課題5
            // 生存時間を加算してスコア表示
            // survivalTime に1フレーム分の経過時間を足す（Time.???）
            // テキストに "Score: " をつけて、生存時間(秒) × 100 を表示する
            survivalTime += Time./* ここに書く */;
            scoreText.text = "Score: " + Mathf.FloorToInt(/* ここに書く */) * 100;
        }
        else
        {
            //課題5
            // ゲームオーバーパネルを表示
            gameOverPanel.SetActive(/* ここに書く */);   
        }
    }

    public void ResetTimeCount()
    {
        survivalTime = 0f;
    }
}