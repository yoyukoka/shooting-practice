using UnityEngine;
using UnityEngine.UI;

namespace Ans
{
    public class GameSystem : MonoBehaviour
    {
        public static bool IsGameOver = false;
        public Text scoreText;
        public GameObject gameOverPanel;
        private float survivalTime = 0f;

        void Update()
        {
            if (!IsGameOver)
            {
                survivalTime += Time.deltaTime;
                scoreText.text = "Score: " + Mathf.FloorToInt(survivalTime) * 100;
            }
            else
            {
                gameOverPanel.SetActive(true);
            }
        }

        public void ResetTimeCount()
        {
            survivalTime = 0f;
        }
    }
}