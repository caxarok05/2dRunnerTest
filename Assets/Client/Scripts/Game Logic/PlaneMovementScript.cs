using UnityEngine;

namespace Assets.Scripts.GameLogic
{
    public class PlaneMovementScript : MonoBehaviour
    {
        [SerializeField] private float _speed = 0;
        private void FixedUpdate()
        {
            Move();
        }

        private void Move()
        {
            transform.Translate(Vector2.left * _speed * Time.deltaTime);
        }
    }
}

