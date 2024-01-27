using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace WeaponsAR.Buttons
{
    public sealed class LoadSceneButton : MonoBehaviour
    {
        [SerializeField] private Button _button;
        [SerializeField] private int _sceneIndex;
            
        private void Awake() 
            => _button.onClick.AddListener(LoadScene);

        private void OnDestroy() 
            => _button.onClick.RemoveListener(LoadScene);

        private void LoadScene()
            => SceneManager.LoadScene(_sceneIndex);
    }
}