using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switchslide : MonoBehaviour
{
    public GameObject[] slide;
    int index;

    void Start()
    {
        index = 0;
        
    }


    void Update()
    {
        if(index >= 2)
        index = 2;

        if(index <0)
        index = 0;


        if(index == 0)
        {
            slide[0].gameObject.SetActive(true);
        }
    }

    public void next()
    {
        index +=1;

        for(int i = 0 ; i < slide.Length; i++)
        {
            slide[i].gameObject.SetActive(false);
            slide[index].gameObject.SetActive(true);
        }
        Debug.Log(index);
    }

    public void previous()
    {
        index -=1;

        for(int i = 0 ; i < slide.Length; i++)
        {
            slide[i].gameObject.SetActive(false);
            slide[index].gameObject.SetActive(true);
        }
        Debug.Log(index);
    }
}
