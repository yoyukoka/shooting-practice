using UnityEngine;

// 完成しているクラス
// 触らない
public class ResetButton : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject meteoritesPrefab;

    void Start()
    {
        transform.parent.gameObject.SetActive(false);
    }

    public void OnClick()
    {
        playerPrefab.GetComponent<Player>().Reset();

        // 安全に隕石をリセットする: Inspector にシーン内のコンテナが割り当てられている場合はそれを使い、
        // そうでない（プレハブアセットが割り当てられているなど）場合はシーン内のすべての Meteorite を検索してリセットする。
        if (meteoritesPrefab != null)
        {
            // meteoritesPrefab がシーン内のオブジェクトかどうかをチェック
            if (meteoritesPrefab.scene.IsValid())
            {
                for (int i = 0; i < meteoritesPrefab.transform.childCount; i++)
                {
                    var m = meteoritesPrefab.transform.GetChild(i).GetComponent<Meteorite>();
                    if (m != null)
                        m.Reset();
                }
            }
            else
            {
                // プレハブアセットやシーン外の参照が設定されている場合のフォールバック
                foreach (var m in FindObjectsOfType<Meteorite>())
                {
                    m.Reset();
                }
            }
        }
        else
        {
            // meteoritesPrefab 自体が未設定ならシーン内を検索
            foreach (var m in FindObjectsOfType<Meteorite>())
            {
                m.Reset();
            }
        }

        GameSystem.IsGameOver = false;
        transform.parent.gameObject.SetActive(false);
        FindFirstObjectByType<GameSystem>().ResetTimeCount();
    }
}
