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
            // テキストにに"Score: "をつけて表示
            // **ここに処理を書く**
            
        }
        else
        {
            //課題5
            // ゲームオーバーパネルを表示
            // **ここに処理を書く**
            
        }
    }

    public void ResetTimeCount()
    {
        survivalTime = 0f;
    }
}