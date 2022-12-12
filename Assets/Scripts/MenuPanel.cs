using System.Collections;
using System.Collections.Generic;
using UdemyProject1.Managers;
using UnityEngine;

namespace UdemyProject1.UI
{
    public class MenuPanel : MonoBehaviour
    {
       public void StartGame()
       {
            GameManager.instance.LoadLevelScene(1);
       }

        public void ExitGame()
        {
            GameManager.instance.Exit();
        }
    }


}
