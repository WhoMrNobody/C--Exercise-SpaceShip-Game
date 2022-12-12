using System.Collections;
using System.Collections.Generic;
using UdemyProject1.Movements;
using UnityEngine;
using UnityEngine.UI;

namespace UdemyProject1.UI
{
    public class FuelSlider : MonoBehaviour
    {
        Slider _slider;
        Fuel _fuel;
        void Awake()
        {
            _slider = GetComponent<Slider>();
            _fuel = FindObjectOfType<Fuel>();
        }

        void Update()
        {
            _slider.value = _fuel.CurrentFuel;
        }
    }

}
