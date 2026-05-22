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
        // if (this.gameObject.transform.position.x < 8)
        // {
        //    if (Input.GetKey(KeyCode./*ここに書く*/) || Input.GetKey(KeyCode./*ここに書く*/))
        //     {
        //         transform.position += new Vector3(/*ここに書く*/) * moveSpeed * Time.deltaTime;
        //     }
        // }
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        //課題3
        // Fallingタグのオブジェクトと衝突した時
        if (collision.gameObject.CompareTag("Falling"))
        {
            // GameSystem.IsGameOver = /* true または false */;
            // this.gameObject.SetActive(/* true または false */);
            // collision.gameObject.SetActive(/* true または false */);
        }
    }

    public void Reset()
    {
        //課題4
        // プレイヤーを初期位置に戻す
        // this.gameObject.transform.position = new Vector3(0, -3, 0);
        // this.gameObject.SetActive(/* true または false */);
    }
}
