using UnityEngine;
using Vuforia;

namespace Weapons.Camera
{
    public sealed class ARCameraInitializer : MonoBehaviour
    {
        private void Awake()
        {
            VuforiaApplication.Instance.Initialize();
            VuforiaApplication.Instance.OnVuforiaStarted += InitAR;
        }

        private void InitAR() 
            => VuforiaBehaviour.Instance.CameraDevice.SetFocusMode(FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
    }
}