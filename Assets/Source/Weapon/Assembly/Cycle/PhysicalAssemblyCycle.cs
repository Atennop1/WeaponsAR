using System.Linq;
using TNRD;
using UnityEngine;

namespace WeaponsAR.Weapon
{
    public sealed class PhysicalAssemblyCycle : MonoBehaviour, IAssemblyCycle
    {
        [TextArea] [SerializeField] private string[] _statesDescriptions;
        [SerializeField] private SerializableInterface<IAssemblyCycleView> _view;

        private IAssemblyCycle _assemblyCycle;

        private void Awake()
            => _assemblyCycle = new AssemblyCycle(_view.Value, _statesDescriptions.Select(description => new AssemblyState(description)).ToList());
        
        public void Continue() 
            => _assemblyCycle.Continue();
    }
}