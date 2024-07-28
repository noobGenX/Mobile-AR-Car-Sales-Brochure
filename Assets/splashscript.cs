using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class splashscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Example());
        
    }
    IEnumerator Example()
    {
        yield return new WaitForSeconds(5);
        Application.LoadLevel("HomeScene");
        
    }
}
