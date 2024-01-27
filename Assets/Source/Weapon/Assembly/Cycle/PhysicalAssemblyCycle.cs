using System.Collections.Generic;
using TNRD;
using UnityEngine;

namespace Weapons.Weapon
{
    public sealed class PhysicalAssemblyCycle : MonoBehaviour, IAssemblyCycle
    {
        [SerializeField] private List<AssemblyState> _states;
        [SerializeField] private SerializableInterface<IAssemblyCycleView> _view;

        private IAssemblyCycle _assemblyCycle;

        private void Awake()
            => _assemblyCycle = new AssemblyCycle(_view.Value, _states);
        
        public void Continue() 
            => _assemblyCycle.Continue();
    }
}