using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QUIT : MonoBehaviour
{
    public void keluar()
    {
        Application.Quit();
        Debug.Log("Berhasil keluar");
    }
}
