using UnityEngine;

namespace Ans
{
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

            transform.Translate(Vector3.down * speed * Time.deltaTime);

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
}