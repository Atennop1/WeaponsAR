using System.Collections;
using UnityEngine;

namespace Weapons
{
    public sealed class Pinger : MonoBehaviour
    {
        private Coroutine _pingingCoroutine;

        private void Awake() 
            => _pingingCoroutine = StartCoroutine(Ping());

        private void OnDestroy() 
            => StopCoroutine(_pingingCoroutine);

        private IEnumerator Ping()
        {
            var waitForFixedUpdate = new WaitForFixedUpdate();
        
            while (true)
            {
                Debug.Log("Ping");
                yield return waitForFixedUpdate;
            }
        }
    }
}
