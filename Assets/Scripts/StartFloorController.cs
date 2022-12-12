using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyProject1.Controller
{
    public class StartFloorController : MonoBehaviour
    {
        void OnCollisionExit(Collision other)
        {
            PlayerController player = other.collider.GetComponent<PlayerController>();

            if(player != null )
            {
                Destroy(this.gameObject);
            }
        }
    }

}

