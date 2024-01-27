using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using WeaponsAR.Saving;
using WeaponsAR.Saving.Paths;

namespace WeaponsAR.Sound
{
    public sealed class VolumeSlider : MonoBehaviour
    {
        [SerializeField] private AudioMixer _audioMixer;
        [SerializeField] private Slider _slider;

        private Volume _currentVolume;
        private ISaveStorage<Volume> _volumeStorage;
        private VolumeSetter _volumeSetter;

        private void Awake()
        {
            _volumeStorage = new JsonStorage<Volume>(new Path("Volume.json"));
            _volumeSetter = new VolumeSetter(_audioMixer);
            
            _slider.onValueChanged.AddListener(SetVolume);
            _slider.value = _volumeStorage.HasSave() ? _volumeStorage.Load().Value : 1;
        }

        private void SetVolume(float value)
        {
            _currentVolume.Value = value;
            _volumeSetter.Set(_currentVolume);
            _volumeStorage.Save(_currentVolume);
        }

        private void OnDestroy() 
            => _slider.onValueChanged.RemoveListener(SetVolume);
    }
}