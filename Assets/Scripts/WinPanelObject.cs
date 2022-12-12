using System;
using System.Collections;
using System.Collections.Generic;
using UdemyProject1.Managers;
using UnityEngine;

namespace UdemyProject1.UI
{
    public class WinPanelObject : MonoBehaviour
    {
        [SerializeField] GameObject _winPanel;
        private void Awake()
        {
            if (_winPanel.activeSelf) _winPanel.SetActive(false);
        }

        private void OnEnable()
        {
            GameManager.instance.OnGameSuccessed += HandleOnGameSuccessed;
        }

        private void OnDisable()
        {
            GameManager.instance.OnGameSuccessed -= HandleOnGameSuccessed;
        }

        private void HandleOnGameSuccessed()
        {
            if (!_winPanel.activeSelf) _winPanel.SetActive(true);
        }
    }
}

