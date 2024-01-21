using UnityEngine;
using UnityEngine.UI;
using Vuforia;
using Weapons.Saving;
using Weapons.Saving.Paths;

namespace Weapons.Camera
{
    public sealed class FlashlightToggle : MonoBehaviour
    {
        [SerializeField] private Toggle _toggle;

        private FlashlightState _currentState;
        private ISaveStorage<FlashlightState> _stateStorage;

        private void Awake()
        {
            _stateStorage = new JsonStorage<FlashlightState>(new Path("Flashlight.json"));
            _toggle.onValueChanged.AddListener(ChangeState);
            _toggle.isOn = _stateStorage.HasSave() && _stateStorage.Load().Value;
        }

        private void ChangeState(bool active)
        {
            if (VuforiaBehaviour.Instance != null)
                VuforiaBehaviour.Instance.CameraDevice.SetFlash(active);

            _currentState.Value = active;
            _stateStorage.Save(_currentState);
        }

        private void OnDestroy()
            => _toggle.onValueChanged.RemoveListener(ChangeState);
    }
}