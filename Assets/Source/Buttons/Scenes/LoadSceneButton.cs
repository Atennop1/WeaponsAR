using TNRD;
using UnityEngine;
using UnityEngine.UI;
using WeaponsAR.SceneLoading;

namespace WeaponsAR.Buttons
{
    public sealed class LoadSceneButton : MonoBehaviour
    {
        [SerializeField] private Button _button;
        [SerializeField] private SerializableInterface<ISceneLoader> _sceneLoader;
        [SerializeField] private SceneData _sceneData;
            
        private void Awake() 
            => _button.onClick.AddListener(LoadScene);

        private void OnDestroy() 
            => _button.onClick.RemoveListener(LoadScene);

        private void LoadScene()
            => _sceneLoader.Value.Load(_sceneData);
    }
}