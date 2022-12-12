using System.Collections;
using System.Collections.Generic;
using UdemyProject1.Managers;
using UnityEngine;

namespace UdemyProject1.UI
{
    public class WinPanel : MonoBehaviour
    {
       public void NextLevel()
        {
            GameManager.instance.LoadLevelScene(1);
        }
    }
}

