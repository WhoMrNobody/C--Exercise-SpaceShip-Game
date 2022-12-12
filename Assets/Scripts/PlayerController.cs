using System;
using System.Collections;
using System.Collections.Generic;
using UdemyProject1.Inputs;
using UdemyProject1.Managers;
using UdemyProject1.Movements;
using UnityEngine;


namespace UdemyProject1.Controller
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float _turnSpeed = 10f;
        [SerializeField] float _force = 25f;

        Mover _mover;
        DefaultInput _input;
        Rotator _rotator;
        Fuel _fuel;

        bool _canForceUp;
        bool _canMove;
        float _leftRight;
        public float TurnSpeed => _turnSpeed;
        public float Force => _force;
        public bool CanMove => _canMove;
        void Awake()
        {
            _mover = new Mover(this);
            _input = new DefaultInput();
            _rotator = new Rotator(this);
            _fuel = GetComponent<Fuel>();
        }

        void Start()
        {
            _canMove = true;
        }

        private void OnEnable()
        {
            GameManager.instance.OnGameOver += HandleOnEventTriggered;
            GameManager.instance.OnGameSuccessed += HandleOnEventTriggered;
        }

        private void OnDisable()
        {
            GameManager.instance.OnGameOver -= HandleOnEventTriggered;
            GameManager.instance.OnGameSuccessed -= HandleOnEventTriggered;
        }

        void Update()
        {
            if (!_canMove) return;
            
            if (_input.IsForceUp && !_fuel.IsEmpty)
            {
                _canForceUp = true;
            }
            else
            {
                _canForceUp = false;
                _fuel.FuelIncrease(0.01f);
            }

            _leftRight = _input.LeftRight;
        }

        void FixedUpdate()
        {
            if( _canForceUp)
            {
                _mover.FixedTick();
                _fuel.FuelDecrease(0.2f);
            }

            _rotator.FixedTick(_leftRight);
        }

        private void HandleOnEventTriggered()
        {
            _canMove= false;
            _canForceUp= false;
            _leftRight = 0f;
            _fuel.FuelIncrease(0f);
        }
    }

}
