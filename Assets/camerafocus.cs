
using UnityEngine;
using System.Collections;
using Vuforia;

public class camerafocus : MonoBehaviour
{
void Start()
    {
        VuforiaApplication.Instance.OnVuforiaStarted += StartVuforiaFocus;
    }

    private void StartVuforiaFocus()
    {
    VuforiaBehaviour.Instance.CameraDevice.SetFocusMode(
        FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
    }


}