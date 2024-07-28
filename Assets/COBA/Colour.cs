using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colour : MonoBehaviour
{
    public Material[] BodyColorMat;
    public Material CurrMat;
    public Renderer renderer;
    public GameObject body;

    void start()
    {
        renderer = body.GetComponent<Renderer>();
    }

    void update()
    {

    }
    public void ABUcolor()
    {
        renderer.material = BodyColorMat[0];
        CurrMat = renderer.material;

    }
     public void BLACKcolor()
    {
        renderer.material = BodyColorMat[1];
        CurrMat = renderer.material;

    }
     public void REDcolor()
    {
        renderer.material = BodyColorMat[2];
        CurrMat = renderer.material;

    }
     public void PUTIHcolor()
    {
        renderer.material = BodyColorMat[3];
        CurrMat = renderer.material;

    }
}
