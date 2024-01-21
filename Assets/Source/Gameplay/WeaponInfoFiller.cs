using TMPro;
using UnityEngine;

namespace Weapons.Gameplay
{
    public sealed class WeaponInfoFiller : MonoBehaviour
    {
        [SerializeField] private TMP_Text _text;

        [Space] 
        [SerializeField] private string _weaponName;
        [SerializeField] private string _weaponAuthor;
        [SerializeField] private string _weaponCreationCountry;
        [SerializeField] private string _weaponCreationYear;
        [SerializeField] private string _weaponCaliber;
        
        [Space]
        [TextArea] [SerializeField] private string _weaponHistory;

        private void Awake()
        {
            _text.text = $"Название: {_weaponName}\n" +
                         $"Автор: {_weaponAuthor}\n" +
                         $"Страна: {_weaponCreationCountry}\n" +
                         $"Год создания: {_weaponCreationYear}\n" +
                         $"Калибр: {_weaponCaliber}\n\n" +
                         $"История:\n{_weaponHistory}";
        }
    }
}