using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openURL : MonoBehaviour
{
  public void openMaps()
  {
    Application.OpenURL("https://www.google.com/maps/place/Mitsubishi+Jogjakarta/@-7.7839997,110.4137416,17z/data=!4m12!1m6!3m5!1s0x2e7a598a0788a82b:0x3efef4b7285c62a6!2sPT+Borobudur+Oto+Mobil!8m2!3d-7.7678444!4d110.4261877!3m4!1s0x2e7a59d7afb0f6cf:0x5f5a5e3a7893410f!8m2!3d-7.7837192!4d110.4165296");
  }
}
