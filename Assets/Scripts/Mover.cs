using System.Collections;
using System.Collections.Generic;
using UdemyProject1.Controller;
using UnityEngine;

namespace UdemyProject1.Movements
{
    public class Mover
    {
        
        PlayerController _playerController;
        Rigidbody _rigidbody;

        public Mover(PlayerController playerController)
        {
            _playerController = playerController;
            _rigidbody = playerController.GetComponent<Rigidbody>();
        }
        public void FixedTick()
        { 
            _rigidbody.AddRelativeForce(Vector3.up * _playerController.Force);
        }
    }

}

