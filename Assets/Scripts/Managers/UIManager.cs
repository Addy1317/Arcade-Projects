using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace SlowpokeStudio.Managers
{
    public class UIManager : MonoBehaviour
    {
        [Header("Main Menu")]
        [SerializeField] private GameObject mainMenuPanel;
        [SerializeField] private Button gameModeButton;
        [SerializeField] private Button SettingsButton;
        [SerializeField] private Button quitButton;

        [Header("Settings")]
        [SerializeField] private GameObject settingsPanel;
        [SerializeField] private Slider bgSlider;
        [SerializeField] private Slider sfxSlider;
        [SerializeField] private Button settingsCloseButton;

        [Header("Game Mode")]
        [SerializeField] private GameObject gameModePanel;
        [SerializeField] private Button gameModeCloseButton;
        [SerializeField] private Button pongButton;
        [SerializeField] private Button dinoButton;
        [SerializeField] private Button spaceInvadersButton;

        private void OnEnable()
        {
            gameModeButton.onClick.AddListener(OnGameModeButton);
            SettingsButton.onClick.AddListener(OnSettingButton);
            quitButton.onClick.AddListener(OnQuitButton);

            settingsCloseButton.onClick.AddListener(OnSettingCloseButton);

            gameModeCloseButton.onClick.AddListener(OnGameModeCloseButton);

            pongButton.onClick.AddListener(OnPongButton);
            dinoButton.onClick.AddListener(OnDinoButton);
            spaceInvadersButton.onClick.AddListener(OnSpaceInaderButton);

        }

        private void OnDisable()
        {
            gameModeButton.onClick.RemoveListener(OnGameModeButton);
            SettingsButton.onClick.RemoveListener(OnSettingButton);
            quitButton.onClick.RemoveListener(OnQuitButton);

            settingsCloseButton.onClick.RemoveListener(OnSettingCloseButton);

            gameModeCloseButton.onClick.RemoveListener(OnGameModeCloseButton);

            pongButton.onClick.RemoveListener(OnPongButton);
            dinoButton.onClick.RemoveListener(OnDinoButton);
            spaceInvadersButton.onClick.RemoveListener(OnSpaceInaderButton);
        }

        #region Main Menu Buttons
        private void OnGameModeButton()
        {
            gameModePanel.SetActive(true);
        }

        private void OnSettingButton()
        {
            settingsPanel.SetActive(true);
        }

        private void OnQuitButton()
        {
            Application.Quit();
        }
        #endregion

        #region Settings Buttons
        private void OnSettingCloseButton()
        {
           settingsPanel.SetActive(false);
        }

        #endregion

        #region Game Mode Buttons
        private void OnPongButton()
        {
            Debug.Log("Pong Scene Active");
            SceneManager.LoadScene("Arcade-Pong");
        }

        private void OnDinoButton()
        {
            Debug.Log("Dino Scene Active");
            SceneManager.LoadScene("Arcade-Dino");
        }

        private void OnSpaceInaderButton()
        {
            Debug.Log("SpaceInvader Scene Active");
            SceneManager.LoadScene("Arcade-SpaceInvaders");
        }

        private void OnGameModeCloseButton()
        {
            gameModePanel.SetActive(false);
        }
        #endregion
    }
}
