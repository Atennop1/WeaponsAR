using UnityEngine;
using UnityEngine.UI;
using Vuforia;

namespace Weapons.Initialization
{
    public sealed class FlashlightToggle : MonoBehaviour
    {
        [SerializeField] private Toggle _toggle;

        private void Awake() 
            => _toggle.onValueChanged.AddListener(ChangeState);

        private void ChangeState(bool active) 
            => VuforiaBehaviour.Instance.CameraDevice.SetFlash(active);

        private void OnDestroy()
            => _toggle.onValueChanged.RemoveListener(ChangeState);
    }
}