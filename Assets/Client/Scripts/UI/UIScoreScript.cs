using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI
{
    public class UIScoreScript : MonoBehaviour
    {
        public static UIScoreScript Instance;

        [HideInInspector] public int score = 0;

        [SerializeField] private Text ScoreText;

        private void Awake()
        {
            Instance = this;
        }

        private void Update()
        {
            ScoreText.text = string.Empty + score;
        }
    }
}

