using UnityEngine;

namespace Assets.Scripts.GameLogic
{
    public class ObjectDestroyerScript : MonoBehaviour
    {
        [SerializeField] private float _playerPosX;
        [SerializeField] private float _destroyDistance;

        private void Update()
        {
            if (transform.position.x + _destroyDistance < _playerPosX)
                Destroy(gameObject);
        }
    }
}

