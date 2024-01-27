using System;
using System.Collections.Generic;

namespace WeaponsAR.Weapon
{
    public sealed class AssemblyCycle : IAssemblyCycle
    {
        private readonly IAssemblyCycleView _view;
        private readonly List<AssemblyState> _states;
        private int _currentStateIndex;
        
        public AssemblyCycle(IAssemblyCycleView view, List<AssemblyState> states)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            _states = states ?? throw new ArgumentNullException(nameof(states));
        }

        public void Continue()
        {
            _view.DisplayNextAnimation();
            
            if (_currentStateIndex == _states.Count)
            {
                _currentStateIndex = 0;
                return;
            }

            _view.DisplayText(_states[_currentStateIndex].Description);
            if (_currentStateIndex == _states.Count - 1)
            {
                _view.DisplayEndButton();
                _currentStateIndex++;
                return;
            }

            _view.DisplayContinueButton();
            _currentStateIndex++;
        }
    }
}