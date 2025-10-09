using UnityEngine;

public class ResetButton : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject meteoritesPrefab;

    void Start()
    {
        // 最初はゲームオーバーパネルを非表示
        // **ここに処理を書く**
        // ヒント: transform.parent.gameObject.SetActive(false);
    }

    public void OnClick()
    {
        // プレイヤーをリセット
        // **ここに処理を書く**
        // ヒント: playerPrefab.GetComponent<Player>().Reset();

        // すべての隕石をリセット
        for (int i = 0; i < meteoritesPrefab.transform.childCount; i++)
        {
            // **ここに処理を書く**
            // ヒント: meteoritesPrefab.transform.GetChild(i).GetComponent<Meteorite>().Reset();
        }

        // ゲームオーバーフラグをfalseに
        // **ここに処理を書く**


        // ゲームオーバーパネルを非表示
        // **ここに処理を書く**
        // ヒント: transform.parent.gameObject.SetActive(false);

        // スコアをリセット
        // **ここに処理を書く**
        // ヒント: FindFirstObjectByType<GameSystem>().ResetTimeCount();
    }
}