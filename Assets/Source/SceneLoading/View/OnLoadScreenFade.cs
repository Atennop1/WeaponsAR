using TNRD;
using UnityEngine;

namespace WeaponsAR.SceneLoading
{
    public sealed class OnLoadScreenFade : MonoBehaviour
    {
        [SerializeField] private SerializableInterface<IScreenFader> _fade;

        private void Awake() 
            => _fade.Value.StartFadeOut();
    }
}