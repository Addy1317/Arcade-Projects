using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace SlowpokeStudio.ArcadePong
{
    public class MainLobby : MonoBehaviour
    {
        [Header("Lobby Buttons")]
        [SerializeField] private GameObject _lobbyPanel;
        [SerializeField] private Button _playButton;
        [SerializeField] private Button _settingsButton;
        [SerializeField] private Button _quitButton;
       
        [Header("AreYouSure? Buttons")]
        [SerializeField] private GameObject _areYouSurePanel;
        [SerializeField] private Button _yesButton;
        [SerializeField] private Button _noButton;
        [SerializeField] private Button _areYouSureCloseButton;

        [Header("Setting Attribute Buttons")]
        [SerializeField] private GameObject _settingPanel;
        [SerializeField] private Slider _musicSlider;
        [SerializeField] private Slider _soundSlider;
        [SerializeField] private Button _settingsCloseButton;

        private void Start()
        {
            LobbyButtons();

            AreYouSureButtons();

            SettingsButtons();
        }

        private void LobbyButtons()
        {
            _playButton.onClick.AddListener(PlayButton);
            _settingsButton.onClick.AddListener(SettingsButton);
            _quitButton.onClick.AddListener(QuitButton);
        }

        private void AreYouSureButtons()
        {
            _yesButton.onClick.AddListener(YesButton);
            _noButton.onClick.AddListener(NoButton);
            _areYouSureCloseButton.onClick.AddListener(AreYouSureCloseButton);
        }

        private void SettingsButtons()
        {
            _settingsCloseButton.onClick.AddListener(SettingButtonCLosed);
        }

        private void PlayButton()
        {
            SceneManager.LoadScene(1);
        }

        //Settings Button Fnc
        private void SettingsButton()
        {
            _settingPanel.SetActive(true);
        }

        private void SettingButtonCLosed()
        {
            _settingPanel.SetActive(false);
        }

        //Quit Buttons Fnc
        private void QuitButton()
        {
            _areYouSurePanel.SetActive(true);
        }

        private void YesButton()
        {
            Application.Quit();
            Debug.Log("Application is Quit");
        }

        private void NoButton()
        {
            _areYouSurePanel.SetActive(false);
        }

        private void AreYouSureCloseButton()
        {
            _areYouSurePanel.SetActive(false);
        }
    }
}
