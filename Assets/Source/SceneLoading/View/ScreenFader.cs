using System;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace WeaponsAR.SceneLoading
{
    public sealed class ScreenFader : MonoBehaviour, IScreenFader
    {
        [SerializeField] private Image _fade;
        
        [Space]
        [SerializeField] private float _fadeInSeconds;
        [SerializeField] private float _fadeOutSeconds;

        public async UniTask StartFadeIn() 
            => await StartFade(true);

        public async UniTask StartFadeOut() 
            => await StartFade(false);

        private async UniTask StartFade(bool isFadeIn)
        {
            var timer = 0f;
            var neededTime = isFadeIn ? _fadeInSeconds : _fadeOutSeconds;
            _fade.raycastTarget = true;
            
            var neededA = isFadeIn ? 1 : 0;
            var originalA = isFadeIn ? 0 : 1;
            _fade.color = new Color(_fade.color.r, _fade.color.g, _fade.color.b, neededA);
            
            while (timer < neededTime)
            {
                timer += Time.deltaTime;
                _fade.color = new Color(_fade.color.r, _fade.color.g, _fade.color.b, Mathf.Lerp(originalA, neededA, timer));
                await UniTask.Yield();
            }
            
            _fade.raycastTarget = false;
        }
    }
}
