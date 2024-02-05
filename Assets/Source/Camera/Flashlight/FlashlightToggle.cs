using UnityEngine;
using UnityEngine.UI;
using Vuforia;
using WeaponsAR.Saving;
using WeaponsAR.Saving.Paths;

namespace WeaponsAR.Camera
{
    public sealed class FlashlightToggle : MonoBehaviour
    {
        [SerializeField] private Toggle _toggle;

        private IsFlashlightEnabled _isEnabled;
        private ISaveStorage<IsFlashlightEnabled> _stateStorage;

        private void Awake()
        {
            _stateStorage = new JsonStorage<IsFlashlightEnabled>(new Path("IsFlashlightEnabled.json"));
            _toggle.onValueChanged.AddListener(ChangeState);
            _toggle.isOn = _stateStorage.HasSave() && _stateStorage.Load().Value;
        }

        private void ChangeState(bool active)
        {
            if (VuforiaBehaviour.Instance != null)
                VuforiaBehaviour.Instance.CameraDevice.SetFlash(active);

            _isEnabled.Value = active;
            _stateStorage.Save(_isEnabled);
        }

        private void OnDestroy()
            => _toggle.onValueChanged.RemoveListener(ChangeState);
    }
}