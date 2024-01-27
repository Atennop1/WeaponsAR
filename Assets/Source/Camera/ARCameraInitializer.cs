using UnityEngine;
using Vuforia;

namespace WeaponsAR.Camera
{
    public sealed class ARCameraInitializer : MonoBehaviour
    {
        private void Awake()
        {
            if (VuforiaApplication.Instance.IsInitialized)
                return;
            
            VuforiaApplication.Instance.Initialize();
            VuforiaApplication.Instance.OnVuforiaStarted += InitAR;
        }

        private void InitAR() 
            => VuforiaBehaviour.Instance.CameraDevice.SetFocusMode(FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
    }
}