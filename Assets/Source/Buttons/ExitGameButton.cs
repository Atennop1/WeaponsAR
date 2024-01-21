using UnityEngine;
using UnityEngine.UI;

namespace Weapons.Buttons
{
    public sealed class ExitGameButton : MonoBehaviour
    {
        [SerializeField] private Button _button;
            
        private void Awake() 
            => _button.onClick.AddListener(Exit);

        private void OnDestroy() 
            => _button.onClick.RemoveListener(Exit);

        private void Exit()
            => Application.Quit();
    }
}