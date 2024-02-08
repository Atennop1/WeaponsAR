using UnityEngine;
using WeaponsAR.Saving;
using WeaponsAR.Saving.Paths;

namespace WeaponsAR.Menu
{
    public sealed class DisclaimerDisabler : MonoBehaviour
    {
        [SerializeField] private GameObject _disclaimer;

        private void Awake()
        {
            var stateStorage = new JsonStorage<IsDisclaimerHidden>(new Path("IsDisclaimerHidden.json")); 
            _disclaimer.SetActive(!stateStorage.HasSave() || !stateStorage.Load().Value);
        }
    }
}
