using UnityEngine;
using Vuforia;
using WeaponsAR.Saving;
using WeaponsAR.Saving.Paths;

namespace WeaponsAR.Camera
{
    public sealed class FlashlightLoader : MonoBehaviour
    {
        private ISaveStorage<IsFlashlightEnabled> _stateStorage;

        private void Awake()
        {
            _stateStorage = new JsonStorage<IsFlashlightEnabled>(new Path("IsFlashlightEnabled.json"));
            
            if (VuforiaBehaviour.Instance != null)
                VuforiaBehaviour.Instance.CameraDevice.SetFlash(_stateStorage.HasSave() && _stateStorage.Load().Value);
        }
    }
}