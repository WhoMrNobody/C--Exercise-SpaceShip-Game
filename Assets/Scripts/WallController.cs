using System.Collections;
using System.Collections.Generic;
using UdemyProject1.Controller;
using UdemyProject1.Managers;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UdemyProject1.Abstracts.Controller
{
    public abstract class WallController : MonoBehaviour
    {
        void OnCollisionEnter(Collision other)
        {
            PlayerController player = other.collider.GetComponent<PlayerController>();

            if (player != null && player.CanMove)
            {
                GameManager.instance.GameOver();
            }
        }
    }
}

