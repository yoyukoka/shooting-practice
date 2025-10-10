using UnityEngine;

public class Meteorite : MonoBehaviour
{
    private float posX;
    private float posY;
    public float speed = 5f;
    public float destroyHeight = -10f;

    void Start()
    {
        //課題2
        // 初期位置を保存
        // **ここに処理を書く**
        

    }

    void Update()
    {
        //課題2
        // ゲームオーバーの時は何もしない
        // **ここに処理を書く**


        //課題2
        // 下方向に移動
        // **ここに処理を書く**


        //課題2
        // 隕石が消えるY座標を下回ったら非表示
        if (transform.position.y < destroyHeight)
        {
            // **ここに処理を書く**

        }
    }

    public void Reset()
    {
        this.gameObject.SetActive(true);
        transform.position = new Vector3(posX, posY, 0);
    }
}
