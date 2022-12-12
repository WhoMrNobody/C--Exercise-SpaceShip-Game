using System.Collections;
using System.Collections.Generic;
using UdemyProject1.Managers;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UdemyProject1.Controller
{
    public class FinishFloorController : MonoBehaviour
    {
        [SerializeField] GameObject _fireworks;
        private void OnCollisionEnter(Collision other)
        {
            PlayerController player = other.collider.GetComponent<PlayerController>();

            if (player == null || !player.CanMove) return;

            if(other.GetContact(0).normal.y == -1)
            {
                _fireworks.SetActive(true);
                GameManager.instance.GameSuccessed();
            }
            else
            {
                GameManager.instance.GameOver();
            }
        }
    }
}

