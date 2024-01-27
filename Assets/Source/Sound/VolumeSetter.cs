using System;
using UnityEngine;
using UnityEngine.Audio;

namespace WeaponsAR.Sound
{
    public sealed class VolumeSetter
    {
        private const string _volumeParameterName = "volume";
        private readonly AudioMixer _audioMixer;

        public VolumeSetter(AudioMixer audioMixer) 
            => _audioMixer = audioMixer ?? throw new ArgumentNullException(nameof(audioMixer));

        public void Set(Volume volume) 
            => _audioMixer.SetFloat(_volumeParameterName, (1 - Mathf.Sqrt(volume.Value)) * -80f);
    }
}