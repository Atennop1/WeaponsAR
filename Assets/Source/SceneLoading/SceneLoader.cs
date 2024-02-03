using System.Threading.Tasks;
using TNRD;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace WeaponsAR.SceneLoading
{
    public sealed class SceneLoader : MonoBehaviour, ISceneLoader
    {
        [SerializeField] private GameObject _loadingScreen;
        [SerializeField] private SerializableInterface<IScreenFader> _screenFader;
        [SerializeField] private SerializableInterface<ILoadingView> _loadingView;

        public async void Load(SceneData sceneData)
        {
            await _screenFader.Value.StartFadeIn();
            _loadingScreen.SetActive(true);
            
            var loadScreenOperation = SceneManager.LoadSceneAsync(sceneData.Name);
            while (!loadScreenOperation.isDone)
            {
                _loadingView.Value.DisplayLoading(loadScreenOperation.progress);
                await Task.Yield();
            }
        }
    }
}
