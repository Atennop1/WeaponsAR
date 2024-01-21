using UnityEngine;
using UnityEngine.UI;

namespace Weapons.Buttons
{
    public sealed class DisableObjectButton : MonoBehaviour
    {
        [SerializeField] private Button _button;
        [SerializeField] private GameObject _objectToDisable;
            
        private void Awake() 
            => _button.onClick.AddListener(Disable);

        private void OnDestroy() 
            => _button.onClick.RemoveListener(Disable);

        private void Disable()
            => _objectToDisable.SetActive(false);
    }
}