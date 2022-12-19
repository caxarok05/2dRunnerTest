using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.GameLogic
{
    public class PlaneSpawnScript : MonoBehaviour
    {
        [SerializeField] private List<GameObject> _planePrefabs;
        [SerializeField] private float _planeLength;
        private GameObject _plane;

        private void Start()
        {
            _plane = Instantiate(_planePrefabs[Random.Range(0, _planePrefabs.Count)], transform.position, Quaternion.identity);
        }

        public void Spawn()
        {
            Vector3 position = new Vector3(_plane.transform.position.x + _planeLength, _plane.transform.position.y, 0);
            _plane = Instantiate(_planePrefabs[Random.Range(0, _planePrefabs.Count)], position, Quaternion.identity);
        }
    }

}


