using UnityEngine;
using UnityEngine.UI;

namespace Weapons.Buttons
{
    public sealed class EnableObjectButton : MonoBehaviour
    {
        [SerializeField] private Button _button;
        [SerializeField] private GameObject _objectToEnable;
            
        private void Awake() 
            => _button.onClick.AddListener(Enable);

        private void OnDestroy() 
            => _button.onClick.RemoveListener(Enable);

        private void Enable()
            => _objectToEnable.SetActive(true);
    }
}