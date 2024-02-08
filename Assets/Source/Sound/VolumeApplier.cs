using System;
using UnityEngine;
using UnityEngine.Audio;

namespace WeaponsAR.Sound
{
    public sealed class VolumeApplier
    {
        private const string _volumeParameterName = "volume";
        private readonly AudioMixer _audioMixer;

        public VolumeApplier(AudioMixer audioMixer) 
            => _audioMixer = audioMixer ?? throw new ArgumentNullException(nameof(audioMixer));

        public void Apply(Volume volume) 
            => _audioMixer.SetFloat(_volumeParameterName, (1 - Mathf.Sqrt(volume.Value)) * -80f);
    }
}