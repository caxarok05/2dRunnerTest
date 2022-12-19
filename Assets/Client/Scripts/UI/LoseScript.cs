using UnityEngine;

namespace Assets.Scripts.UI
{
    public class LoseScript : MonoBehaviour
    {
        public static LoseScript Instance;

        [SerializeField] private GameObject _deathPanel;

        private void Awake()
        {
            Instance = this;
        }

        public void LoseGame()
        {
            Time.timeScale = 0;
            UIManager.DisplayPanel(_deathPanel);
        }

    }

}
