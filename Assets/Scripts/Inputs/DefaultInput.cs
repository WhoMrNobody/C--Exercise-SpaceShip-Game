using System.Collections;
using System.Collections.Generic;
using UdemyProject1.Movements;
using UnityEngine;


namespace UdemyProject1.Inputs
{
    public class DefaultInput
    {
        DefaultActions _input;
        
        public bool IsForceUp { get; private set; }
        public float LeftRight { get; private set; }

        public DefaultInput()
        {
            _input = new DefaultActions();

            _input.Rocket.ForceUp.performed += context => IsForceUp = context.ReadValueAsButton();
            _input.Rocket.LeftRight.performed += context => LeftRight = context.ReadValue<float>();
            _input.Enable();
        }

    }

}

