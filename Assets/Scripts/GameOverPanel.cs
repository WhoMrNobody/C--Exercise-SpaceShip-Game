using System.Collections;
using System.Collections.Generic;
using UdemyProject1.Managers;
using UnityEngine;

namespace UdemyProject1.UI
{
    public class GameOverPanel : MonoBehaviour
    {
        public void PlayAgain()
        {
            GameManager.instance.LoadLevelScene();
        }

        public void MainMenu()
        {
            GameManager.instance.LoadMenuScene();
        }
    }
}

