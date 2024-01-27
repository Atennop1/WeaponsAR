using TNRD;
using UnityEngine;
using UnityEngine.UI;
using WeaponsAR.Weapon;

namespace WeaponsAR.Buttons
{
    public sealed class ContinueAssemblyButton : MonoBehaviour
    {
        [SerializeField] private Button _button;
        [SerializeField] private SerializableInterface<IAssemblyCycle> _assemblyCycle;

        private void Awake() 
            => _button.onClick.AddListener(Continue);

        private void OnDestroy() 
            => _button.onClick.RemoveListener(Continue);

        private void Continue()
            => _assemblyCycle.Value.Continue();
    }
}