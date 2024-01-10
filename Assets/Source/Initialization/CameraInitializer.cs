using UnityEngine;
using Vuforia;

namespace Weapons.Initialization
{
    public sealed class CameraInitializer : MonoBehaviour
    {
        private void Awake()
        {
            VuforiaApplication.Instance.Initialize(FusionProviderOption.PREFER_PLATFORM_FUSION_PROVIDER);
            VuforiaApplication.Instance.OnVuforiaStarted += InitAR;
        }

        private void InitAR() 
            => VuforiaBehaviour.Instance.CameraDevice.SetFocusMode(FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
    }
}