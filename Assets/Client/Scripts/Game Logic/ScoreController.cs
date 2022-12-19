using UnityEngine;
using Assets.Scripts.UI;

namespace Assets.Scripts.GameLogic
{
    public class ScoreController : MonoBehaviour
    {
        [SerializeField] private string _playerTag;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag(_playerTag))
            {
                UIScoreScript.Instance.score++;
            }
        }
    }
}

