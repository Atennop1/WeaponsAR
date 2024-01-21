using System;
using UnityEngine;
using UnityEngine.Audio;

namespace Weapons.Sound
{
    public sealed class VolumeSetter
    {
        private readonly AudioMixer _audioMixer;

        public VolumeSetter(AudioMixer audioMixer) 
            => _audioMixer = audioMixer ?? throw new ArgumentNullException(nameof(audioMixer));

        public void Set(Volume volume)
        {
            Debug.Log("Set");
            _audioMixer.SetFloat("volume", (1 - Mathf.Sqrt(volume.Value)) * -80f);
        }
    }
}