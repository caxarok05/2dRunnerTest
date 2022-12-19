using UnityEngine;

namespace Assets.Scripts.GameLogic
{
    public class PlaneTriggerScript : MonoBehaviour
    {
        [SerializeField] private PlaneSpawnScript _planeSpawnScript;
        private void OnTriggerEnter2D(Collider2D other)
        {
            _planeSpawnScript.Spawn();
        }
    }
}
