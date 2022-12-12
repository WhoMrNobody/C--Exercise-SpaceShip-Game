using System.Collections;
using System.Collections.Generic;
using UdemyProject1.Abstracts.Controller;
using UnityEngine;

namespace UdemyProject1.Controller
{
    public class MoverWallController : WallController
    {
        [SerializeField] Vector3 _direction;
        [SerializeField] float _directionFactor = 1f;
        [SerializeField] float _speed = 1f;

        Vector3 _startPos;
        float _factor;
        const float FULL_CIRCLE = Mathf.PI * 2f;

        void Awake()
        {
            _startPos = transform.position;
        }

        void Update()
        {
            float cycle = Time.time / _speed;
            float sinWave = Mathf.Sin(cycle * FULL_CIRCLE);
            //_factor = Mathf.Abs(sinWave);

            _factor = sinWave / 2 + 0.5f;
            Vector3 offset = _direction * _factor;
            transform.position = offset + _startPos;
        }
    }
}

