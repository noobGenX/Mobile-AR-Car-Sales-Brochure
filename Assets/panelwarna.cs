using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panelwarna : MonoBehaviour
{
    public GameObject PanelWarna;

    public void OpenPanel()
    {
        if (PanelWarna != null)
        {
            bool isActive = PanelWarna.activeSelf;

            PanelWarna.SetActive(!isActive);
        }
    }
}
