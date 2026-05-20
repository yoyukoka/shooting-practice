using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f; // 移動速度

    void Update()
    {
        if (GameSystem.IsGameOver)
        {
            return;
        }


        // 左にx座標移動
        // Aまたは左キーで移動
        if (-8 < this.gameObject.transform.position.x)
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position += new Vector3(-1, 0, 0) * moveSpeed * Time.deltaTime;
            }
        }

        //課題1
        // 右にx座標移動
        // Dまたは右キーで移動
        if (this.gameObject.transform.position.x < 8)
        {
           if (Input.GetKey(KeyCode./*ここに書く*/) || Input.GetKey(KeyCode./*ここに書く*/))
            {
                transform.position += new Vector3(/*ここに書く*/) * moveSpeed * Time.deltaTime;
            }
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
