using System.Collections;
using System.Collections.Generic;
using UdemyProject1.Abstracts.Utilities;
using UnityEngine;

namespace UdemyProject1.Managers
{
    public class SoundManager : SingletonThisObject<SoundManager>
    {
        AudioSource[] _audioSource;
        void Awake()
        {
            SingletonThisGameObject(this);
            _audioSource = GetComponentsInParent<AudioSource>();

        }

        public void PlayAudio(int index)
        {
            if (!_audioSource[index].isPlaying)
            {
                _audioSource[index].Play();
            }
        }

        public void StopPlayAudio(int index)
        {
            if (_audioSource[index].isPlaying)
            {
                _audioSource[index].Stop();
            }
        }

        
    }

}

