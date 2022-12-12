using System.Collections;
using UdemyProject1.Abstracts.Utilities;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UdemyProject1.Managers
{
    public class GameManager : SingletonThisObject<GameManager>
    {
        public event System.Action OnGameOver;
        public event System.Action OnGameSuccessed;

        private void Awake()
        {
            SingletonThisGameObject(this);
            
        }

        public void GameOver()
        {
            OnGameOver?.Invoke();
            /*if(OnGameOver!= null)
            {
                OnGameOver();
            }*/

        }

        public void GameSuccessed()
        {
            OnGameSuccessed?.Invoke();
        }

        public void LoadLevelScene(int levelIndex = 0)
        {
            StartCoroutine(LoadLevelSceneAsync(levelIndex));
        }

        private IEnumerator LoadLevelSceneAsync(int levelIndex)
        {
            SoundManager.instance.StopPlayAudio(1);
            yield return SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + levelIndex);
            SoundManager.instance.PlayAudio(2);
        }

        public void LoadMenuScene()
        {
            StartCoroutine(LoadMenuSceneAsync());
        }

        private IEnumerator LoadMenuSceneAsync()
        {
            SoundManager.instance.StopPlayAudio(2);
            yield return SceneManager.LoadSceneAsync("MainMenuScene");
            SoundManager.instance.PlayAudio(1);
        }

        public void Exit()
        {
            Application.Quit();
        }
    }
}

