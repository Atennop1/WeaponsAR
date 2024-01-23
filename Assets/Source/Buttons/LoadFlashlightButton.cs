using UnityEngine;
using UnityEngine.UI;
using Vuforia;
using Weapons.Camera;
using Weapons.Saving;
using Weapons.Saving.Paths;

namespace Weapons.Buttons
{
    public sealed class LoadFlashlightButton : MonoBehaviour
    {
        [SerializeField] private Button _button;
        
        private ISaveStorage<FlashlightState> _stateStorage;
            
        private void Awake()
        {
            _stateStorage = new JsonStorage<FlashlightState>(new Path("Flashlight.json"));
            _button.onClick.AddListener(Load);
        }

        private void OnDestroy() 
            => _button.onClick.RemoveListener(Load);

        private async void Load()
        {
            await System.Threading.Tasks.Task.Delay(100);
            VuforiaBehaviour.Instance.CameraDevice.SetFlash(_stateStorage.HasSave() && _stateStorage.Load().Value);
        }
    }
}