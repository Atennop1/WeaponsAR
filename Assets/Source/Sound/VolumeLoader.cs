using UnityEngine;
using UnityEngine.Audio;
using Weapons.Saving;
using Weapons.Saving.Paths;

namespace Weapons.Sound
{
    public sealed class VolumeLoader : MonoBehaviour
    {
        [SerializeField] private AudioMixer _audioMixer;
        
        private VolumeSetter _volumeSetter;
        private ISaveStorage<Volume> _volumeStorage;

        private void Start()
        {
            _volumeStorage = new JsonStorage<Volume>(new Path("Volume.json"));
            _volumeSetter = new VolumeSetter(_audioMixer);
            _volumeSetter.Set(new Volume(_volumeStorage.HasSave() ? _volumeStorage.Load().Value : 1));
        }
    }
}