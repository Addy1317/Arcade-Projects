using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace SlowpokeStudio.ArcadePong
{
    public class GameManager : MonoBehaviour
    {
        [Header("Paddle Reference")]
        [SerializeField] private PlayerPaddle _playerPaddle;
        [SerializeField] private ComputerPaddle _computerPaddle;

        [Header("Ball Reference")]
        [SerializeField] private Ball _ball;

        [Header("UI Reference")]
        [SerializeField] private TMP_Text _playerScoreText;
        [SerializeField] private TMP_Text _computerScoreText;

        [Header("Game Paused UI")]
        [SerializeField] private GameObject _pausePanel;
        [SerializeField] private Button _pauseButton;
        [SerializeField] private Button _restartButton;
        [SerializeField] private Button _homeButton;
        [SerializeField] private Button _closeButton;

        private int _playerScore;
        private int _computerScore;

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

        #region Score Methods
        public void PlayerScore()
        {
            _playerScore++;
            this._playerScoreText.text = _playerScore.ToString();
            ResetRound();
        }

        public void ComputerScore()
        {
            _computerScore++;
            this._computerScoreText.text = _computerScore.ToString();
            ResetRound();
        }

        private void ResetRound()
        {
            this._playerPaddle.ResetPosition();
            this._computerPaddle.ResetPosition();
            this._ball.ResetPosition();
            this._ball.AddStartForce();
        }

        #endregion

        #region PauseMenu Method

        private void OnPauseButton()
        {
            _pausePanel.SetActive(true);
        }

        private void OnRestartButton()
        {
            SceneManager.LoadScene("Arcade-Pong");
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
