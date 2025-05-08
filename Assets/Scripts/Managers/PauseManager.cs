using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace SlowpokeStudio.Pause
{
    public class PauseManager : MonoBehaviour
    {
        [Header("Game Paused UI")]
        [SerializeField] private GameObject _pausePanel;
        [SerializeField] private Button _pauseButton;
        [SerializeField] private Button _restartButton;
        [SerializeField] private Button _homeButton;
        [SerializeField] private Button _closeButton;

        private Scene currentScene;

        private void Start()
        {
            currentScene = SceneManager.GetActiveScene();
            string sceneName = currentScene.name;
        }
        private void OnEnable()
        {
            _pauseButton.onClick.AddListener(OnPauseButton);
            _restartButton.onClick.AddListener(OnRestartButton);
            _homeButton.onClick.AddListener(OnHomeButton);
            _closeButton.onClick.AddListener(OnClosePauseButton);
        }

        private void OnDisable()
        {
            _pauseButton.onClick.RemoveListener(OnPauseButton);
            _restartButton.onClick.RemoveListener(OnRestartButton);
            _homeButton.onClick.RemoveListener(OnHomeButton);
            _closeButton.onClick.RemoveListener(OnClosePauseButton);
        }

        #region PauseMenu Method

        private void OnPauseButton()
        {
            _pausePanel.SetActive(true);
        }

        private void OnRestartButton()
        {
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);
        }

        private void OnHomeButton()
        {
            SceneManager.LoadScene("MainMenu");
        }

        private void OnClosePauseButton()
        {
            _pausePanel.SetActive(false);
        }
        #endregion

    }
}
