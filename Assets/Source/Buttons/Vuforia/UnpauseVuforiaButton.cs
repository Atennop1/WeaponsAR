using UnityEngine;
using UnityEngine.UI;
using Vuforia;

namespace WeaponsAR.Buttons
{
    public sealed class UnpauseVuforiaButton : MonoBehaviour
    {
        [SerializeField] private Button _button;
            
        private void Awake() 
            => _button.onClick.AddListener(Pause);

        private void OnDestroy() 
            => _button.onClick.RemoveListener(Pause);

        private void Pause()
            => VuforiaBehaviour.Instance.enabled = true;
    }
}