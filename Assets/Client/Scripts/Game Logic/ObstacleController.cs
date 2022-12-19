using UnityEngine;
using Assets.Scripts.UI;

namespace Assets.Scripts.GameLogic
{
    public class ObstacleController : MonoBehaviour
    {
        [SerializeField] private string _playerTag;
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag(_playerTag))
            {
                LoseScript.Instance.LoseGame();
            }
        }
    }
}

