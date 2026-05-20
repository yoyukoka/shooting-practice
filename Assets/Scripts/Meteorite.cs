using UnityEngine;

public class Meteorite : MonoBehaviour
{
    private float posX;
    private float posY;
    public float speed = 5f;
    public float destroyHeight = -10f;

    void Start()
    {
        posX = this.gameObject.transform.position.x;
        posY = this.gameObject.transform.position.y;
    }

    void Update()
    {
        if (GameSystem.IsGameOver)
        {
            return;
        }


        //課題2
        // 下方向に移動
        // **ここに処理を書く**
        transform.position += new Vector3(0,-1,0) * speed * Time.deltaTime;

        //課題2
        // 隕石が消えるY座標を下回ったら非表示
        if (transform.position.y < destroyHeight)
        {
            this.gameObject.SetActive(false);
        }
    }

    public void Reset()
    {
        this.gameObject.SetActive(true);
        transform.position = new Vector3(posX, posY, 0);
    }
}
