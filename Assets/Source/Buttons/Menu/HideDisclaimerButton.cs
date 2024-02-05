using UnityEngine;
using UnityEngine.UI;
using WeaponsAR.Menu;
using WeaponsAR.Saving;
using WeaponsAR.Saving.Paths;

namespace WeaponsAR.Buttons
{
    public sealed class HideDisclaimerButton : MonoBehaviour
    {
        [SerializeField] private Button _button;

        private ISaveStorage<IsDisclaimerHidden> _stateStorage;

        private void Awake()
        {
            _stateStorage = new JsonStorage<IsDisclaimerHidden>(new Path("IsDisclaimerHidden.json"));
            _button.onClick.AddListener(Hide);
        }

        private void OnDestroy() 
            => _button.onClick.RemoveListener(Hide);

        private void Hide()
            => _stateStorage.Save(new IsDisclaimerHidden(true));
    }
}