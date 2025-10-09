using UnityEngine;

namespace Ans
{
    public class Player : MonoBehaviour
    {
        public float moveSpeed = 5f;

        void Update()
        {
            if (GameSystem.IsGameOver)
            {
                return;
            }

            if (-8 < this.gameObject.transform.position.x)
            {
                if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
                {
                    transform.position += Vector3.left * moveSpeed * Time.deltaTime;
                }
            }

            if (this.gameObject.transform.position.x < 8)
            {
                if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
                {
                    transform.position += Vector3.right * moveSpeed * Time.deltaTime;
                }
            }
        }

        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Falling"))
            {
                GameSystem.IsGameOver = true;
                this.gameObject.SetActive(false);
                collision.gameObject.SetActive(false);
            }
        }

        public void Reset()
        {
            this.gameObject.transform.position = new Vector3(0, -2, 0);
            this.gameObject.SetActive(true);
        }
    }
}