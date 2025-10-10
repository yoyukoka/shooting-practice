using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f; // 移動速度

    void Update()
    {
        // 課題1
        // ゲームオーバーの時は何もしない、即リターン
        // GameSystem.csのisGameOverを参照
        // **ここに処理を書く**


        // 課題1
        // 左にx座標移動
        // Aまたは左キーで移動
        if (-8 < this.gameObject.transform.position.x)
        {
            // **ここに処理を書く**


        }

        //課題1
        // 右にx座標移動
        // Dまたは右キーで移動
        if (this.gameObject.transform.position.x < 8)
        {
            // **ここに処理を書く**


        }
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        //課題3
        // Fallingタグのオブジェクトと衝突した時
        if (collision.gameObject.CompareTag("Falling"))
        {
            //課題3
            // 1. ゲームオーバーにする
            // 2. プレイヤーを非表示にする
            // 3. 隕石を非表示にする
            // **ここに処理を書く**



        }
    }

    public void Reset()
    {
        this.gameObject.transform.position = new Vector3(0, -2, 0);
        this.gameObject.SetActive(true);
    }
}
