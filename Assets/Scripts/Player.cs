using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f; // 移動速度

    void Update()
    {
        // ゲームオーバーの時は何もしない、即リターン
        // **ここに処理を書く**


        // 左にx座標移動
        // Aまたは左キーで移動
        if (-8 < this.gameObject.transform.position.x)
        {
            // **ここに処理を書く**
            
            
        }

        // 右にx座標移動
        // Dまたは右キーで移動
        if (this.gameObject.transform.position.x < 8)
        {
            // **ここに処理を書く**


        }
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        // Fallingタグのオブジェクトと衝突した時
        if (collision.gameObject.CompareTag("Falling"))
        {
            // **ここに処理を書く**



        }
    }

    public void Reset()
    {
        this.gameObject.transform.position = new Vector3(0, -2, 0);
        this.gameObject.SetActive(true);
    }
}
