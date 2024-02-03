using UnityEngine;
using UnityEngine.UI;

namespace WeaponsAR.SceneLoading
{
    public sealed class LoadingView : MonoBehaviour, ILoadingView
    {
        [SerializeField] private Slider _slider;

        public void DisplayLoading(float progress)
            => _slider.value = progress;
    }
}
