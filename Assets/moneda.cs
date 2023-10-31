using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moneda : MonoBehaviour
{
    [SerializeField]private GameObject efecto;


    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
