using UnityEngine;
using UnityEngine.Audio;
using WeaponsAR.Saving;
using WeaponsAR.Saving.Paths;

namespace WeaponsAR.Sound
{
    public sealed class VolumeLoader : MonoBehaviour
    {
        [SerializeField] private AudioMixer _audioMixer;
        
        private VolumeApplier _volumeApplier;
        private ISaveStorage<Volume> _volumeStorage;

        private void Awake()
        {
            _volumeStorage = new JsonStorage<Volume>(new Path("Volume.json"));
            _volumeApplier = new VolumeApplier(_audioMixer);
            _volumeApplier.Apply(new Volume(_volumeStorage.HasSave() ? _volumeStorage.Load().Value : 1));
        }
    }
}