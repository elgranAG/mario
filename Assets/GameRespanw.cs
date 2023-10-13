using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRespanw : MonoBehaviour
{
   public float threshold;
   void FixedUpdate()
   {
    if(transform.position.y < threshold){
        transform.position = new Vector3(0f, 4.26f, 0f);
    }
   }
}
