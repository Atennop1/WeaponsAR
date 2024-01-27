using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace WeaponsAR.Weapon
{
    public sealed class AssemblyCycleView : MonoBehaviour, IAssemblyCycleView
    {
        [SerializeField] private Animator _animator;
        [SerializeField] private TMP_Text _text;
        
        [Space]
        [SerializeField] private Button _continueButton;
        [SerializeField] private Button _endButton;

        private readonly int NEXT_ANIMATION = Animator.StringToHash("NextAnimation");

        public void DisplayNextAnimation() 
            => _animator.SetTrigger(NEXT_ANIMATION);

        public void DisplayText(string text) 
            => _text.text = text;

        public void DisplayContinueButton()
        {
            _continueButton.gameObject.SetActive(true);
            _endButton.gameObject.SetActive(false);
        }

        public void DisplayEndButton()
        {
            _continueButton.gameObject.SetActive(false);
            _endButton.gameObject.SetActive(true);
        }
    }
}