using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.UI
{
    public class UIManager : MonoBehaviour
    {
        public static void EndGame()
        {
            Application.Quit();
        }

        public static void PlayAgain()
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("MainScene");
        }

        public static void ChangeScene(string name)
        {
            SceneManager.LoadScene(name);
        }

        public static void DisplayPanel(GameObject panel)
        {
            panel.SetActive(true);
        }

        public static void ClosePanel(GameObject panel)
        {
            panel.SetActive(false);
        }
    }

}
