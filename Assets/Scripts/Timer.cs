using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
 public float timer = 0;

 public TMP_Text textoTimer;
   
 void Udpate(){

    timer = Time.deltaTime;

    //textoTimer.Text = "" + timer.ToString("f0");

 }
}
