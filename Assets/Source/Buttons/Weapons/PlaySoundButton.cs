using UnityEngine;
using UnityEngine.UI;

namespace WeaponsAR.Buttons
{
    public sealed class PlaySoundButton : MonoBehaviour
    {
        [SerializeField] private Button _button;
        [SerializeField] private AudioSource _audioSource;
            
        private void Awake() 
            => _button.onClick.AddListener(PlaySound);

        private void OnDestroy() 
            => _button.onClick.RemoveListener(PlaySound);

        private void PlaySound()
            => _audioSource.Play();
    }
}